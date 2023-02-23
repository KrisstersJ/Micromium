using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micromium
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chromiumWebBrowser = null;
        List<ChromiumWebBrowser> chromiumWebBrowserList = new List<ChromiumWebBrowser>();

        public Form1()
        {
            InitializeComponent();
            IntializeBrowser();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        public void IntializeBrowser()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);

            chromiumWebBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[0].Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;

            chromiumWebBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[1].Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;

        }

        private void Go_Click(object sender, EventArgs e)
        {
            //browser.Load(MyAdress.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addBrowserTab()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Broswer Page";

            chromiumWebBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Broswer Page";

            chromiumWebBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(BrowserTabs.TabCount > 1)
                {
                    BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                }
                else
                {
                    BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                    addBrowserTab();                   
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
