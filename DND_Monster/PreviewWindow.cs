using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cef;
using CefSharp;
using CefSharp.WinForms;

namespace DND_Monster
{
    public partial class PreviewWindow : Form
    {
        ChromiumWebBrowser b = new ChromiumWebBrowser("http://rendering/");
        int offset = 50;

        public PreviewWindow()
        {
            InitializeComponent();
            b.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(b, 0, 0);
        }

        private void PreviewWindow_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            b.LoadHtml("<html><head></head><body></body></html", "http://rendering/");
        }

        public void ShowMonster()
        {
            this.Text = Monster.CreatureName;

            Clear();

            b.LoadHtml(Monster.Create(), "http://rendering/");            
            b.FrameLoadEnd += (ssender, se) =>
            {
                this.Invoke((Action)delegate
                {                    
                    this.Size = new Size(BrowserWidth(b) + offset, BrowserHeight(b) + offset + (int)tableLayoutPanel1.GetRowHeights()[1]);                    
                });
            };            
        }


        private static int BrowserHeight(ChromiumWebBrowser b)
        {
            // Get Document Height
            var task = b.EvaluateScriptAsync("(function() { var body = document.body, html = document.documentElement; return  Math.max( body.scrollHeight, body.offsetHeight, html.clientHeight, html.scrollHeight, html.offsetHeight ); })();");

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    var EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
                    //MessageBox.Show(response.Result.ToString());                    
                    //MessageBox.Show(EvaluateJavaScriptResult.ToString());                    
                }
            });

            return Convert.ToInt32(task.Result.Result.ToString());
        }

        private static int BrowserWidth(ChromiumWebBrowser b)
        {
            // Get Document Height
            var task = b.EvaluateScriptAsync("(function() { var body = document.body, html = document.documentElement; return  Math.max( body.scrollWidth, body.offsetWidth, html.clientWidth, html.scrollWidth, html.offsetWidth ); })();");

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    var EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
                    //MessageBox.Show(response.Result.ToString());                    
                    //MessageBox.Show(EvaluateJavaScriptResult.ToString());
                }
            });
            
            return Convert.ToInt32(task.Result.Result.ToString());
        }

        private void PreviewWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }        
    }
}
