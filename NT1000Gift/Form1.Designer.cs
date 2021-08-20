
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
            this.chooseCSV = new System.Windows.Forms.Button();
            this.opencsvDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.labelMessage = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeButton.Location = new System.Drawing.Point(182, 189);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(94, 61);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "更改";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "請選擇所在資料夾";
            // 
            // ChooseDir
            // 
            this.ChooseDir.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChooseDir.Location = new System.Drawing.Point(12, 86);
            this.ChooseDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChooseDir.Name = "ChooseDir";
            this.ChooseDir.Size = new System.Drawing.Size(133, 51);
            this.ChooseDir.TabIndex = 3;
            this.ChooseDir.Text = "選擇資料夾";
            this.ChooseDir.UseVisualStyleBackColor = true;
            this.ChooseDir.Click += new System.EventHandler(this.ChooseDir_Click);
            // 
            // chooseCSV
            // 
            this.chooseCSV.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chooseCSV.Location = new System.Drawing.Point(12, 190);
            this.chooseCSV.Name = "chooseCSV";
            this.chooseCSV.Size = new System.Drawing.Size(144, 61);
            this.chooseCSV.TabIndex = 4;
            this.chooseCSV.Text = "選擇更改列表(.csv)";
            this.chooseCSV.UseVisualStyleBackColor = true;
            this.chooseCSV.Click += new System.EventHandler(this.chooseCSV_Click);
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
            this.label1.Location = new System.Drawing.Point(28, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(147, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // selectFile
            // 
            this.selectFile.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectFile.Location = new System.Drawing.Point(160, 86);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(131, 49);
            this.selectFile.TabIndex = 7;
            this.selectFile.Text = "選擇檔案";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMessage.Location = new System.Drawing.Point(330, 100);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 20);
            this.labelMessage.TabIndex = 8;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.status.Location = new System.Drawing.Point(314, 209);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 20);
            this.status.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 292);
            this.Controls.Add(this.status);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseCSV);
            this.Controls.Add(this.ChooseDir);
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
        private System.Windows.Forms.Button chooseCSV;
        private System.Windows.Forms.OpenFileDialog opencsvDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label status;
    }
}

