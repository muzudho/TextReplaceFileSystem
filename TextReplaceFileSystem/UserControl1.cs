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

        private void findKeywords(string path, out List<int> indexes)
        {
            indexes = new List<int>();

            string contents = File.ReadAllText(path);
            int caret = 0;

            for (; ;)
            {
                int index = contents.IndexOf(tbxKeyword.Text, caret);
                if (index == -1)
                {
                    break;
                }
                caret = index + tbxKeyword.Text.Length;
                indexes.Add(index);
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

            // ルート以下のファイルをすべて取得する
            IEnumerable<string> files =
                System.IO.Directory.EnumerateFiles(
                    tbxRoot.Text, tbxSearchPattern.Text, System.IO.SearchOption.AllDirectories);

            // ファイルを列挙する
            foreach (string f in files)
            {
                // 内容を検索する
                findKeywords(f, out List<int> indexes);
                if(0< indexes.Count)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("[");
                    int i = 0;
                    foreach(int index in indexes)
                    {
                        if (0 < i)
                        {
                            sb.Append(", ");
                        }
                        sb.Append(index);
                        i++;
                    }
                    sb.Append("]");

                    tbxFound.Text += string.Format("{{ \"file\":\"{0}\",\"indexes\":{1} }}\r\n", f, sb.ToString());
                    Application.DoEvents();
                }
            }

            tbxFound.Text += "[EOF]\r\n";
        }

        private void btnFileNameList_Click(object sender, EventArgs e)
        {
            tbxFound.Text = "";

            // ルート以下のファイルをすべて取得する
            IEnumerable<string> files =
                System.IO.Directory.EnumerateFiles(
                    tbxRoot.Text, tbxSearchPattern.Text, System.IO.SearchOption.AllDirectories);

            // ファイルを列挙する
            foreach (string f in files)
            {
                // 内容を検索する
                findKeywords(f, out List<int> indexes);
                if (0 < indexes.Count)
                {
                    tbxFound.Text += f + "\r\n";
                    Application.DoEvents();
                }
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
        /// 検索キーワード
        /// </summary>
        /// <returns></returns>
        public string KeywordText
        {
            get
            {
                return tbxKeyword.Text;
            }
            set
            {
                tbxKeyword.Text = value;
            }
        }

        /// <summary>
        /// 置換後文字列
        /// </summary>
        /// <returns></returns>
        public string ReplacesText
        {
            get
            {
                return tbxReplaces.Text;
            }
            set
            {
                tbxReplaces.Text = value;
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

        private void btnClears_Click(object sender, EventArgs e)
        {
            tbxFound.Text = "";
        }
    }
}
