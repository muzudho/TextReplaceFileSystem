namespace TextReplaceFileSystem
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRoot = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxFound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKeyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSearchPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ルート・ディレクトリ";
            // 
            // tbxRoot
            // 
            this.tbxRoot.Location = new System.Drawing.Point(97, 13);
            this.tbxRoot.Name = "tbxRoot";
            this.tbxRoot.Size = new System.Drawing.Size(321, 19);
            this.tbxRoot.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(424, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "開く";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(5, 145);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "検索";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxFound
            // 
            this.tbxFound.Location = new System.Drawing.Point(5, 174);
            this.tbxFound.Multiline = true;
            this.tbxFound.Name = "tbxFound";
            this.tbxFound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxFound.Size = new System.Drawing.Size(494, 195);
            this.tbxFound.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "検索文字列";
            // 
            // tbxKeyword
            // 
            this.tbxKeyword.Location = new System.Drawing.Point(97, 44);
            this.tbxKeyword.Multiline = true;
            this.tbxKeyword.Name = "tbxKeyword";
            this.tbxKeyword.Size = new System.Drawing.Size(321, 61);
            this.tbxKeyword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "サーチパターン";
            // 
            // tbxSearchPattern
            // 
            this.tbxSearchPattern.Location = new System.Drawing.Point(97, 118);
            this.tbxSearchPattern.Name = "tbxSearchPattern";
            this.tbxSearchPattern.Size = new System.Drawing.Size(321, 19);
            this.tbxSearchPattern.TabIndex = 8;
            this.tbxSearchPattern.Text = "*.html";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxSearchPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFound);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbxRoot);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(546, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRoot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKeyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSearchPattern;
    }
}
