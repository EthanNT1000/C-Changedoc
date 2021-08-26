
namespace NT1000Gift
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.changeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseDir = new System.Windows.Forms.Button();
            this.opencsvDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.print = new System.Windows.Forms.Button();
            this.copyFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.lazybut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeButton.Location = new System.Drawing.Point(234, 171);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(106, 49);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "更改";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "請選擇輸出資料夾";
            // 
            // ChooseDir
            // 
            this.ChooseDir.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChooseDir.Location = new System.Drawing.Point(69, 87);
            this.ChooseDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseDir.Name = "ChooseDir";
            this.ChooseDir.Size = new System.Drawing.Size(133, 51);
            this.ChooseDir.TabIndex = 3;
            this.ChooseDir.Text = "選擇資料夾";
            this.ChooseDir.UseVisualStyleBackColor = true;
            this.ChooseDir.Click += new System.EventHandler(this.ChooseDir_Click);
            // 
            // opencsvDialog
            // 
            this.opencsvDialog.Filter = "(.csv)|*.csv*";
            this.opencsvDialog.Title = "請選擇更改列表";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "選擇模式:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "依序更改資料夾內容",
            "單一檔案依序更改"});
            this.comboBox1.Location = new System.Drawing.Point(133, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // selectFile
            // 
            this.selectFile.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectFile.Location = new System.Drawing.Point(69, 171);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(131, 49);
            this.selectFile.TabIndex = 7;
            this.selectFile.Text = "選擇更改檔案";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Title = "請選擇更改檔案";
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.print.Location = new System.Drawing.Point(387, 124);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(98, 64);
            this.print.TabIndex = 1;
            this.print.Text = "列印";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // copyFile
            // 
            this.copyFile.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.copyFile.Location = new System.Drawing.Point(234, 87);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(106, 51);
            this.copyFile.TabIndex = 0;
            this.copyFile.Text = "複製資料";
            this.copyFile.UseVisualStyleBackColor = true;
            this.copyFile.Click += new System.EventHandler(this.copyFile_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.Description = "選擇檔案複製資料夾";
            // 
            // lazybut
            // 
            this.lazybut.Font = new System.Drawing.Font("標楷體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lazybut.Location = new System.Drawing.Point(443, 32);
            this.lazybut.Name = "lazybut";
            this.lazybut.Size = new System.Drawing.Size(143, 62);
            this.lazybut.TabIndex = 8;
            this.lazybut.Text = "製作交車資料";
            this.lazybut.UseVisualStyleBackColor = true;
            this.lazybut.Click += new System.EventHandler(this.lazybut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 278);
            this.Controls.Add(this.lazybut);
            this.Controls.Add(this.print);
            this.Controls.Add(this.copyFile);
            this.Controls.Add(this.ChooseDir);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "NT1000Gift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ChooseDir;
        private System.Windows.Forms.OpenFileDialog opencsvDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button copyFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button lazybut;
    }
}

