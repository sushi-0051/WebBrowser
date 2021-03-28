﻿
namespace WebBrowser.UI
{
    partial class WebBrowserFormM3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserFormM3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.BookMarkButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBox = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabUserControl5 = new WebBrowser.UI.TabUserControl();
            this.tabUserControl4 = new WebBrowser.UI.TabUserControl();
            this.tabUserControl2 = new WebBrowser.UI.TabUserControl();
            this.tabUserControl1 = new WebBrowser.UI.TabUserControl();
            this.tabUserControl3 = new WebBrowser.UI.TabUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip1_KeyDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitWebBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click_1);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
            this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
            // 
            // savePageAsHTMLToolStripMenuItem
            // 
            this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
            this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.savePageAsHTMLToolStripMenuItem.Text = "Save Page As HTML";
            this.savePageAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.savePageAsHTMLToolStripMenuItem_Click);
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.printPageToolStripMenuItem.Text = "Print Page";
            this.printPageToolStripMenuItem.Click += new System.EventHandler(this.printPageToolStripMenuItem_Click);
            // 
            // exitWebBrowserToolStripMenuItem
            // 
            this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
            this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser";
            this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // manageHistoryToolStripMenuItem
            // 
            this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
            this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.manageHistoryToolStripMenuItem.Text = "Manage History";
            this.manageHistoryToolStripMenuItem.Click += new System.EventHandler(this.manageHistoryToolStripMenuItem_Click);
            // 
            // manageBookmarksToolStripMenuItem
            // 
            this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
            this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
            this.manageBookmarksToolStripMenuItem.Click += new System.EventHandler(this.manageBookmarksToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 21);
            this.tabControl1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(772, 461);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.ContentPanel.Visible = false;
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(236, 457);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.RefreshButton,
            this.HomeButton,
            this.GoButton,
            this.BookMarkButton,
            this.AddressBox});
            this.toolStrip2.Location = new System.Drawing.Point(0, 45);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(596, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 22);
            this.BackButton.Text = "BackButton";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(90, 22);
            this.ForwardButton.Text = "ForwardButton";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(86, 22);
            this.RefreshButton.Text = "RefreshButton";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(80, 22);
            this.HomeButton.Text = "HomeButton";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.CheckOnClick = true;
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(62, 22);
            this.GoButton.Text = "GoButton";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // BookMarkButton
            // 
            this.BookMarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BookMarkButton.Image = ((System.Drawing.Image)(resources.GetObject("BookMarkButton.Image")));
            this.BookMarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookMarkButton.Name = "BookMarkButton";
            this.BookMarkButton.Size = new System.Drawing.Size(101, 22);
            this.BookMarkButton.Text = "BookMarkButton";
            this.BookMarkButton.Click += new System.EventHandler(this.BookMarkButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 25);
            this.AddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            this.AddressBox.Click += new System.EventHandler(this.AddressBox_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabUserControl5
            // 
            this.tabUserControl5.AutoSize = true;
            this.tabUserControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserControl5.Location = new System.Drawing.Point(0, 45);
            this.tabUserControl5.Name = "tabUserControl5";
            this.tabUserControl5.Size = new System.Drawing.Size(772, 461);
            this.tabUserControl5.TabIndex = 10;
            this.tabUserControl5.Load += new System.EventHandler(this.tabUserControl5_Load);
            // 
            // tabUserControl4
            // 
            this.tabUserControl4.Location = new System.Drawing.Point(0, 73);
            this.tabUserControl4.Name = "tabUserControl4";
            this.tabUserControl4.Size = new System.Drawing.Size(772, 387);
            this.tabUserControl4.TabIndex = 9;
            // 
            // tabUserControl2
            // 
            this.tabUserControl2.Location = new System.Drawing.Point(0, 73);
            this.tabUserControl2.Name = "tabUserControl2";
            this.tabUserControl2.Size = new System.Drawing.Size(772, 387);
            this.tabUserControl2.TabIndex = 7;
            // 
            // tabUserControl1
            // 
            this.tabUserControl1.Location = new System.Drawing.Point(572, 174);
            this.tabUserControl1.Name = "tabUserControl1";
            this.tabUserControl1.Size = new System.Drawing.Size(373, 258);
            this.tabUserControl1.TabIndex = 6;
            // 
            // tabUserControl3
            // 
            this.tabUserControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserControl3.Location = new System.Drawing.Point(0, 0);
            this.tabUserControl3.Name = "tabUserControl3";
            this.tabUserControl3.Size = new System.Drawing.Size(772, 506);
            this.tabUserControl3.TabIndex = 8;
            this.tabUserControl3.Load += new System.EventHandler(this.tabUserControl3_Load);
            // 
            // WebBrowserFormM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 506);
            this.Controls.Add(this.tabUserControl5);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tabUserControl4);
            this.Controls.Add(this.tabUserControl2);
            this.Controls.Add(this.tabUserControl1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabUserControl3);
            this.Controls.Add(this.toolStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowserFormM3";
            this.Text = "Best Web Browser Ever";
            this.Load += new System.EventHandler(this.WebBrowserFormM3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WebBrowserFormM3_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripButton GoButton;
        private System.Windows.Forms.ToolStripButton BookMarkButton;
        private System.Windows.Forms.ToolStripTextBox AddressBox;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.TabPage tabPage1;
        private TabUserControl tabUserControl1;
        private TabUserControl tabUserControl2;
        private TabUserControl tabUserControl3;
        private TabUserControl tabUserControl4;
        public TabUserControl tabUserControl5;
        public System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
    }
}