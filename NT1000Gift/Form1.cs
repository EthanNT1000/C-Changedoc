using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;

namespace NT1000Gift
{

    public partial class Form1 : Form
    {
        public string[] files;
        public string csv;
        public string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
       
        private void changeButton_Click(object sender, EventArgs e)
        {            
            IEnumerable lines = File.ReadLines(csv, System.Text.Encoding.GetEncoding(950));
            int L = 0;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] keys = new string[0];
            bool Status = true;
            foreach (string line in lines)
            {                    
                if(L == 0)
                {
                    keys = line.Split(',');                   
                }
              
                if (L > 0)
                {
                    string[] values = line.Split(',');
                    for(int i =0;i<keys.Length;i++)
                    {
                        dict[keys[i]] = values[i];                     
                    }
                    
                    Document doc = new Document();
                    if (comboBox1.SelectedIndex == 0)
                    {
                        try { doc.LoadFromFile(files[L - 1]); }
                        catch { }
                        {
                            labelMessage.Text = "資料夾文件數量與更改列表不符";
                            Status = false;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        try { doc.LoadFromFile(filePath); }
                        catch
                        {
                            labelMessage.Text = "未選擇更改文件";
                            Status = false;
                        }
                    }
                    if (Status)
                    {
                        try
                        {
                            foreach (string key in dict.Keys)
                            {
                                doc.Replace(key, dict[key], true, true);
                            }
                            doc.SaveToFile(folderBrowserDialog1.SelectedPath + '\\' + dict.Values.First() + ".docx", FileFormat.Docx2013);
                            status.Text = "更改成功";
                            doc.Close();
                        }
                        catch
                        {
                            status.Text = "更改失敗";
                        }
                    }                   
                }
                L += 1;
            }
            L = 0;
        }


        private void ChooseDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    System.Windows.MessageBox.Show("資料夾路徑不能為空", "提示");
                    return;
                }
            }
            files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
        }

        private void chooseCSV_Click(object sender, EventArgs e)
        {
            if (opencsvDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csv = opencsvDialog.FileName;
            }
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFile.FileName;
            }
        }
    }
}
