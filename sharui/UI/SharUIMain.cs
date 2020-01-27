using Shar.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharui.UI
{
    public partial class SharUIMain : Form
    {
        public string currentArchive = "%%untitled%%";
        public string currentPath = "/";
        public SharArchive archiveObject = new SharArchive();

        public SharUIMain()
        {
            InitializeComponent();
        }

        public void SetWindowTitle(string fileName)
        {
            Text = Path.GetFileName(fileName) + " - Sharptron Archive (SHAR) Manager";
        }

        private void SharUIMain_Load(object sender, EventArgs e)
        {
            if (currentArchive == "%%untitled%%")
                SetWindowTitle("Untitled");
#if DEBUG //TEMP
            archiveObject.Entries.AddRange(new SharEntry[] {
                new SharEntry()
                {
                    BinData = { },
                    BinLength = 0,
                    IsDirectory = false,
                    Path = "/test.txt"
                },
                new SharEntry()
                {
                    BinData = { },
                    BinLength = 0,
                    IsDirectory = false,
                    Path = "/test/yes good.bin"
                }
            });
#endif
            Navigate(currentPath);
        }

        public void RefreshView()
        {
            Navigate(currentPath);
        }

        public void Navigate(string path)
        {
            currentPath = path;
            UpdateTreeView(path);
            UpdateIconView(path);
        }

        public void UpdateTreeView(string path)
        {
            
        }

        public void UpdateIconView(string path)
        {

        }

        private void actionBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
