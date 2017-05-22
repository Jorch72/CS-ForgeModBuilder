﻿using System.Windows.Forms;

namespace ForgeModBuilder
{
    partial class FMB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMB));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleFontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.OpenProjectButton = new System.Windows.Forms.Button();
            this.BuildProjectButton = new System.Windows.Forms.Button();
            this.UpdateProjectButton = new System.Windows.Forms.Button();
            this.SetupProjectButton = new System.Windows.Forms.Button();
            this.RefreshProjectButton = new System.Windows.Forms.Button();
            this.RefreshProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(784, 24);
            this.Menu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenProjectMenuItem,
            this.BuildProjectMenuItem,
            this.SetupProjectMenuItem,
            this.UpdateProjectMenuItem,
            this.RefreshProjectMenuItem,
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenProjectMenuItem
            // 
            this.OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            this.OpenProjectMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpenProjectMenuItem.Text = "Open Project";
            this.OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProjectClick);
            // 
            // BuildProjectMenuItem
            // 
            this.BuildProjectMenuItem.Name = "BuildProjectMenuItem";
            this.BuildProjectMenuItem.Size = new System.Drawing.Size(153, 22);
            this.BuildProjectMenuItem.Text = "Build Project";
            this.BuildProjectMenuItem.Click += new System.EventHandler(this.BuildProjectClick);
            // 
            // SetupProjectMenuItem
            // 
            this.SetupProjectMenuItem.Name = "SetupProjectMenuItem";
            this.SetupProjectMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SetupProjectMenuItem.Text = "Setup Project";
            this.SetupProjectMenuItem.Click += new System.EventHandler(this.SetupProjectClick);
            // 
            // UpdateProjectMenuItem
            // 
            this.UpdateProjectMenuItem.Name = "UpdateProjectMenuItem";
            this.UpdateProjectMenuItem.Size = new System.Drawing.Size(153, 22);
            this.UpdateProjectMenuItem.Text = "Update Project";
            this.UpdateProjectMenuItem.Click += new System.EventHandler(this.UpdateProjectClick);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsoleFontMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ConsoleFontMenuItem
            // 
            this.ConsoleFontMenuItem.Name = "ConsoleFontMenuItem";
            this.ConsoleFontMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ConsoleFontMenuItem.Text = "Console Font";
            this.ConsoleFontMenuItem.Click += new System.EventHandler(this.ConsoleFontMenuItem_Click);
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Console.Location = new System.Drawing.Point(0, 24);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(784, 460);
            this.Console.TabIndex = 1;
            this.Console.Text = "";
            // 
            // OpenProjectButton
            // 
            this.OpenProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenProjectButton.Location = new System.Drawing.Point(10, 493);
            this.OpenProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.OpenProjectButton.Name = "OpenProjectButton";
            this.OpenProjectButton.Size = new System.Drawing.Size(113, 59);
            this.OpenProjectButton.TabIndex = 2;
            this.OpenProjectButton.Text = "Open Project";
            this.OpenProjectButton.UseVisualStyleBackColor = true;
            this.OpenProjectButton.Click += new System.EventHandler(this.OpenProjectClick);
            // 
            // BuildProjectButton
            // 
            this.BuildProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BuildProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BuildProjectButton.Location = new System.Drawing.Point(129, 493);
            this.BuildProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.BuildProjectButton.Name = "BuildProjectButton";
            this.BuildProjectButton.Size = new System.Drawing.Size(113, 59);
            this.BuildProjectButton.TabIndex = 3;
            this.BuildProjectButton.Text = "Build Project";
            this.BuildProjectButton.UseVisualStyleBackColor = true;
            this.BuildProjectButton.Click += new System.EventHandler(this.BuildProjectClick);
            // 
            // UpdateProjectButton
            // 
            this.UpdateProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateProjectButton.Location = new System.Drawing.Point(367, 493);
            this.UpdateProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.UpdateProjectButton.Name = "UpdateProjectButton";
            this.UpdateProjectButton.Size = new System.Drawing.Size(113, 59);
            this.UpdateProjectButton.TabIndex = 4;
            this.UpdateProjectButton.Text = "Update Project";
            this.UpdateProjectButton.UseVisualStyleBackColor = true;
            this.UpdateProjectButton.Click += new System.EventHandler(this.UpdateProjectClick);
            // 
            // SetupProjectButton
            // 
            this.SetupProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetupProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SetupProjectButton.Location = new System.Drawing.Point(248, 493);
            this.SetupProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.SetupProjectButton.Name = "SetupProjectButton";
            this.SetupProjectButton.Size = new System.Drawing.Size(113, 59);
            this.SetupProjectButton.TabIndex = 5;
            this.SetupProjectButton.Text = "Setup Project";
            this.SetupProjectButton.UseVisualStyleBackColor = true;
            this.SetupProjectButton.Click += new System.EventHandler(this.SetupProjectClick);
            // 
            // RefreshProjectButton
            // 
            this.RefreshProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshProjectButton.Location = new System.Drawing.Point(486, 493);
            this.RefreshProjectButton.MinimumSize = new System.Drawing.Size(113, 59);
            this.RefreshProjectButton.Name = "RefreshProjectButton";
            this.RefreshProjectButton.Size = new System.Drawing.Size(113, 59);
            this.RefreshProjectButton.TabIndex = 6;
            this.RefreshProjectButton.Text = "Refresh Porject";
            this.RefreshProjectButton.UseVisualStyleBackColor = true;
            this.RefreshProjectButton.Click += new System.EventHandler(this.RefreshProjectClick);
            // 
            // RefreshProjectMenuItem
            // 
            this.RefreshProjectMenuItem.Name = "RefreshProjectMenuItem";
            this.RefreshProjectMenuItem.Size = new System.Drawing.Size(153, 22);
            this.RefreshProjectMenuItem.Text = "Refresh Project";
            this.RefreshProjectMenuItem.Click += new System.EventHandler(this.RefreshProjectClick);
            // 
            // FMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RefreshProjectButton);
            this.Controls.Add(this.SetupProjectButton);
            this.Controls.Add(this.UpdateProjectButton);
            this.Controls.Add(this.BuildProjectButton);
            this.Controls.Add(this.OpenProjectButton);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forge Mod Builder";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupProjectMenuItem;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Button OpenProjectButton;
        private System.Windows.Forms.Button BuildProjectButton;
        private System.Windows.Forms.Button UpdateProjectButton;
        private System.Windows.Forms.Button SetupProjectButton;
        private System.Windows.Forms.ToolStripMenuItem UpdateProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem ConsoleFontMenuItem;
        private Button RefreshProjectButton;
        private ToolStripMenuItem RefreshProjectMenuItem;
    }
}
