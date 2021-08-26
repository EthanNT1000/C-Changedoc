using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;
using System.Printing;
using System.Diagnostics;
using System.Threading;
using Spire.Pdf;

namespace NT1000Gift
{

    public partial class Form1 : Form
    {
        public string[] files;
        public string csv;
        public string filePath;
        public string[] BusFiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
       
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (opencsvDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csv = opencsvDialog.FileName;
                try
                {
                    IEnumerable lines = File.ReadLines(csv, System.Text.Encoding.GetEncoding(950));
                    int L = 0;
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    string[] keys = new string[0];
                    bool Status = true;
                    foreach (string line in lines)
                    {
                        if (L == 0)
                        {
                            keys = line.Split(',');
                        }

                        if (L > 0)
                        {
                            string[] values = line.Split(',');
                            for (int i = 0; i < keys.Length; i++)
                            {
                                dict[keys[i]] = values[i];
                            }

                            Document doc = new Document();
                            if (comboBox1.SelectedIndex == 0)
                            {
                                try { doc.LoadFromFile(files[L - 1]); }
                                catch
                                {
                                    System.Windows.MessageBox.Show("資料夾文件數量與更改列表不符:" + files.Length.ToString());
                                    Status = false;
                                }
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                try { doc.LoadFromFile(filePath); }
                                catch
                                {
                                    System.Windows.MessageBox.Show("未選擇更改文件");
                                    Status = false;
                                }
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("未選擇模式");
                                Status = false;
                                break;
                            }
                            if (Status)
                            {
                                try
                                {
                                    foreach (string key in dict.Keys)
                                    {
                                        doc.Replace(key, dict[key], true, true);
                                    }
                                    doc.SaveToFile(folderBrowserDialog1.SelectedPath + '\\' + L.ToString() + "_" + dict.Values.First() + ".docx", Spire.Doc.FileFormat.Docx2013);
                                    doc.Close();
                                }
                                catch
                                {
                                    System.Windows.MessageBox.Show("更改失敗");
                                }
                            }
                        }
                        L += 1;
                    }
                    L = 0;
                    if (Status) System.Windows.MessageBox.Show("更改成功");
                }
                catch { System.Windows.MessageBox.Show("未選擇CSV檔"); }
            }          
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
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            }           
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFile.FileName;
            }
        }

        private void copyFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog2.SelectedPath))
                {
                    System.Windows.MessageBox.Show("資料夾路徑不能為空", "提示");
                    return;
                }
                try
                {
                    BusFiles = Directory.GetFiles(folderBrowserDialog2.SelectedPath);
                    foreach (string f in BusFiles)
                    {
                        string newf = f.Replace(folderBrowserDialog2.SelectedPath, "");
                        File.Copy(f, folderBrowserDialog1.SelectedPath + '\\' + newf, true);
                    }
                    System.Windows.MessageBox.Show("複製成功");
                }
                catch
                {
                    System.Windows.MessageBox.Show("未選擇輸出資料夾");
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
            foreach (string dir in dirs)
            {
                string[] files = Directory.GetFiles(dir);
                foreach (string file in files)               
                {
                    if (file.Contains(".pdf"))
                    {
                        PdfDocument pdf = new PdfDocument();
                        pdf.LoadFromFile(file);
                        pdf.PrintSettings.Color = false;
                        pdf.PrintSettings.DocumentName = file.Replace(dir+'\\',"");
                        pdf.Print();
                        pdf.Close();
                    }

                    else
                    {
                        Document doc = new Document();
                        doc.LoadFromFile(file);
                        printDoc = doc.PrintDocument;
                        printDoc.DocumentName = file.Replace(dir+'\\', ""); ;
                        printDoc.Print();
                        doc.Close();
                    }
                }
            }

        }

        private void lazybut_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    System.Windows.MessageBox.Show("資料夾路徑不能為空", "提示");
                    return;
                }
            }

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFile.FileName;
            }

            if (opencsvDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                csv = opencsvDialog.FileName;
            }

            if (folderBrowserDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog2.SelectedPath))
                {
                    System.Windows.MessageBox.Show("資料夾路徑不能為空", "提示");
                    return;
                }
                BusFiles = Directory.GetFiles(folderBrowserDialog2.SelectedPath);
            }

            IEnumerable lines = File.ReadLines(csv, System.Text.Encoding.GetEncoding(950));
            int L = 0;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] keys = new string[0];
            bool Status = true;
            foreach (string line in lines)
            {
                if (L == 0)
                {
                    keys = line.Split(',');
                }

                if (L > 0)
                {
                    string[] values = line.Split(',');
                    for (int i = 0; i < keys.Length; i++)
                    {
                        dict[keys[i]] = values[i];
                    }

                    Document doc = new Document();
                    try { doc.LoadFromFile(filePath); }
                    catch
                    {
                        System.Windows.MessageBox.Show("未選擇更改文件");
                        Status = false;
                    }

                    if (Status)
                    {
                        try
                        {
                            foreach (string key in dict.Keys)
                            {
                                doc.Replace(key, dict[key], true, true);
                            }
                            string dir = folderBrowserDialog1.SelectedPath + '\\' + dict.Values.First();
                            Directory.CreateDirectory(dir);
                            doc.SaveToFile(dir + '\\' + "01-05_" + dict.Values.First() + ".docx", Spire.Doc.FileFormat.Docx2013);                           
                            doc.Close();

                            foreach (string f in BusFiles)
                            {
                                string newf = f.Replace(folderBrowserDialog2.SelectedPath, "");
                                File.Copy(f, dir + '\\' + newf, true);
                            }

                        }
                        catch
                        {
                            System.Windows.MessageBox.Show("複製失敗");
                        }
                    }
                }
                L += 1;
            }
            if (Status) System.Windows.MessageBox.Show("更改成功");
        }
    }
}
