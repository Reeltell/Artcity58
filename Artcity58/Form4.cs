using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artcity58
{
    public partial class Form4 : Form
    {
        static string connectionString = $"Data Source=artcity58.db;Version=3";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            listBox1.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT Name, Number FROM Consultations", connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string number = reader["Number"].ToString();
                    listBox1.Items.Add($"{name} - {number}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);
                string name = parts[0]; // Assuming Name is unique

                DeleteConsultation(name);
                LoadData(); // Refresh the list
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }

        private void DeleteConsultation(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Consultations WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData2();
        }
        private void LoadData2()
        {
            listBox2.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT Name, TG, DopInf FROM Advertising", connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string tg = reader["TG"].ToString();
                    string dopinf = reader["DopInf"].ToString();
                    listBox2.Items.Add($"{name} - {tg} - {dopinf}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string selectedItem = listBox2.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);
                string name = parts[0]; // Assuming Name is unique

                DeleteConsultation2(name);
                LoadData2(); // Refresh the list
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }
        private void DeleteConsultation2(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("DELETE FROM Advertising WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  
            this.Hide();     
        }
    }
}
    
