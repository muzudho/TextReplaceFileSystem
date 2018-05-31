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
        const string ROOT_FILE = "./root-directory.txt";
        const string KEYWORD_FILE = "./keyword-text.txt";
        const string REPLACES_FILE = "./replaces-text.txt";
        const string SEARCH_PATTERN_FILE = "./search-pattern-text.txt";
        const string FOUND_FILE = "./found-text.txt";

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
            File.WriteAllText(ROOT_FILE, userControl11.RootText);
            File.WriteAllText(KEYWORD_FILE, userControl11.KeywordText);
            File.WriteAllText(REPLACES_FILE, userControl11.ReplacesText);
            File.WriteAllText(SEARCH_PATTERN_FILE, userControl11.SearchPatternText);
            File.WriteAllText(FOUND_FILE, userControl11.FoundText);
        }

        /// <summary>
        /// 読み込み。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            {
                string path = ROOT_FILE;
                if (File.Exists(path))
                {
                    userControl11.RootText = File.ReadAllText(path);
                }
            }
            {
                string path = KEYWORD_FILE;
                if (File.Exists(path))
                {
                    userControl11.KeywordText = File.ReadAllText(path);
                }
            }
            {
                string path = REPLACES_FILE;
                if (File.Exists(path))
                {
                    userControl11.ReplacesText = File.ReadAllText(path);
                }
            }
            {
                string path = SEARCH_PATTERN_FILE;
                if (File.Exists(path))
                {
                    userControl11.SearchPatternText = File.ReadAllText(path);
                }
            }
            {
                string path = FOUND_FILE;
                if (File.Exists(path))
                {
                    userControl11.FoundText = File.ReadAllText(path);
                }
            }
        }
    }
}
