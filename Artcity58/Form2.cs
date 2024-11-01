using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artcity58
{
    public partial class Form2 : Form
    {
        static string connectionString = $"Data Source=artcity58.db;Version=3";
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text.Trim();
            string Password = textBox2.Text.Trim();
            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(Login) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Добавляем данные в базу данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Registration (Login, Password) VALUES (@Login, @Password)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы зарегистрировааны!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            Form1 Authorization = new Form1();
            Authorization.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Устанавливаем символ пустым 
            }
            else
            {
                textBox2.PasswordChar = '*'; // Возвращаем символ '*' 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Authorization = new Form1();
            Authorization.Show();
            this.Hide();
        }
    }

}
