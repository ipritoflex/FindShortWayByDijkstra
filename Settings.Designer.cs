﻿namespace SearchWay
{
    partial class Settings
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFile_button1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загрузить из файла";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFile_button1
            // 
            this.SelectFile_button1.AutoSize = true;
            this.SelectFile_button1.Location = new System.Drawing.Point(15, 39);
            this.SelectFile_button1.Name = "SelectFile_button1";
            this.SelectFile_button1.Size = new System.Drawing.Size(173, 27);
            this.SelectFile_button1.TabIndex = 1;
            this.SelectFile_button1.Text = "Загрузить карту метро";
            this.SelectFile_button1.UseVisualStyleBackColor = true;
            this.SelectFile_button1.Click += new System.EventHandler(this.SelectFile_button1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(15, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить граф в файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectFile_button1);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFile_button1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}