using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using MaiLauncher.Types;
using System.Diagnostics;
using System.Linq;

namespace MaiLauncher;

public partial class Form1 : Form
{
    private List<Entry> entries;
    private bool running = false;
    public Form1()
    {
        InitializeComponent();
        var yamlFile = File.ReadAllText("D:\\launcher.yaml");
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)  // see height_in_inches in sample yml 
            .Build();
        this.entries = deserializer.Deserialize<List<Entry>>(yamlFile);

        label1.Text = "";
        foreach (var entry in entries)
        {
            label1.Text += entry.KeyDisplay + " -> " + entry.Name + "\n";
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        panel1.Height = this.Width;
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (running) return;
        Debug.WriteLine(e.KeyChar);
        var entry = this.entries.Find(it => it.Key == e.KeyChar);
        if (entry is null) return;
        if (entry.Exit)
        {
            Application.Exit();
            return;
        }

        RunCommands(entry.Commands);
    }

    private async Task RunCommands(List<Command> commands)
    {
        running = true;
        var formAlls = new FormAlls();
        formAlls.Show();
        List<Process> processes = [];

        try
        {
            foreach (var command in commands)
            {
                Process process = new();
                int firstSpaceIndex = command.Exec.IndexOf(' ');
                if (firstSpaceIndex == -1)
                {
                    process.StartInfo.FileName = command.Exec;
                }
                else
                {
                    process.StartInfo.FileName = command.Exec.Substring(0, firstSpaceIndex);
                    process.StartInfo.Arguments = command.Exec.Substring(firstSpaceIndex + 1);
                }
                process.StartInfo.UseShellExecute = true;
                if (command.Hidden)
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.WorkingDirectory = command.WorkDir;

                var result = process.Start();
                Debug.WriteLine(result);
                processes.Add(process);
            }

            var last = processes.Last();
            await last.WaitForExitAsync();
            foreach (var process in processes)
            {
                process.Kill();
                process.Dispose();
            }
        }
        catch (Exception ex)
        {
            label1.Text = ex.ToString();
        }

        formAlls.Close();
        formAlls.Dispose();
        running = false;
    }
}