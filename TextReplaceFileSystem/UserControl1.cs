using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextReplaceFileSystem
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRoot.Text;
            switch (folderBrowserDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    tbxRoot.Text = folderBrowserDialog1.SelectedPath;
                    break;
            }
        }

        /// <summary>
        /// 検索ボタンをクリックしたとき。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            tbxFound.Text = "";

            //"C:\test"以下のファイルをすべて取得する
            IEnumerable<string> files =
                System.IO.Directory.EnumerateFiles(
                    tbxRoot.Text, tbxSearchPattern.Text, System.IO.SearchOption.AllDirectories);

            //ファイルを列挙する
            foreach (string f in files)
            {
                tbxFound.Text += f + "\r\n";
                Application.DoEvents();
            }

            tbxFound.Text += "[EOF]\r\n";
        }

        /// <summary>
        /// ルート・ディレクトリ。
        /// </summary>
        /// <returns></returns>
        public string RootText
        {
            get
            {
                return tbxRoot.Text;
            }
            set
            {
                tbxRoot.Text = value;
            }
        }

        /// <summary>
        /// 検索結果
        /// </summary>
        /// <returns></returns>
        public string FoundText
        {
            get
            {
                return tbxFound.Text;
            }
            set
            {
                tbxFound.Text = value;
            }
        }

        /// <summary>
        /// ファイル一致条件
        /// </summary>
        /// <returns></returns>
        public string SearchPatternText
        {
            get
            {
                return tbxSearchPattern.Text;
            }
            set
            {
                tbxSearchPattern.Text = value;
            }
        }

    }
}
