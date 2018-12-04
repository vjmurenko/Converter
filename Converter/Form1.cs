using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public interface IMainForm
    {
        string FilePathE { get; }
        string FilePathW { get; }
        string Content { get; set; }
        string FilePathL { get; set; }

        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler WriteLog;

    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            butSelectFileExcel.Click += ButSelectFile_Click;
            butSelectFileWord.Click += ButSelectFileWord_Click;
            butSaveFile.Click += ButSaveFile_Click;
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Текстовые файлы |*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FilePathL = dlg.FileName;

                WriteLog?.Invoke(this, EventArgs.Empty);
            }

        }

        private void ButSelectFileWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "docx |*.docx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldWordPath.Text = dlg.FileName;
                FileSaveClick?.Invoke(this, EventArgs.Empty);

            }

        }

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "xlsx |*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldExcelPath.Text = dlg.FileName;
                FileOpenClick?.Invoke(this, EventArgs.Empty);

            }
        }



        #region IMainForm
        public string FilePathE { get => fldExcelPath.Text; }
        public string FilePathW { get => fldWordPath.Text; }
        public string Content
        {
            get => fldContent.Text;
            set => fldContent.Text = value;
        }

        public string FilePathL { get; set; }


        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler WriteLog;


        #endregion
    }
}
