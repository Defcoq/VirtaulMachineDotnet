namespace B32Machine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRegisters = new System.Windows.Forms.Panel();
            this.lblRegisters = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS1SecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS2SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS3SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS4SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS5SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeNoDelayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS12SecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS14SecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b32Screen1 = new B32Machine.B32Screen();
            this.msMainMenu.SuspendLayout();
            this.pnlRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(644, 24);
            this.msMainMenu.TabIndex = 1;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.speedToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // pnlRegisters
            // 
            this.pnlRegisters.Controls.Add(this.lblRegisters);
            this.pnlRegisters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRegisters.Location = new System.Drawing.Point(0, 304);
            this.pnlRegisters.Name = "pnlRegisters";
            this.pnlRegisters.Size = new System.Drawing.Size(644, 54);
            this.pnlRegisters.TabIndex = 2;
            // 
            // lblRegisters
            // 
            this.lblRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegisters.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisters.Location = new System.Drawing.Point(0, 0);
            this.lblRegisters.Name = "lblRegisters";
            this.lblRegisters.Size = new System.Drawing.Size(644, 54);
            this.lblRegisters.TabIndex = 0;
            this.lblRegisters.Text = "label1";
            this.lblRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "B32";
            this.openFileDialog1.Filter = "B32 Files | *.B32";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mS14SecondToolStripMenuItem,
            this.mS12SecondToolStripMenuItem,
            this.mS1SecondToolStripMenuItem,
            this.mS2SecondsToolStripMenuItem,
            this.mS3SecondsToolStripMenuItem,
            this.mS4SecondsToolStripMenuItem,
            this.mS5SecondsToolStripMenuItem,
            this.realTimeNoDelayToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // mS1SecondToolStripMenuItem
            // 
            this.mS1SecondToolStripMenuItem.Name = "mS1SecondToolStripMenuItem";
            this.mS1SecondToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS1SecondToolStripMenuItem.Text = "1000 MS (1 Second)";
            this.mS1SecondToolStripMenuItem.Click += new System.EventHandler(this.mS1SecondToolStripMenuItem_Click);
            // 
            // mS2SecondsToolStripMenuItem
            // 
            this.mS2SecondsToolStripMenuItem.Name = "mS2SecondsToolStripMenuItem";
            this.mS2SecondsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS2SecondsToolStripMenuItem.Text = "2000 MS (2 Seconds)";
            this.mS2SecondsToolStripMenuItem.Click += new System.EventHandler(this.mS2SecondsToolStripMenuItem_Click);
            // 
            // mS3SecondsToolStripMenuItem
            // 
            this.mS3SecondsToolStripMenuItem.Name = "mS3SecondsToolStripMenuItem";
            this.mS3SecondsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS3SecondsToolStripMenuItem.Text = "3000 MS (3 Seconds)";
            this.mS3SecondsToolStripMenuItem.Click += new System.EventHandler(this.mS3SecondsToolStripMenuItem_Click);
            // 
            // mS4SecondsToolStripMenuItem
            // 
            this.mS4SecondsToolStripMenuItem.Name = "mS4SecondsToolStripMenuItem";
            this.mS4SecondsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS4SecondsToolStripMenuItem.Text = "4000 MS (4 Seconds)";
            this.mS4SecondsToolStripMenuItem.Click += new System.EventHandler(this.mS4SecondsToolStripMenuItem_Click);
            // 
            // mS5SecondsToolStripMenuItem
            // 
            this.mS5SecondsToolStripMenuItem.Name = "mS5SecondsToolStripMenuItem";
            this.mS5SecondsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS5SecondsToolStripMenuItem.Text = "5000 MS (5 Seconds)";
            this.mS5SecondsToolStripMenuItem.Click += new System.EventHandler(this.mS5SecondsToolStripMenuItem_Click);
            // 
            // realTimeNoDelayToolStripMenuItem
            // 
            this.realTimeNoDelayToolStripMenuItem.Name = "realTimeNoDelayToolStripMenuItem";
            this.realTimeNoDelayToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.realTimeNoDelayToolStripMenuItem.Text = "Real Time (No Delay)";
            this.realTimeNoDelayToolStripMenuItem.Click += new System.EventHandler(this.realTimeNoDelayToolStripMenuItem_Click);
            // 
            // mS12SecondToolStripMenuItem
            // 
            this.mS12SecondToolStripMenuItem.Name = "mS12SecondToolStripMenuItem";
            this.mS12SecondToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS12SecondToolStripMenuItem.Text = "500 MS (1/2 Second)";
            this.mS12SecondToolStripMenuItem.Click += new System.EventHandler(this.mS12SecondToolStripMenuItem_Click);
            // 
            // mS14SecondToolStripMenuItem
            // 
            this.mS14SecondToolStripMenuItem.Name = "mS14SecondToolStripMenuItem";
            this.mS14SecondToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mS14SecondToolStripMenuItem.Text = "250 MS (1/4 Second)";
            this.mS14SecondToolStripMenuItem.Click += new System.EventHandler(this.mS14SecondToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartProgramToolStripMenuItem,
            this.pauseProgramToolStripMenuItem,
            this.resumeProgramToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // restartProgramToolStripMenuItem
            // 
            this.restartProgramToolStripMenuItem.Name = "restartProgramToolStripMenuItem";
            this.restartProgramToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.restartProgramToolStripMenuItem.Text = "Restart Program";
            this.restartProgramToolStripMenuItem.Click += new System.EventHandler(this.restartProgramToolStripMenuItem_Click);
            // 
            // pauseProgramToolStripMenuItem
            // 
            this.pauseProgramToolStripMenuItem.Name = "pauseProgramToolStripMenuItem";
            this.pauseProgramToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pauseProgramToolStripMenuItem.Text = "Pause Program";
            this.pauseProgramToolStripMenuItem.Click += new System.EventHandler(this.pauseProgramToolStripMenuItem_Click);
            // 
            // resumeProgramToolStripMenuItem
            // 
            this.resumeProgramToolStripMenuItem.Name = "resumeProgramToolStripMenuItem";
            this.resumeProgramToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.resumeProgramToolStripMenuItem.Text = "Resume Program";
            this.resumeProgramToolStripMenuItem.Click += new System.EventHandler(this.resumeProgramToolStripMenuItem_Click);
            // 
            // b32Screen1
            // 
            this.b32Screen1.BackColor = System.Drawing.Color.Black;
            this.b32Screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b32Screen1.Location = new System.Drawing.Point(0, 24);
            this.b32Screen1.Name = "b32Screen1";
            this.b32Screen1.ScreenMemoryLocation = ((ushort)(40960));
            this.b32Screen1.Size = new System.Drawing.Size(644, 334);
            this.b32Screen1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 358);
            this.Controls.Add(this.pnlRegisters);
            this.Controls.Add(this.b32Screen1);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.pnlRegisters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B32Screen b32Screen1;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRegisters;
        private System.Windows.Forms.Label lblRegisters;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS14SecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS12SecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS1SecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS2SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS3SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS4SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS5SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeNoDelayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeProgramToolStripMenuItem;
    }
}

