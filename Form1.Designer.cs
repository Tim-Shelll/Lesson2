namespace Project
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
            this.label4 = new System.Windows.Forms.Label();
            this.koment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.put = new System.Windows.Forms.TextBox();
            this.fail = new System.Windows.Forms.TextBox();
            this.zapis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Комментарий";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // koment
            // 
            this.koment.Location = new System.Drawing.Point(472, 79);
            this.koment.Name = "koment";
            this.koment.Size = new System.Drawing.Size(316, 22);
            this.koment.TabIndex = 14;
            this.koment.TextChanged += new System.EventHandler(this.koment_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Файл";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Путь к файлу";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // put
            // 
            this.put.Location = new System.Drawing.Point(12, 78);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(316, 22);
            this.put.TabIndex = 11;
            this.put.TextChanged += new System.EventHandler(this.put_TextChanged);
            // 
            // fail
            // 
            this.fail.Location = new System.Drawing.Point(73, 177);
            this.fail.Multiline = true;
            this.fail.Name = "fail";
            this.fail.ReadOnly = true;
            this.fail.Size = new System.Drawing.Size(650, 250);
            this.fail.TabIndex = 10;
            this.fail.TextChanged += new System.EventHandler(this.fail_TextChanged);
            // 
            // zapis
            // 
            this.zapis.Location = new System.Drawing.Point(177, 106);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(140, 33);
            this.zapis.TabIndex = 9;
            this.zapis.Text = "записать";
            this.zapis.UseVisualStyleBackColor = true;
            this.zapis.Click += new System.EventHandler(this.zapis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.koment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.put);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.zapis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox koment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox put;
        private System.Windows.Forms.TextBox fail;
        private System.Windows.Forms.Button zapis;
        private System.Windows.Forms.Button button1;
    }
}

