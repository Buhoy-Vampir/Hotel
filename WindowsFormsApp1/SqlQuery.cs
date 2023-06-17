using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class SqlQuery
{
    private readonly string connectionString;

    public SqlQuery()
    {
        this.connectionString = "Data Source=KABOOM;Initial Catalog=Hotel;Integrated Security=True";
    }

    public DataTable ExecuteQuery(string query)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var dataTable = new DataTable();
            var command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
            return dataTable;
        }
    }
    public int ExecuteScalar(string query)
    {
        int count = -1;
        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                count = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
            return count;
        }
    }

    public string PerformsExtraction(string query, string param1, string param2)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            string value = "";
            try
            {
                // Открытие подключения
                connection.Open();
                // Создание команды с параметром
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Задание значения параметра (Код сотрудника, 5)
                    command.Parameters.AddWithValue(param1, param2);

                    // Извлечение значения стоимости
                    value = Convert.ToString(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
            return value;
        }
    }

    public void ExecuteNonQuery(string query)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }

    public DataTable DataTable(string colum)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            // Создаем объект DataTable для хранения результатов запроса
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                // Открываем подключение к базе данных
                connection.Open();
                switch (colum)
                {
                    case "Бронь":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("select * from [Бронь]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Доп_услуги":
                        adapter = new SqlDataAdapter("select * from [Доп_услуги]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Сотрудник":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; SELECT [Код сотрудника], Должность, ФИО, Пол, [Дата рождения], CONVERT(nvarchar(max), DECRYPTBYKEY([Адрес])) AS [Адрес], CONVERT(nvarchar(max), DECRYPTBYKEY(Телефон)) AS Телефон, CONVERT(nvarchar(max), DECRYPTBYKEY([Паспорт])) AS [Паспорт], Примечание FROM [dbo].[Сотрудник]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Клиент":
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; SELECT Код_клиента, ФИО, Пол, [Дата рождения], CONVERT(nvarchar(max), DECRYPTBYKEY([Адрес])) AS [Адрес], CONVERT(nvarchar(max), DECRYPTBYKEY(Телефон)) AS Телефон, CONVERT(nvarchar(max), DECRYPTBYKEY([Паспорт])) AS [Паспорт], Примечание FROM [dbo].Клиент", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Номера":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("select * from [Номера]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Оказанные_услуги":
                        adapter = new SqlDataAdapter("select * from [Оказанные_услуги]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Пользователи":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; SELECT CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) AS [Логин], CONVERT(nvarchar(max), DECRYPTBYKEY([Пароль])) AS [Пароль], [Роль], [Код сотрудника], [ФИО], CONVERT(nvarchar(max), DECRYPTBYKEY([Телефон])) AS [Телефон], CONVERT(nvarchar(max), DECRYPTBYKEY([Почта])) AS [Почта], Примечание FROM [dbo].Пользователи", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Пропуск":
                        adapter = new SqlDataAdapter("select * from [Пропуск]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Уборка":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("select * from [Уборка]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Бронь номеров":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT        dbo.Клиент.ФИО AS [ФИО клиента], dbo.Клиент.[Дата рождения], CONVERT(nvarchar(MAX), DECRYPTBYKEY(dbo.Клиент.Телефон)) AS Телефон, CONVERT(nvarchar(MAX), DECRYPTBYKEY(dbo.Клиент.Паспорт)) \r\n                         AS Паспорт, dbo.Бронь.Номер, dbo.Бронь.[Дата прибытия], dbo.Бронь.[Дата отбытия]\r\nFROM            dbo.Бронь INNER JOIN\r\n                         dbo.Клиент ON dbo.Бронь.[Код клиента] = dbo.Клиент.Код_клиента INNER JOIN\r\n                         dbo.Сотрудник ON dbo.Бронь.[Код сотрудника] = dbo.Сотрудник.[Код сотрудника]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Номера с клиентами":
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT        dbo.Номера.Номер, dbo.Номера.[Вид номера], dbo.Клиент.ФИО, CONVERT(nvarchar(MAX), DECRYPTBYKEY(dbo.Клиент.Телефон)) AS Телефон, dbo.Бронь.[Дата прибытия], dbo.Бронь.[Дата отбытия]\r\nFROM            dbo.Номера INNER JOIN\r\n                         dbo.Бронь ON dbo.Номера.Номер = dbo.Бронь.Номер INNER JOIN\r\n                         dbo.Клиент ON dbo.Бронь.[Код клиента] = dbo.Клиент.Код_клиента", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    case "Оказанные услуги":
                        // Создаем адаптер данных для заполнения DataGridView
                        adapter = new SqlDataAdapter("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT        dbo.Оказанные_услуги.[Код сотрудника], dbo.Сотрудник.ФИО AS [ФИО сотрудника], dbo.Оказанные_услуги.[Код клиента], dbo.Клиент.ФИО AS [ФИО клиента], dbo.Доп_услуги.[Код услуги], \r\n                         dbo.Доп_услуги.Наименование, dbo.Доп_услуги.Стоимость\r\nFROM            dbo.Оказанные_услуги INNER JOIN\r\n                         dbo.Доп_услуги ON dbo.Оказанные_услуги.[Код услуги] = dbo.Доп_услуги.[Код услуги] INNER JOIN\r\n                         dbo.Клиент ON dbo.Оказанные_услуги.[Код клиента] = dbo.Клиент.Код_клиента INNER JOIN\r\n                         dbo.Сотрудник ON dbo.Оказанные_услуги.[Код сотрудника] = dbo.Сотрудник.[Код сотрудника]", connection);
                        // Заполняем DataTable данными из таблицы "Клиент"
                        adapter.Fill(dataTable);
                        // Привязываем DataTable к DataGridView
                        return dataTable;
                    default:
                        // Привязываем DataTable к DataGridView
                        return null;
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                // Привязываем DataTable к DataGridView
                return null;
            }
        }
    }
}
