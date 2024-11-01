namespace Artcity58
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Tempus Sans ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(459, 332);
            button1.Name = "button1";
            button1.Size = new Size(217, 45);
            button1.TabIndex = 2;
            button1.Text = "Регистрация";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(518, 281);
            button2.Name = "button2";
            button2.Size = new Size(114, 45);
            button2.TabIndex = 3;
            button2.Text = "Вход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("SimSun-ExtB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 198);
            label1.Name = "label1";
            label1.Size = new Size(124, 40);
            label1.TabIndex = 4;
            label1.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("SimSun-ExtB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 87);
            label2.Name = "label2";
            label2.Size = new Size(102, 40);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(459, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(459, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 34);
            textBox2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Sitka Display", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ImageAlign = ContentAlignment.TopCenter;
            checkBox1.ImageKey = "(нет)";
            checkBox1.Location = new Point(589, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 23);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "показать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Vladimir Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 34);
            label3.TabIndex = 9;
            label3.Text = "ArtCity58";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Algerian", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(259, 44);
            label4.TabIndex = 10;
            label4.Text = "Все,\r\nчто вам нужно знать о рекламе.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(908, 465);
            label5.Name = "label5";
            label5.Size = new Size(210, 50);
            label5.TabIndex = 11;
            label5.Text = "Горячия Линия\r\n+7 900 316-46-05\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(39F, 74F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1132, 524);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(15, 11, 15, 11);
            Name = "Form1";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
