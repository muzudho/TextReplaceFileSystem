using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextReplaceFileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./root-directory.txt", userControl11.RootText);
            File.WriteAllText("./found-text.txt", userControl11.FoundText);
            File.WriteAllText("./search-pattern-text.txt", userControl11.SearchPatternText);
        }

        /// <summary>
        /// 読み込み。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string path = "./root-directory.txt";
                if (File.Exists(path))
                {
                    userControl11.RootText = File.ReadAllText(path);
                }
            }
            {
                string path = "./found-text.txt";
                if (File.Exists(path))
                {
                    userControl11.FoundText = File.ReadAllText(path);
                }
            }
            {
                string path = "./search-pattern-text.txt";
                if (File.Exists(path))
                {
                    userControl11.SearchPatternText = File.ReadAllText(path);
                }
            }

        }
    }
}
