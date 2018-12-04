namespace Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fldExcelPath = new System.Windows.Forms.TextBox();
            this.butSelectFileExcel = new System.Windows.Forms.Button();
            this.fldContent = new System.Windows.Forms.TextBox();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.fldWordPath = new System.Windows.Forms.TextBox();
            this.butSelectFileWord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fldExcelPath
            // 
            this.fldExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldExcelPath.Location = new System.Drawing.Point(166, 22);
            this.fldExcelPath.Name = "fldExcelPath";
            this.fldExcelPath.ReadOnly = true;
            this.fldExcelPath.Size = new System.Drawing.Size(324, 20);
            this.fldExcelPath.TabIndex = 1;
            // 
            // butSelectFileExcel
            // 
            this.butSelectFileExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFileExcel.Location = new System.Drawing.Point(521, 20);
            this.butSelectFileExcel.Name = "butSelectFileExcel";
            this.butSelectFileExcel.Size = new System.Drawing.Size(160, 23);
            this.butSelectFileExcel.TabIndex = 2;
            this.butSelectFileExcel.Text = "Выбрать файл Excel";
            this.butSelectFileExcel.UseVisualStyleBackColor = true;
            // 
            // fldContent
            // 
            this.fldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldContent.Location = new System.Drawing.Point(12, 163);
            this.fldContent.Multiline = true;
            this.fldContent.Name = "fldContent";
            this.fldContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fldContent.Size = new System.Drawing.Size(696, 280);
            this.fldContent.TabIndex = 6;
            // 
            // butSaveFile
            // 
            this.butSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveFile.Location = new System.Drawing.Point(608, 449);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(91, 36);
            this.butSaveFile.TabIndex = 7;
            this.butSaveFile.Text = "Сохранить лог";
            this.butSaveFile.UseVisualStyleBackColor = true;
            // 
            // fldWordPath
            // 
            this.fldWordPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldWordPath.Location = new System.Drawing.Point(166, 102);
            this.fldWordPath.Name = "fldWordPath";
            this.fldWordPath.ReadOnly = true;
            this.fldWordPath.Size = new System.Drawing.Size(324, 20);
            this.fldWordPath.TabIndex = 10;
            // 
            // butSelectFileWord
            // 
            this.butSelectFileWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFileWord.Location = new System.Drawing.Point(521, 101);
            this.butSelectFileWord.Name = "butSelectFileWord";
            this.butSelectFileWord.Size = new System.Drawing.Size(160, 23);
            this.butSelectFileWord.TabIndex = 12;
            this.butSelectFileWord.Text = "Выбрать путь для Word";
            this.butSelectFileWord.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Путь файла Word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь файла Excel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 497);
            this.Controls.Add(this.butSelectFileWord);
            this.Controls.Add(this.fldWordPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.fldContent);
            this.Controls.Add(this.butSelectFileExcel);
            this.Controls.Add(this.fldExcelPath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Конвертор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fldExcelPath;
        private System.Windows.Forms.Button butSelectFileExcel;
        private System.Windows.Forms.TextBox fldContent;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.TextBox fldWordPath;
        private System.Windows.Forms.Button butSelectFileWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

