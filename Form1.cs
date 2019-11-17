using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button2.Enabled = true;
                path = folderBrowserDialog1.SelectedPath;
                fileSystemWatcher1.Path = path;
                fileSystemWatcher1.EnableRaisingEvents = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            fileSystemWatcher1.EnableRaisingEvents = false;
        }

        private void OnChanged(object sender, System.IO.FileSystemEventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(e.ChangeType + " " + e.FullPath);
                int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
                listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            }
        }

        private void OnRenamed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(e.ChangeType + " " + e.FullPath);
                int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
                listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            }
        }

        private void OnCreated(object sender, System.IO.FileSystemEventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(e.ChangeType + " " + e.FullPath);
                int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
                listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            }
        }

        private void OnDeleted(object sender, System.IO.FileSystemEventArgs e)
        {
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(e.ChangeType + " " + e.FullPath);
                int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
                listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value = (Convert.ToInt32(performanceCounter1.NextValue())/1024)*100;
        }
    }
}
