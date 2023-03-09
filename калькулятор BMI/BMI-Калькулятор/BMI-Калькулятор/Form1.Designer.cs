namespace BMI_Калькулятор
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
            this.label2 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bmmi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BMItext = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.woman = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.strelka = new System.Windows.Forms.TableLayoutPanel();
            this.strel = new System.Windows.Forms.PictureBox();
            this.shkal = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.man.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.woman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.strelka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shkal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(159, 244);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(68, 20);
            this.height.TabIndex = 4;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(159, 282);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(68, 20);
            this.weight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "см";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "кг";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(71, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(195, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(246, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "BMI-калькулятор";
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.Color.WhiteSmoke;
            this.man.Controls.Add(this.label6);
            this.man.Controls.Add(this.pictureBox1);
            this.man.Location = new System.Drawing.Point(71, 81);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(109, 134);
            this.man.TabIndex = 12;
            this.man.Click += new System.EventHandler(this.qqq);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Мужской";
            this.label6.Click += new System.EventHandler(this.qqq);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMI_Калькулятор.Properties.Resources.male_icon;
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.qqq);
            // 
            // bmmi
            // 
            this.bmmi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bmmi.AutoSize = true;
            this.bmmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmmi.Location = new System.Drawing.Point(3, 0);
            this.bmmi.Name = "bmmi";
            this.bmmi.Size = new System.Drawing.Size(37, 19);
            this.bmmi.TabIndex = 15;
            this.bmmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BMItext);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(499, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 253);
            this.panel1.TabIndex = 16;
            // 
            // BMItext
            // 
            this.BMItext.AutoSize = true;
            this.BMItext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMItext.Location = new System.Drawing.Point(58, 223);
            this.BMItext.Name = "BMItext";
            this.BMItext.Size = new System.Drawing.Size(0, 20);
            this.BMItext.TabIndex = 12;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(22, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(146, 213);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 11;
            this.picture.TabStop = false;
            // 
            // woman
            // 
            this.woman.BackColor = System.Drawing.Color.WhiteSmoke;
            this.woman.Controls.Add(this.label7);
            this.woman.Controls.Add(this.pictureBox2);
            this.woman.Location = new System.Drawing.Point(195, 81);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(109, 134);
            this.woman.TabIndex = 14;
            this.woman.Click += new System.EventHandler(this.qq);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Женский";
            this.label7.Click += new System.EventHandler(this.qq);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMI_Калькулятор.Properties.Resources.female_icon;
            this.pictureBox2.Location = new System.Drawing.Point(31, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.qq);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(682, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 27);
            this.button4.TabIndex = 18;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // strelka
            // 
            this.strelka.ColumnCount = 1;
            this.strelka.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.strelka.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.strelka.Controls.Add(this.bmmi, 0, 0);
            this.strelka.Controls.Add(this.strel, 0, 1);
            this.strelka.Location = new System.Drawing.Point(15, 1);
            this.strelka.Name = "strelka";
            this.strelka.RowCount = 2;
            this.strelka.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.strelka.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.strelka.Size = new System.Drawing.Size(43, 39);
            this.strelka.TabIndex = 21;
            // 
            // strel
            // 
            this.strel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strel.Image = global::BMI_Калькулятор.Properties.Resources.стрелка;
            this.strel.Location = new System.Drawing.Point(3, 22);
            this.strel.Name = "strel";
            this.strel.Size = new System.Drawing.Size(37, 14);
            this.strel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.strel.TabIndex = 20;
            this.strel.TabStop = false;
            this.strel.Visible = false;
            // 
            // shkal
            // 
            this.shkal.Image = global::BMI_Калькулятор.Properties.Resources.шкала;
            this.shkal.Location = new System.Drawing.Point(492, 361);
            this.shkal.Name = "shkal";
            this.shkal.Size = new System.Drawing.Size(200, 13);
            this.shkal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shkal.TabIndex = 19;
            this.shkal.TabStop = false;
            this.shkal.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.strelka);
            this.panel2.Location = new System.Drawing.Point(492, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Недостаток веса";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Здоровый";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(584, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Избыток веса";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ожирение";
            this.label11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.shkal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.man);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI-калькулятор";
            this.man.ResumeLayout(false);
            this.man.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.woman.ResumeLayout(false);
            this.woman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.strelka.ResumeLayout(false);
            this.strelka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shkal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel man;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bmmi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BMItext;
        private System.Windows.Forms.Panel woman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox shkal;
        private System.Windows.Forms.PictureBox strel;
        private System.Windows.Forms.TableLayoutPanel strelka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

