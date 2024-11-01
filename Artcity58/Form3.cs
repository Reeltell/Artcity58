using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artcity58
{
    public partial class Form3 : Form
    {
        static string connectionString = $"Data Source=artcity58.db;Version=3";
        public Form3()
        {
            InitializeComponent();
            InitializeDatabase();
            textBox2.KeyPress += TextBox2_KeyPress;
            textBox2.TextChanged += TextBox2_TextChanged;
            textBox2.Leave += TextBox2_Leave;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Сохранение пропорций
            // Установка режима растяжения
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Установка размера PictureBox (например, 300x200)
            pictureBox1.Size = new Size(375, 200);
            pictureBox1.Location = new Point(ClientSize.Width - pictureBox1.Width, 35);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Создаем таблицу Consultations
                string createArtTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Consultations (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        registration_id INT,
                        Name TEXT NOT NULL UNIQUE,
                        Number TEXT NOT NULL UNIQUE,
                        FOREIGN KEY (registration_id) REFERENCES Registration(Id)
                    )";
                string createArtTableQuery2 = @"
                    CREATE TABLE IF NOT EXISTS Advertising (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        registration_id INT,
                        Name TEXT NOT NULL ,
                        TG TEXT NOT NULL UNIQUE,
                        DopInf TEXT NOT NULL,
                        FOREIGN KEY (registration_id) REFERENCES Registration(Id)
                    )";

                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(createArtTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                }
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(createArtTableQuery2, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.Trim();
            string Number = textBox2.Text.Trim();
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Number))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Добавляем данные в базу данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Consultations (Name, Number) VALUES (@Name, @Number)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Number", Number);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы записаны на консультацию!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
                listBox1.Items.Add("Имя:");
                listBox1.Items.Add(textBox1.Text);
                listBox1.Items.Add("Ваш телефон:");
                listBox1.Items.Add(textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tg = textBox4.Text.Trim();
            string dopInf = textBox3.Text.Trim();
            string name = comboBox1.Text.Trim();
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(tg) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(dopInf))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Добавляем данные в базу данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Advertising (name, tg, dopInf) VALUES (@Name, @TG, @DopInf)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@TG", tg);
                command.Parameters.AddWithValue("@DopInf", dopInf);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Спасибо за двоерие нашей компании!" +
                        " С Вами обязательно свяжутся в ближайшее время.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();

                listBox1.Items.Add("Наименование:");
                // Добавляем значение из ComboBox
                if (comboBox1.SelectedItem != null)
                {
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString());
                }
                else
                {
                    listBox1.Items.Add("Выберите элемент из ComboBox");
                }

                // Добавляем значения из TextBox
                listBox1.Items.Add("Tg:");
                listBox1.Items.Add(textBox4.Text);
                listBox1.Items.Add("Дополнительная информация:");
                listBox1.Items.Add(textBox3.Text);
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;


            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, плюс и клавиши управления
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Удаляем все символы, кроме цифр
            var text = new StringBuilder();
            foreach (char c in textBox2.Text)
            {
                if (char.IsDigit(c) || c == '+')
                {
                    text.Append(c);
                }
            }

            // Форматируем номер
            string formattedNumber = FormatPhoneNumber(text.ToString());
            if (textBox2.Text != formattedNumber)
            {
                textBox2.Text = formattedNumber;
                textBox2.SelectionStart = textBox2.Text.Length; // Устанавливаем курсор в конец
            }
        }

        private string FormatPhoneNumber(string number)
        {
            // Ограничиваем длину номера до 10 цифр
            if (number.Length > 12)
                number = number.Substring(0, 10);

            // Форматируем номер
            var sb = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                if (i == 2)
                    sb.Append(" ");
                if (i == 5)
                    sb.Append(" ");
                if (i == 8)
                    sb.Append("-");
                if (i == 10)
                    sb.Append("-");
                sb.Append(number[i]);
            }
            return sb.ToString();
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            // Форматируем номер при потере фокуса
            var text = new StringBuilder();
            foreach (char c in textBox2.Text)
            {
                if (char.IsDigit(c) || c == '+')
                {
                    text.Append(c);
                }
            }
            textBox2.Text = FormatPhoneNumber(text.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}   

    



