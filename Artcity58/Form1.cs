using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Artcity58
{
    public partial class Form1 : Form
    {
        static string connectionString = $"Data Source=artcity58.db;Version=3";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            textBox2.PasswordChar = '*';
            this.KeyPreview = true; // Позволяет форме обрабатывать нажатия клавиш
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Перемещаем фокус на label2
                textBox2.Focus();
                e.SuppressKeyPress = true; // Останавливаем дальнейшую обработку события
            }
        }

        // Метод инициализации базы данных
        private void InitializeDatabase()
        {
            // Проверка, существует ли база данных
            if (!File.Exists("artcity58.db"))
            {
                // Создаем базу данных
                SQLiteConnection.CreateFile("artcity58.db");
            }

            // Создаем таблицу в базе данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Создаем таблицу Registration
                string createArtTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Registration (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Login TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL UNIQUE
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
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Открываем вторую форму
            Form2 adminForm = new Form2();
            adminForm.Show();
            this.Hide(); // Скрываем первую форму, если нужно
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (login == "Admin" && password == "1111")
            {
                // Открываем вторую форму
                Form4 adminForm = new Form4();
                adminForm.Show();
                this.Hide(); // Скрываем первую форму, если нужно
            }
            else if (CheckUser(login, password))
            {
                // Переход на форму пользователя
                Form3 userForm = new Form3();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
        private bool CheckUser(string login, string password)
        {
            // Запрос к БД для проверки пользователя
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT 1 FROM Registration WHERE Login = @login AND Password = @password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
            }
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
        
    }

}


