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
        // For now, this class is deprecated. However, as it has some code that's useful if we want to 
        // execute js in the main window, it's being left here for reference purposes. If this code is 
        // ever put into the main class, then this class can be deleted.

        public PreviewWindow()
        {
            InitializeComponent();
            //.Dock = DockStyle.Fill;
            //tableLayoutPanel1.Controls.Add(b, 0, 0);
        }

        private void PreviewWindow_Load(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }        
    }
}
