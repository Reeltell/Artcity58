namespace Artcity58
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 290);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(401, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(430, 404);
            button1.Name = "button1";
            button1.Size = new Size(362, 34);
            button1.TabIndex = 1;
            button1.Text = "Записаться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(54, 237);
            button2.Name = "button2";
            button2.Size = new Size(358, 34);
            button2.TabIndex = 2;
            button2.Text = "Отправить данные";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(96, 22);
            label1.Name = "label1";
            label1.Size = new Size(212, 31);
            label1.TabIndex = 3;
            label1.Text = "Запись на рекламу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(430, 237);
            label2.Name = "label2";
            label2.Size = new Size(274, 31);
            label2.TabIndex = 4;
            label2.Text = "Запись на консультацию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GrayText;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(430, 268);
            label3.Name = "label3";
            label3.Size = new Size(362, 50);
            label3.TabIndex = 5;
            label3.Text = "Оставьте ваш контакт \r\nи мы начнем работу над вашим проектом";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(462, 325);
            label4.Name = "label4";
            label4.Size = new Size(49, 29);
            label4.TabIndex = 6;
            label4.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(632, 325);
            label5.Name = "label5";
            label5.Size = new Size(106, 29);
            label5.TabIndex = 7;
            label5.Text = "Ваш номер";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(576, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "+7 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Vladimir Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(710, 12);
            label6.Name = "label6";
            label6.Size = new Size(78, 22);
            label6.TabIndex = 10;
            label6.Text = "ArtCity58";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(54, 110);
            label7.Name = "label7";
            label7.Size = new Size(254, 23);
            label7.TabIndex = 11;
            label7.Text = "Ссылка на профиль в Telegram";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(54, 53);
            label8.Name = "label8";
            label8.Size = new Size(203, 23);
            label8.TabIndex = 12;
            label8.Text = "Наименование рекламы";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(54, 166);
            label9.Name = "label9";
            label9.Size = new Size(373, 23);
            label9.TabIndex = 13;
            label9.Text = "Дополнительные данные для Вашей рекламы";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Баннер на раме", "Типография", "Интерьерная реклама", "Брендирование транспорта", "Вывески", "Крышные конструкции" });
            comboBox1.Location = new Point(54, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 28);
            comboBox1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(54, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 27);
            textBox4.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 184);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._193_1936401_website_icon_clipart_website_home_logo;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(56, 41);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "ArtCity58";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button3;
    }
}