namespace MaiLauncher;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Black;
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 394);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(200);
        panel1.Size = new Size(800, 563);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("HYWenHei-85W", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(200, 200);
        label1.Name = "label1";
        label1.Size = new Size(94, 33);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(800, 957);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        ImeMode = ImeMode.Off;
        KeyPreview = true;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        WindowState = FormWindowState.Maximized;
        Load += Form1_Load;
        KeyPress += Form1_KeyPress;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
}