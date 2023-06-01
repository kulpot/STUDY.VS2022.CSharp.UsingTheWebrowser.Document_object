using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ref link:https://www.youtube.com/watch?v=X06jDeTEnKU&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=73
// The document object organizes the loaded webpage for us, so we can interface with it in a similar way the user does.

namespace UsingTheWebrowser.Document_object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlElement likeButton = webBrowser1.Document.GetElementById("watch-like");
            //likeButton.Focus();
            //SendKeys.SendWait("{enter}");
            //this.Text = likeButton.GetAttribute("role");
            likeButton.InnerText = "Hate";
        }
    }
}
