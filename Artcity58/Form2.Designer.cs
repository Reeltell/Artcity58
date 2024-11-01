namespace Artcity58
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 92);
            label1.Name = "label1";
            label1.Size = new Size(84, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(230, 255);
            button1.Name = "button1";
            button1.Size = new Size(243, 38);
            button1.TabIndex = 1;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 171);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(259, 232);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 3;
            label3.Text = "Первый шаг на путь славы";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Blackadder ITC", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(177, 51);
            label4.TabIndex = 6;
            label4.Text = "ArtCity58";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Magneto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(576, 391);
            label5.Name = "label5";
            label5.Size = new Size(210, 50);
            label5.TabIndex = 7;
            label5.Text = "Горячия Линия\r\n+7 900 316-46-05\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(372, 178);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "показать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.ForeColor = Color.Aquamarine;
            button2.Location = new Point(12, 404);
            button2.Name = "button2";
            button2.Size = new Size(92, 37);
            button2.TabIndex = 9;
            button2.Text = "Вернуться";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Button button2;
    }
}