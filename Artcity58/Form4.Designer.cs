namespace Artcity58
{
    partial class Form4
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(160, 47);
            button1.TabIndex = 0;
            button1.Text = "Просмотреть запись\n на консультацию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(632, 12);
            button2.Name = "button2";
            button2.Size = new Size(156, 47);
            button2.TabIndex = 1;
            button2.Text = "Просмотр клиентов\r\n на рекламу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(694, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.DarkRed;
            button4.Location = new Point(12, 409);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 324);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(412, 65);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(376, 324);
            listBox2.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources._193_1936401_website_icon_clipart_website_home_logo;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(343, 395);
            button5.Name = "button5";
            button5.Size = new Size(70, 43);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form4";
            Text = "Admin_Form";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
    }
}