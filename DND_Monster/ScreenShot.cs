using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using CefSharp;
using CefSharp.OffScreen;

public static class BrowserInfo
{    
    // Gets the height of the HTML document.
    public static int BrowserHeight(ChromiumWebBrowser b)
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

        if (task.Result.Result == null) { return 0; }
        return Convert.ToInt32(task.Result.Result.ToString());
    }

    // Gets the width of the HTML document.
    public static int BrowserWidth(ChromiumWebBrowser b)
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

        if (task.Result.Result == null) { return 0; }
        return Convert.ToInt32(task.Result.Result.ToString());
    }   
}