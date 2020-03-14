namespace WindowsFormsApp3
{
    partial class Калькулятор
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.umnogenie = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.ochistka = new System.Windows.Forms.Button();
            this.vivod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 36);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 38);
            this.textBox2.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 136);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 48);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(12, 201);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(55, 48);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // umnogenie
            // 
            this.umnogenie.Location = new System.Drawing.Point(12, 268);
            this.umnogenie.Name = "umnogenie";
            this.umnogenie.Size = new System.Drawing.Size(55, 48);
            this.umnogenie.TabIndex = 4;
            this.umnogenie.Text = "*";
            this.umnogenie.UseVisualStyleBackColor = true;
            this.umnogenie.Click += new System.EventHandler(this.umnogenie_Click);
            // 
            // delenie
            // 
            this.delenie.Location = new System.Drawing.Point(12, 338);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(55, 48);
            this.delenie.TabIndex = 5;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.delenie_Click);
            // 
            // ochistka
            // 
            this.ochistka.Location = new System.Drawing.Point(12, 403);
            this.ochistka.Name = "ochistka";
            this.ochistka.Size = new System.Drawing.Size(89, 32);
            this.ochistka.TabIndex = 6;
            this.ochistka.Text = "очистка";
            this.ochistka.UseVisualStyleBackColor = true;
            this.ochistka.Click += new System.EventHandler(this.ochistka_Click);
            // 
            // vivod
            // 
            this.vivod.AutoSize = true;
            this.vivod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vivod.Location = new System.Drawing.Point(195, 413);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(40, 13);
            this.vivod.TabIndex = 7;
            this.vivod.Text = "Вывод";
            this.vivod.Click += new System.EventHandler(this.vivod_Click);
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(321, 496);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.ochistka);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnogenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Калькулятор";
            this.Text = "Калькулятор (Машкова)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umnogenie;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button ochistka;
        private System.Windows.Forms.Label vivod;
    }
}

