﻿
namespace guiTask_11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbArr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labSortArr = new System.Windows.Forms.Label();
            this.tbSkal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер массива";
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(400, 81);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 45);
            this.tbN.TabIndex = 1;
            // 
            // tbArr
            // 
            this.tbArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArr.Location = new System.Drawing.Point(173, 184);
            this.tbArr.Name = "tbArr";
            this.tbArr.Size = new System.Drawing.Size(572, 45);
            this.tbArr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вводите числа через пробел";
            // 
            // labSortArr
            // 
            this.labSortArr.AutoSize = true;
            this.labSortArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSortArr.Location = new System.Drawing.Point(166, 250);
            this.labSortArr.Name = "labSortArr";
            this.labSortArr.Size = new System.Drawing.Size(394, 39);
            this.labSortArr.TabIndex = 4;
            this.labSortArr.Text = "Сортированный массив";
            // 
            // tbSkal
            // 
            this.tbSkal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSkal.Location = new System.Drawing.Point(400, 367);
            this.tbSkal.Name = "tbSkal";
            this.tbSkal.Size = new System.Drawing.Size(100, 45);
            this.tbSkal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(310, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите скаляр";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRes.Location = new System.Drawing.Point(166, 419);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(135, 39);
            this.labRes.TabIndex = 7;
            this.labRes.Text = "Массив";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(527, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 87);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSkal);
            this.Controls.Add(this.labSortArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbArr);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbArr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSortArr;
        private System.Windows.Forms.TextBox tbSkal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Button button1;
    }
}

