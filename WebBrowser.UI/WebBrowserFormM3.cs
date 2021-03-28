﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class WebBrowserFormM3 : Form
    {
        public WebBrowserFormM3()
        {
            InitializeComponent();
        }

        private void WebBrowserFormM3_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
  
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Removes the selected tab:  
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add code here
            MessageBox.Show("Peace out!");
            Application.Exit();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add message here
            MessageBox.Show("Hello there! This is my custom web browser. My name is Casandra. I am from Chicago and I have two cats. My student ID is czt0051. Thanks for checking me out!");
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // add code here
            String url = AddressBox.Text;
            if(Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
            }
        }

        private void BookMarkButton_Click(object sender, EventArgs e)
        {

        }
        
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        
        private void AddressBox_Click(object sender, EventArgs e)
        {
            //address box
            String url = AddressBox.Text;
            if(Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AddressBox.Text = url;
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
            }
            
        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String url = AddressBox.Text;
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    AddressBox.Text = url;
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                }

            }
        }

        private void tabUserControl3_Load(object sender, EventArgs e)
        {
            TabUserControl AddressBox = new TabUserControl();
            tabPage1.Text = AddressBox.Text;
            // need to figure out how to get the tab page to take on the name of the url we are on

        }

        private void tabUserControl5_Load(object sender, EventArgs e)
        {
            String url = AddressBox.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                AddressBox.Text = url;
                tabPage1.Text = url;
                webBrowser1.Navigate(url);
            }
            // need to figure out how to get the tab page to take on the name of the url we are on

        }

        private void WebBrowserFormM3_KeyDown(object sender, KeyEventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
        }
    }
}
