﻿namespace DedcordPatcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DMTab = new System.Windows.Forms.TabPage();
            this.PluginManagerTabs = new System.Windows.Forms.TabControl();
            this.PluginsMenu = new System.Windows.Forms.TabPage();
            this.InstalledPluginList = new System.Windows.Forms.ListBox();
            this.ExtraPluginOptions = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomPluginsPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomPlugin = new System.Windows.Forms.TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.PluginsFetch = new System.Windows.Forms.Button();
            this.Pluginlistlink = new System.Windows.Forms.TextBox();
            this.PluginList = new System.Windows.Forms.CheckedListBox();
            this.DVTab = new System.Windows.Forms.TabPage();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordCanary = new System.Windows.Forms.CheckBox();
            this.DiscordPTB = new System.Windows.Forms.CheckBox();
            this.Discord = new System.Windows.Forms.CheckBox();
            this.LaunchInstaller = new System.Windows.Forms.Button();
            this.RebuildAndRestart = new System.Windows.Forms.Button();
            this.RebuildClient = new System.Windows.Forms.Button();
            this.InstallPackages = new System.Windows.Forms.Button();
            this.GitClone = new System.Windows.Forms.Button();
            this.ClientDetector = new System.Windows.Forms.Label();
            this.RepoLink = new System.Windows.Forms.TextBox();
            this.AppTabs = new System.Windows.Forms.TabControl();
            this.Logtab = new System.Windows.Forms.TabPage();
            this.Logbox = new System.Windows.Forms.RichTextBox();
            this.DMTab.SuspendLayout();
            this.PluginManagerTabs.SuspendLayout();
            this.PluginsMenu.SuspendLayout();
            this.ExtraPluginOptions.SuspendLayout();
            this.DVTab.SuspendLayout();
            this.AppTabs.SuspendLayout();
            this.Logtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DMTab
            // 
            this.DMTab.Controls.Add(this.PluginManagerTabs);
            this.DMTab.Controls.Add(this.PluginsFetch);
            this.DMTab.Controls.Add(this.Pluginlistlink);
            this.DMTab.Controls.Add(this.PluginList);
            this.DMTab.Location = new System.Drawing.Point(4, 25);
            this.DMTab.Name = "DMTab";
            this.DMTab.Padding = new System.Windows.Forms.Padding(3);
            this.DMTab.Size = new System.Drawing.Size(792, 421);
            this.DMTab.TabIndex = 1;
            this.DMTab.Text = "Download plugins";
            this.DMTab.UseVisualStyleBackColor = true;
            // 
            // PluginManagerTabs
            // 
            this.PluginManagerTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginManagerTabs.Controls.Add(this.PluginsMenu);
            this.PluginManagerTabs.Controls.Add(this.ExtraPluginOptions);
            this.PluginManagerTabs.Location = new System.Drawing.Point(398, 40);
            this.PluginManagerTabs.Name = "PluginManagerTabs";
            this.PluginManagerTabs.SelectedIndex = 0;
            this.PluginManagerTabs.Size = new System.Drawing.Size(378, 361);
            this.PluginManagerTabs.TabIndex = 7;
            // 
            // PluginsMenu
            // 
            this.PluginsMenu.Controls.Add(this.InstalledPluginList);
            this.PluginsMenu.Location = new System.Drawing.Point(4, 25);
            this.PluginsMenu.Name = "PluginsMenu";
            this.PluginsMenu.Padding = new System.Windows.Forms.Padding(3);
            this.PluginsMenu.Size = new System.Drawing.Size(370, 332);
            this.PluginsMenu.TabIndex = 0;
            this.PluginsMenu.Text = "Plugins";
            this.PluginsMenu.UseVisualStyleBackColor = true;
            // 
            // InstalledPluginList
            // 
            this.InstalledPluginList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstalledPluginList.FormattingEnabled = true;
            this.InstalledPluginList.ItemHeight = 16;
            this.InstalledPluginList.Location = new System.Drawing.Point(3, 3);
            this.InstalledPluginList.Name = "InstalledPluginList";
            this.InstalledPluginList.Size = new System.Drawing.Size(364, 326);
            this.InstalledPluginList.TabIndex = 0;
            this.InstalledPluginList.SelectedIndexChanged += new System.EventHandler(this.InstalledPluginList_SelectedIndexChanged);
            this.InstalledPluginList.DoubleClick += new System.EventHandler(this.InstalledPluginList_DoubleClick);
            // 
            // ExtraPluginOptions
            // 
            this.ExtraPluginOptions.Controls.Add(this.listBox1);
            this.ExtraPluginOptions.Controls.Add(this.label2);
            this.ExtraPluginOptions.Controls.Add(this.CustomPluginsPath);
            this.ExtraPluginOptions.Controls.Add(this.button1);
            this.ExtraPluginOptions.Controls.Add(this.CustomPlugin);
            this.ExtraPluginOptions.Controls.Add(this.FormatLabel);
            this.ExtraPluginOptions.Location = new System.Drawing.Point(4, 25);
            this.ExtraPluginOptions.Name = "ExtraPluginOptions";
            this.ExtraPluginOptions.Padding = new System.Windows.Forms.Padding(3);
            this.ExtraPluginOptions.Size = new System.Drawing.Size(370, 332);
            this.ExtraPluginOptions.TabIndex = 1;
            this.ExtraPluginOptions.Text = "Extra";
            this.ExtraPluginOptions.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Github Plugin",
            "Script",
            "Zip",
            "Index Radar"});
            this.listBox1.Location = new System.Drawing.Point(9, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 68);
            this.listBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Custom Plugin folder:";
            // 
            // CustomPluginsPath
            // 
            this.CustomPluginsPath.Location = new System.Drawing.Point(9, 31);
            this.CustomPluginsPath.Name = "CustomPluginsPath";
            this.CustomPluginsPath.Size = new System.Drawing.Size(112, 22);
            this.CustomPluginsPath.TabIndex = 8;
            this.CustomPluginsPath.Text = "\\src\\UserPlugins";
            this.CustomPluginsPath.TextChanged += new System.EventHandler(this.CustomPluginsPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "||\r\n\\/";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomPlugin
            // 
            this.CustomPlugin.Location = new System.Drawing.Point(9, 76);
            this.CustomPlugin.Name = "CustomPlugin";
            this.CustomPlugin.Size = new System.Drawing.Size(226, 22);
            this.CustomPlugin.TabIndex = 3;
            this.CustomPlugin.Text = "Install Unindexed plugin (URL)";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(9, 106);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(52, 16);
            this.FormatLabel.TabIndex = 5;
            this.FormatLabel.Text = "Format:";
            // 
            // PluginsFetch
            // 
            this.PluginsFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginsFetch.Location = new System.Drawing.Point(701, 12);
            this.PluginsFetch.Name = "PluginsFetch";
            this.PluginsFetch.Size = new System.Drawing.Size(75, 23);
            this.PluginsFetch.TabIndex = 2;
            this.PluginsFetch.Text = "Fetch";
            this.PluginsFetch.UseVisualStyleBackColor = true;
            this.PluginsFetch.Click += new System.EventHandler(this.PluginsFetch_Click);
            // 
            // Pluginlistlink
            // 
            this.Pluginlistlink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pluginlistlink.Location = new System.Drawing.Point(8, 12);
            this.Pluginlistlink.Name = "Pluginlistlink";
            this.Pluginlistlink.Size = new System.Drawing.Size(686, 22);
            this.Pluginlistlink.TabIndex = 1;
            this.Pluginlistlink.Text = "https://raw.githubusercontent.com/DED0026/DedcordPatcher/master/PluginIndex";
            // 
            // PluginList
            // 
            this.PluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginList.CheckOnClick = true;
            this.PluginList.FormattingEnabled = true;
            this.PluginList.Location = new System.Drawing.Point(8, 40);
            this.PluginList.Name = "PluginList";
            this.PluginList.Size = new System.Drawing.Size(384, 361);
            this.PluginList.TabIndex = 0;
            this.PluginList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PluginList_ItemCheck);
            // 
            // DVTab
            // 
            this.DVTab.Controls.Add(this.OpenFolder);
            this.DVTab.Controls.Add(this.label1);
            this.DVTab.Controls.Add(this.DiscordCanary);
            this.DVTab.Controls.Add(this.DiscordPTB);
            this.DVTab.Controls.Add(this.Discord);
            this.DVTab.Controls.Add(this.LaunchInstaller);
            this.DVTab.Controls.Add(this.RebuildAndRestart);
            this.DVTab.Controls.Add(this.RebuildClient);
            this.DVTab.Controls.Add(this.InstallPackages);
            this.DVTab.Controls.Add(this.GitClone);
            this.DVTab.Controls.Add(this.ClientDetector);
            this.DVTab.Controls.Add(this.RepoLink);
            this.DVTab.Location = new System.Drawing.Point(4, 25);
            this.DVTab.Name = "DVTab";
            this.DVTab.Padding = new System.Windows.Forms.Padding(3);
            this.DVTab.Size = new System.Drawing.Size(792, 421);
            this.DVTab.TabIndex = 0;
            this.DVTab.Text = "Client manager";
            this.DVTab.UseVisualStyleBackColor = true;
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(635, 96);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(23, 23);
            this.OpenFolder.TabIndex = 9;
            this.OpenFolder.Text = "💾";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Restart:";
            // 
            // DiscordCanary
            // 
            this.DiscordCanary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiscordCanary.AutoSize = true;
            this.DiscordCanary.Checked = true;
            this.DiscordCanary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordCanary.Location = new System.Drawing.Point(337, 288);
            this.DiscordCanary.Name = "DiscordCanary";
            this.DiscordCanary.Size = new System.Drawing.Size(119, 20);
            this.DiscordCanary.TabIndex = 7;
            this.DiscordCanary.Text = "DiscordCanary";
            this.DiscordCanary.UseVisualStyleBackColor = true;
            // 
            // DiscordPTB
            // 
            this.DiscordPTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiscordPTB.AutoSize = true;
            this.DiscordPTB.Checked = true;
            this.DiscordPTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordPTB.Location = new System.Drawing.Point(345, 262);
            this.DiscordPTB.Name = "DiscordPTB";
            this.DiscordPTB.Size = new System.Drawing.Size(103, 20);
            this.DiscordPTB.TabIndex = 7;
            this.DiscordPTB.Text = "DiscordPTB";
            this.DiscordPTB.UseVisualStyleBackColor = true;
            // 
            // Discord
            // 
            this.Discord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Discord.AutoSize = true;
            this.Discord.Checked = true;
            this.Discord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Discord.Location = new System.Drawing.Point(358, 236);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(76, 20);
            this.Discord.TabIndex = 7;
            this.Discord.Text = "Discord";
            this.Discord.UseVisualStyleBackColor = true;
            // 
            // LaunchInstaller
            // 
            this.LaunchInstaller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaunchInstaller.Location = new System.Drawing.Point(309, 341);
            this.LaunchInstaller.Name = "LaunchInstaller";
            this.LaunchInstaller.Size = new System.Drawing.Size(174, 23);
            this.LaunchInstaller.TabIndex = 3;
            this.LaunchInstaller.Text = "Launch installer";
            this.LaunchInstaller.UseVisualStyleBackColor = true;
            this.LaunchInstaller.Click += new System.EventHandler(this.LaunchInstaller_Click);
            // 
            // RebuildAndRestart
            // 
            this.RebuildAndRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RebuildAndRestart.Location = new System.Drawing.Point(309, 312);
            this.RebuildAndRestart.Name = "RebuildAndRestart";
            this.RebuildAndRestart.Size = new System.Drawing.Size(174, 23);
            this.RebuildAndRestart.TabIndex = 4;
            this.RebuildAndRestart.Text = "Rebuild and Restart";
            this.RebuildAndRestart.UseVisualStyleBackColor = true;
            this.RebuildAndRestart.Click += new System.EventHandler(this.RebuildAndRestart_Click);
            // 
            // RebuildClient
            // 
            this.RebuildClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RebuildClient.Location = new System.Drawing.Point(309, 183);
            this.RebuildClient.Name = "RebuildClient";
            this.RebuildClient.Size = new System.Drawing.Size(174, 23);
            this.RebuildClient.TabIndex = 5;
            this.RebuildClient.Text = "Rebuild";
            this.RebuildClient.UseVisualStyleBackColor = true;
            this.RebuildClient.Click += new System.EventHandler(this.RebuildClient_Click);
            // 
            // InstallPackages
            // 
            this.InstallPackages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstallPackages.Location = new System.Drawing.Point(309, 154);
            this.InstallPackages.Name = "InstallPackages";
            this.InstallPackages.Size = new System.Drawing.Size(174, 23);
            this.InstallPackages.TabIndex = 6;
            this.InstallPackages.Text = "Install packages";
            this.InstallPackages.UseVisualStyleBackColor = true;
            this.InstallPackages.Click += new System.EventHandler(this.InstallPackages_Click);
            // 
            // GitClone
            // 
            this.GitClone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GitClone.Location = new System.Drawing.Point(464, 96);
            this.GitClone.Name = "GitClone";
            this.GitClone.Size = new System.Drawing.Size(75, 23);
            this.GitClone.TabIndex = 2;
            this.GitClone.Text = "Git clone";
            this.GitClone.UseVisualStyleBackColor = true;
            this.GitClone.Click += new System.EventHandler(this.GitClone_Click);
            // 
            // ClientDetector
            // 
            this.ClientDetector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientDetector.AutoSize = true;
            this.ClientDetector.Location = new System.Drawing.Point(545, 99);
            this.ClientDetector.Name = "ClientDetector";
            this.ClientDetector.Size = new System.Drawing.Size(43, 16);
            this.ClientDetector.TabIndex = 1;
            this.ClientDetector.Text = "Client:";
            // 
            // RepoLink
            // 
            this.RepoLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepoLink.Location = new System.Drawing.Point(211, 96);
            this.RepoLink.Name = "RepoLink";
            this.RepoLink.Size = new System.Drawing.Size(247, 22);
            this.RepoLink.TabIndex = 0;
            this.RepoLink.Text = "https://github.com/Vendicated/Vencord";
            this.RepoLink.TextChanged += new System.EventHandler(this.RepoLink_TextChanged);
            // 
            // AppTabs
            // 
            this.AppTabs.Controls.Add(this.DVTab);
            this.AppTabs.Controls.Add(this.DMTab);
            this.AppTabs.Controls.Add(this.Logtab);
            this.AppTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabs.Location = new System.Drawing.Point(0, 0);
            this.AppTabs.Name = "AppTabs";
            this.AppTabs.SelectedIndex = 0;
            this.AppTabs.Size = new System.Drawing.Size(800, 450);
            this.AppTabs.TabIndex = 1;
            this.AppTabs.SelectedIndexChanged += new System.EventHandler(this.AppTabs_SelectedIndexChanged);
            // 
            // Logtab
            // 
            this.Logtab.Controls.Add(this.Logbox);
            this.Logtab.Location = new System.Drawing.Point(4, 25);
            this.Logtab.Name = "Logtab";
            this.Logtab.Padding = new System.Windows.Forms.Padding(3);
            this.Logtab.Size = new System.Drawing.Size(792, 421);
            this.Logtab.TabIndex = 3;
            this.Logtab.Text = "Log";
            this.Logtab.UseVisualStyleBackColor = true;
            // 
            // Logbox
            // 
            this.Logbox.BackColor = System.Drawing.Color.Black;
            this.Logbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logbox.ForeColor = System.Drawing.Color.Lime;
            this.Logbox.Location = new System.Drawing.Point(3, 3);
            this.Logbox.Name = "Logbox";
            this.Logbox.Size = new System.Drawing.Size(786, 415);
            this.Logbox.TabIndex = 0;
            this.Logbox.Text = resources.GetString("Logbox.Text");
            this.Logbox.TextChanged += new System.EventHandler(this.Logbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DMTab.ResumeLayout(false);
            this.DMTab.PerformLayout();
            this.PluginManagerTabs.ResumeLayout(false);
            this.PluginsMenu.ResumeLayout(false);
            this.ExtraPluginOptions.ResumeLayout(false);
            this.ExtraPluginOptions.PerformLayout();
            this.DVTab.ResumeLayout(false);
            this.DVTab.PerformLayout();
            this.AppTabs.ResumeLayout(false);
            this.Logtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage DMTab;
        private System.Windows.Forms.TabPage DVTab;
        private System.Windows.Forms.TextBox RepoLink;
        private System.Windows.Forms.TabControl AppTabs;
        private System.Windows.Forms.Label ClientDetector;
        private System.Windows.Forms.Button GitClone;
        private System.Windows.Forms.TabPage Logtab;
        private System.Windows.Forms.RichTextBox Logbox;
        private System.Windows.Forms.Button LaunchInstaller;
        private System.Windows.Forms.Button RebuildAndRestart;
        private System.Windows.Forms.Button RebuildClient;
        private System.Windows.Forms.Button InstallPackages;
        private System.Windows.Forms.CheckedListBox PluginList;
        private System.Windows.Forms.Button PluginsFetch;
        private System.Windows.Forms.TextBox Pluginlistlink;
        private System.Windows.Forms.CheckBox DiscordCanary;
        private System.Windows.Forms.CheckBox DiscordPTB;
        private System.Windows.Forms.CheckBox Discord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomPlugin;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.TabControl PluginManagerTabs;
        private System.Windows.Forms.TabPage PluginsMenu;
        private System.Windows.Forms.TabPage ExtraPluginOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox InstalledPluginList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomPluginsPath;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.ListBox listBox1;
    }
}

