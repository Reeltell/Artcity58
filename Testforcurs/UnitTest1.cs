namespace Testforcurs
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Artcity58;
    using System.Data.SQLite;

    
    
        [TestClass]
        public class Form3Tests
        {
            private const string connectionString = "Data Source=artcity58.db;Version=3";

            [TestInitialize]
            public void Setup()
            {
                // �������������� �������� ���� ������ (������� ������� ����� ������ ������)
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var deleteConsultations = new SQLiteCommand("DELETE FROM Consultations", connection);
                    deleteConsultations.ExecuteNonQuery();

                    var deleteAdvertising = new SQLiteCommand("DELETE FROM Advertising", connection);
                    deleteAdvertising.ExecuteNonQuery();
                }
            }

            [TestMethod]
            public void Test_AddConsultation()
            {
                // Arrange
                Form3 form = new Form3();
                string testName = "����";
                string testNumber = "+1234567890";

                // Act
                form.AddConsultation(testName, testNumber);

                // Assert
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var command = new SQLiteCommand("SELECT COUNT(*) FROM Consultations WHERE Name = @Name AND Number = @Number", connection);
                    command.Parameters.AddWithValue("@Name", testName);
                    command.Parameters.AddWithValue("@Number", testNumber);
                    long count = (long)command.ExecuteScalar();

                    Assert.AreEqual(1, count, "������������ �� ���� ���������.");
                }
            }

            [TestMethod]
            public void Test_AddAdvertisingRequest()
            {
                // Arrange
                Form3 form = new Form3();
                string testName = "�������� ���";
                string testTG = "@test_tg";
                string testDopInf = "�������� ����������";

                // Act
                form.AddAdvertisingRequest(testName, testTG, testDopInf);

                // Assert
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var command = new SQLiteCommand("SELECT COUNT(*) FROM Advertising WHERE Name = @Name AND TG = @TG AND DopInf = @DopInf", connection);
                    command.Parameters.AddWithValue("@Name", testName);
                    command.Parameters.AddWithValue("@TG", testTG);
                    command.Parameters.AddWithValue("@DopInf", testDopInf);
                    long count = (long)command.ExecuteScalar();

                    Assert.AreEqual(1, count, "��������� ������ �� ���� ���������.");
                }
            }
        }
}

