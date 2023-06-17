using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(string param)
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_form_window.MouseDown += new MouseEventHandler(moving_MouseDown);
            tabPage1.Text = "Бронь";
            tabPage2.Text = "Доп услуги";
            tabPage3.Text = "Клиент";
            tabPage4.Text = "Номера";
            tabPage5.Text = "Оказанные услуги";
            tabPage6.Text = "Пропуск";
            tabPage7.Text = "Сотрудник";
            tabPage9.Text = "Уборка";
            tabPage10.Text = "Пользователи";
            tabPage11.Text = "Представления базы данных";
            label1.Text = "Сотрудник: " + param;
        }

        SqlQuery sqlQuery = new SqlQuery();

        #region form moving
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void moving_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(this.Handle, 0xA1, 0x2, 0);
                SendMessage(this.Handle, 0x86, 0, 0);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            this.броньDataGridView.DataSource = sqlQuery.DataTable("Бронь");
            this.доп_услугиDataGridView.DataSource = sqlQuery.DataTable("Доп_услуги");
            this.сотрудникDataGridView.DataSource = sqlQuery.DataTable("Сотрудник");
            this.клиентDataGridView.DataSource = sqlQuery.DataTable("Клиент");
            this.номераDataGridView.DataSource = sqlQuery.DataTable("Номера");
            this.оказанные_услугиDataGridView.DataSource = sqlQuery.DataTable("Оказанные_услуги");
            this.пользователиDataGridView.DataSource = sqlQuery.DataTable("Пользователи");
            this.пропускDataGridView.DataSource = sqlQuery.DataTable("Пропуск");
            this.уборкаDataGridView.DataSource = sqlQuery.DataTable("Уборка");
            this.бронь_номеровDataGridView.DataSource = sqlQuery.DataTable("Бронь номеров");
            this.номера_с_клиентамиDataGridView.DataSource = sqlQuery.DataTable("Номера с клиентами");
            this.оказанные_услугиDataGridView1.DataSource = sqlQuery.DataTable("Оказанные услуги");
        }

        private void DataTransfer(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(tabControl1.SelectedIndex))
            {
                case 0:
                    if (код_клиентаTextBox3.Text != "")
                    {
                        код_клиентаTextBox.Text = код_клиентаTextBox3.Text;
                        код_сотрудникаTextBox.Text = код_сотрудникаTextBox4.Text;
                        номерTextBox.Text = номерTextBox4.Text;
                        код_пропускаTextBox.Text = код_пропускаTextBox2.Text;
                        дата_прибытияDateTimePicker.Value = дата_прибытияDateTimePicker1.Value;
                        дата_отбытияDateTimePicker.Value = дата_отбытияDateTimePicker1.Value;
                        стоимостьTextBox.Text = стоимостьTextBox3.Text;
                        примечаниеTextBox.Text = примечаниеTextBox10.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    if (код_услугиTextBox2.Text != "")
                    {
                        код_услугиTextBox.Text = код_услугиTextBox2.Text;
                        наименованиеTextBox.Text = наименованиеTextBox2.Text;
                        стоимостьTextBox1.Text = стоимостьTextBox4.Text;
                        примечаниеTextBox1.Text = примечаниеTextBox11.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 2:
                    if (код_клиентаTextBox4.Text != "")
                    {
                        код_клиентаTextBox1.Text = код_клиентаTextBox4.Text;
                        фИОTextBox.Text = фИОTextBox3.Text;
                        полTextBox.Text = полTextBox2.Text;
                        дата_рожденияDateTimePicker.Value = дата_рожденияDateTimePicker2.Value;
                        адресTextBox.Text = адресTextBox2.Text;
                        телефонTextBox.Text = телефонTextBox3.Text;
                        паспортTextBox.Text = паспортTextBox2.Text;
                        примечаниеTextBox2.Text = примечаниеTextBox12.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 3:
                    if (номерTextBox5.Text != "")
                    {
                        номерTextBox1.Text = номерTextBox5.Text;
                        вид_номераTextBox.Text = вид_номераTextBox1.Text;
                        стоимостьTextBox2.Text = стоимостьTextBox5.Text;
                        примечаниеTextBox3.Text = примечаниеTextBox13.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 4:
                    if (код_услугиTextBox3.Text != "")
                    {
                        код_услугиTextBox1.Text = код_услугиTextBox3.Text;
                        код_клиентаTextBox2.Text = код_клиентаTextBox5.Text;
                        код_сотрудникаTextBox1.Text = код_сотрудникаTextBox5.Text;
                        примечаниеTextBox4.Text = примечаниеTextBox14.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 5:
                    if (код_пропускаTextBox3.Text != "")
                    {
                        код_пропускаTextBox1.Text = код_пропускаTextBox3.Text;
                        номерTextBox2.Text = номерTextBox6.Text;
                        примечаниеTextBox5.Text = примечаниеTextBox15.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 6:
                    if (код_сотрудникаTextBox6.Text != "")
                    {
                        код_сотрудникаTextBox2.Text = код_сотрудникаTextBox6.Text;
                        должностьTextBox.Text = должностьTextBox2.Text;
                        фИОTextBox1.Text = фИОTextBox4.Text;
                        полTextBox1.Text = полTextBox3.Text;
                        дата_рожденияDateTimePicker1.Value = дата_рожденияDateTimePicker3.Value;
                        адресTextBox1.Text = адресTextBox3.Text;
                        телефонTextBox1.Text = телефонTextBox4.Text;
                        паспортTextBox1.Text = паспортTextBox3.Text;
                        примечаниеTextBox6.Text = примечаниеTextBox16.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 7:
                    if (код_сотрудникаTextBox7.Text != "")
                    {
                        код_сотрудникаTextBox3.Text = код_сотрудникаTextBox7.Text;
                        номерTextBox3.Text = номерTextBox7.Text;
                        день_неделиTextBox.Text = день_неделиTextBox1.Text;
                        время_начала_уборкиTextBox.Text = время_начала_уборкиTextBox1.Text;
                        длительностьTextBox.Text = длительностьTextBox1.Text;
                        примечаниеTextBox8.Text = примечаниеTextBox18.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 8:
                    if (логинTextBox1.Text != "")
                    {
                        логинTextBox.Text = логинTextBox1.Text;
                        парольTextBox.Text = парольTextBox1.Text;
                        рольTextBox.Text = рольTextBox1.Text;
                        код_сотрудникаTextBox8.Text = код_сотрудникаTextBox9.Text;
                        фИОTextBox2.Text = фИОTextBox5.Text;
                        телефонTextBox2.Text = телефонTextBox5.Text;
                        почтаTextBox.Text = почтаTextBox1.Text;
                        примечаниеTextBox9.Text = примечаниеTextBox19.Text;
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.бронь_номеровDataGridView.Visible = false;
                    this.номера_с_клиентамиDataGridView.Visible = false;
                    this.оказанные_услугиDataGridView1.Visible = true;
                    break;
                case 1:
                    this.бронь_номеровDataGridView.Visible = false;
                    this.номера_с_клиентамиDataGridView.Visible = true;
                    this.оказанные_услугиDataGridView1.Visible = false;
                    break;
                case 2:
                    this.бронь_номеровDataGridView.Visible = true;
                    this.номера_с_клиентамиDataGridView.Visible = false;
                    this.оказанные_услугиDataGridView1.Visible = false;
                    break;
                default:
                    this.бронь_номеровDataGridView.Visible = false;
                    this.номера_с_клиентамиDataGridView.Visible = false;
                    this.оказанные_услугиDataGridView1.Visible = false;
                    break;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ExportToExcel(оказанные_услугиDataGridView1);
                    break;
                case 1:
                    ExportToExcel(номера_с_клиентамиDataGridView);
                    break;
                case 2:
                    ExportToExcel(бронь_номеровDataGridView);
                    break;
                default:
                    break;
            }
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                // Создание нового объекта Excel
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                Excel.Workbook workbook = excel.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                // Запись заголовков столбцов
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                // Запись данных
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Сохранение файла Excel
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv";
                saveDialog.FileName = "ExportedData.xlsx";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Данные успешно экспортированы в Excel.", "Экспорт в Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте данных в Excel: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_form(object sender, EventArgs e)
        {

            this.Close();
        }

        #region insert delete update
        private void insert_line(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Добавить запись?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {

                switch (Convert.ToInt32(tabControl1.SelectedIndex))
                {
                    case 0:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Бронь ([Код сотрудника],[Номер],[Код пропуска],[Дата прибытия],[Дата отбытия],[Стоимость],[Примечание]) " +
                            "VALUES ('" + код_сотрудникаTextBox.Text + "','" + номерTextBox.Text + "','" + код_пропускаTextBox.Text + "','" + дата_прибытияDateTimePicker.Value + "','" + дата_отбытияDateTimePicker.Value + "','" + стоимостьTextBox.Text + "','" + примечаниеTextBox.Text + "')");
                        break;
                    case 1:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Доп_услуги ([Код услуги],[Наименование],[Стоимость],[Примечание]) VALUES ('" + код_услугиTextBox.Text + "', '" + наименованиеTextBox.Text + "', '" + стоимостьTextBox1.Text + "', '" + примечаниеTextBox1.Text + "')");
                        break;
                    case 2:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Клиент ([ФИО],[Пол],[Дата рождения],[Адрес],[Телефон],[Паспорт],[Примечание]) VALUES ('" + фИОTextBox.Text + "', '" + полTextBox.Text + "', '" + дата_рожденияDateTimePicker.Value + "', '" + адресTextBox.Text + "', '" + телефонTextBox.Text + "', '" + паспортTextBox.Text + "', '" + примечаниеTextBox12.Text + "')");
                        break;
                    case 3:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Номера ([Номер],[Вид номера],[Стоимость],[Примечание]) VALUES ( '" + номерTextBox1.Text + "', '" + вид_номераTextBox.Text + "', '" + стоимостьTextBox2.Text + "', '" + примечаниеTextBox3.Text + "')");
                        break;
                    case 4:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Оказанные_услуги ([Код услуги],[Код клиента],[Код сотрудника],[Примечание]) VALUES ( '" + код_услугиTextBox1.Text + "', '" + код_клиентаTextBox2.Text + "', '" + код_сотрудникаTextBox1.Text + "', '" + примечаниеTextBox4.Text + "')");
                        break;
                    case 5:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Пропуск ([Код пропуска],[Номер],[Примечание]) VALUES ( '" + код_пропускаTextBox1.Text + "', '" + номерTextBox2.Text + "', '" + примечаниеTextBox5.Text + "')");
                        break;
                    case 6:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Сотрудник ([Должность],[ФИО],[Пол],[Дата рождения],[Адрес],[Телефон],[Паспорт],[Примечание]) VALUES ('" + должностьTextBox.Text + "', '" + фИОTextBox1.Text + "', '" + полTextBox1.Text + "', '" + дата_рожденияDateTimePicker1.Value + "', '" + адресTextBox1.Text + "', '" + телефонTextBox1.Text + "', '" + паспортTextBox1.Text + "', '" + примечаниеTextBox6.Text + "')");
                        break;
                    case 7:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Уборка ([Код сотрудника],[Номер],[День недели],[Время начала уборки],[Длительность],[Примечание]) VALUES ( '" + код_сотрудникаTextBox3.Text + "', '" + номерTextBox3.Text + "', '" + день_неделиTextBox.Text + "', '" + время_начала_уборкиTextBox.Text + "', '" + длительностьTextBox.Text + "', '" + примечаниеTextBox8.Text + "')");
                        break;
                    case 8:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Пользователи ([Логин],[Пароль],[Роль],[Код сотрудника],[ФИО],[Телефон],[Почта],[Примечание]) VALUES ( '" + логинTextBox.Text + "', '" + парольTextBox.Text + "', '" + рольTextBox.Text + "', '" + код_сотрудникаTextBox8.Text + "', '" + фИОTextBox2.Text + "', '" + телефонTextBox2.Text + "', '" + почтаTextBox.Text + "', '" + примечаниеTextBox9.Text + "')");
                        break;
                    default:
                        break;
                }
                Form1_Load(sender, e);
            }
        }

        private void delete_line(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                var sqlQuery = new SqlQuery();

                string tabname = "";
                string rowname = "";
                string searchname = "";
                switch (Convert.ToInt32(tabControl1.SelectedIndex))
                {
                    case 0:
                        tabname = "Бронь";
                        rowname = "[Код клиента]";
                        searchname = "'" + код_клиентаTextBox.Text + "'";
                        break;
                    case 1:
                        tabname = "Доп_услуги";
                        rowname = "[Код услуги]";
                        searchname = "'" + код_услугиTextBox.Text + "'";
                        break;
                    case 2:
                        tabname = "Клиент";
                        rowname = "[Код_клиента]";
                        searchname = "'" + код_клиентаTextBox1.Text + "'";
                        break;
                    case 3:
                        tabname = "Номера";
                        rowname = "[Номер]";
                        searchname = "'" + номерTextBox1.Text + "'";
                        break;
                    case 4:
                        tabname = "Оказанные_услуги";
                        rowname = "[Код услуги]";
                        searchname = "'" + код_услугиTextBox1.Text + "'";
                        break;
                    case 5:
                        tabname = "Пропуск";
                        rowname = "[Код пропуска]";
                        searchname = "'" + код_пропускаTextBox1.Text + "'";
                        break;
                    case 6:
                        tabname = "Сотрудник";
                        rowname = "[Код сотрудника]";
                        searchname = "'" + код_сотрудникаTextBox2.Text + "'";
                        break;
                    case 7:
                        tabname = "Уборка";
                        rowname = "[Код сотрудника]";
                        searchname = "'"+код_сотрудникаTextBox3.Text+"'";
                        break;
                    case 8:
                        tabname = "Пользователи";
                        rowname = "CONVERT(nvarchar(max), DECRYPTBYKEY([Логин]))";
                        searchname = "'"+логинTextBox.Text+"'";
                        break;
                    default:
                        break;
                }
                sqlQuery.ExecuteNonQuery("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; DELETE from " + tabname + " where " + rowname + " = " + searchname);
                Form1_Load(sender, e);
            }
        }

        private void update_line(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Изменить запись?", "Изменить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                var sqlQuery = new SqlQuery();

                switch (Convert.ToInt32(tabControl1.SelectedIndex))
                {
                    case 0:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Бронь SET  [Код клиента] = '" + код_клиентаTextBox.Text + "',[Код сотрудника] = '" + код_сотрудникаTextBox.Text + "',[Номер] = '" + номерTextBox.Text + "', [Код пропуска] = '" + код_пропускаTextBox.Text + "', [Дата прибытия] = '" + дата_прибытияDateTimePicker.Value + "', [Дата отбытия] = '" + дата_отбытияDateTimePicker.Value + "', [Стоимость] = '" + стоимостьTextBox.Text + "', [Примечание] = '" + примечаниеTextBox.Text + "' WHERE [Код клиента] = '" + код_клиентаTextBox3.Text + "'");
                        break;
                    case 1:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Доп_услуги SET [Код услуги] = '" + код_услугиTextBox.Text + "',[Наименование] = '" + наименованиеTextBox.Text + "',[Стоимость] = '" + стоимостьTextBox1.Text + "',[Примечание] = '" + примечаниеTextBox1.Text + "' WHERE [Код услуги] = '" + код_услугиTextBox2.Text + "'");
                        break;
                    case 2:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Клиент SET [ФИО] = '" + фИОTextBox.Text + "',[Пол] = '" + полTextBox.Text + "',[Дата рождения] = '" + дата_рожденияDateTimePicker.Value + "',[Адрес] = '" + адресTextBox.Text + "',[Телефон] = '" + телефонTextBox.Text + "',[Паспорт] = '" + паспортTextBox.Text + "',[Примечание] = '" + примечаниеTextBox2.Text + "' WHERE [Код_клиента] = '" + код_клиентаTextBox1.Text + "'");
                        break;
                    case 3:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Номера SET [Номер] = '" + номерTextBox1.Text + "',[Вид номера] = '" + вид_номераTextBox.Text + "',[Стоимость] = '" + стоимостьTextBox2.Text + "', [Примечание] = '" + примечаниеTextBox3.Text + "' WHERE [Номер] = '" + номерTextBox5.Text + "'");
                        break;
                    case 4:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Оказанные_услуги SET [Код услуги] = '" + код_услугиTextBox.Text + "',[Код клиента] = '" + код_клиентаTextBox2.Text + "',[Код сотрудника] = '" + код_сотрудникаTextBox1.Text + "',[Примечание] = '" + примечаниеTextBox4.Text + "' WHERE [Код услуги] = '" + код_услугиTextBox3.Text + "'");
                        break;
                    case 5:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Пропуск SET [Код пропуска] = '" + код_пропускаTextBox1.Text + "',[Номер] = '" + номерTextBox2.Text + "',[Примечание] = '" + примечаниеTextBox5.Text + "' WHERE [Код пропуска] = '" + код_пропускаTextBox3.Text + "'");
                        break;
                    case 6:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Сотрудник SET [Должность] = '" + должностьTextBox.Text + "',[ФИО] = '" + фИОTextBox1.Text + "',[Пол] = '" + полTextBox1.Text + "',[Дата рождения] = '" + дата_рожденияDateTimePicker1.Value + "',[Адрес] = '" + адресTextBox1.Text + "',[Телефон] = '" + телефонTextBox1.Text + "',[Паспорт] = '" + паспортTextBox1.Text + "',[Примечание] = '" + примечаниеTextBox6.Text + "' WHERE [Код сотрудника] = '" + код_сотрудникаTextBox2.Text + "'");
                        break;
                    case 7:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Уборка SET [Код сотрудника] = '" + код_сотрудникаTextBox3.Text + "',[Номер] = '" + номерTextBox3.Text + "',[День недели] = '" + день_неделиTextBox.Text + "',[Время начала уборки] = '" + время_начала_уборкиTextBox.Text + "',[Длительность] = '" + длительностьTextBox.Text + "',[Примечание] = '" + примечаниеTextBox8.Text + "' WHERE [Код сотрудника] = '" + код_сотрудникаTextBox7.Text + "'");
                        break;
                    case 8:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; UPDATE Пользователи SET [Логин] = '" + логинTextBox.Text + "',[Пароль] = '" + парольTextBox.Text + "',[Код сотрудника] = '" + код_сотрудникаTextBox8.Text + "',[ФИО] = '" + фИОTextBox2.Text + "',[Телефон] = '" + телефонTextBox2.Text + "',[Почта] = '" + почтаTextBox.Text + "',[Примечание] = '" + примечаниеTextBox9.Text + "' WHERE CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) = '" + логинTextBox1.Text + "'");
                        break;
                    default:
                        break;
                }
                Form1_Load(sender, e);
            }
        }
        #endregion

        #region CellClick
        private void броньDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = броньDataGridView.Rows[rowIndex];
            this.код_клиентаTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            this.код_сотрудникаTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            this.номерTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            this.код_пропускаTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            this.дата_прибытияDateTimePicker1.Text = selectedRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            this.дата_отбытияDateTimePicker1.Text = selectedRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            this.стоимостьTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
            this.примечаниеTextBox10.Text = selectedRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
        }

        private void доп_услугиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = доп_услугиDataGridView.Rows[rowIndex];
            this.код_услугиTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
            this.наименованиеTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
            this.стоимостьTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn12"].Value.ToString();
            this.примечаниеTextBox11.Text = selectedRow.Cells["dataGridViewTextBoxColumn13"].Value.ToString();

        }

        private void клиентDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = клиентDataGridView.Rows[rowIndex];
            this.код_клиентаTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn47"].Value.ToString();
            this.фИОTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn48"].Value.ToString();
            this.полTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn49"].Value.ToString();
            this.дата_рожденияDateTimePicker2.Text = selectedRow.Cells["dataGridViewTextBoxColumn50"].Value.ToString();
            this.адресTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn51"].Value.ToString();
            this.телефонTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn75"].Value.ToString();
            this.паспортTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn76"].Value.ToString();
            this.примечаниеTextBox12.Text = selectedRow.Cells["dataGridViewTextBoxColumn77"].Value.ToString();

        }

        private void номераDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = номераDataGridView.Rows[rowIndex];
            this.номерTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn22"].Value.ToString();
            this.вид_номераTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn23"].Value.ToString();
            this.стоимостьTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn24"].Value.ToString();
            this.примечаниеTextBox13.Text = selectedRow.Cells["dataGridViewTextBoxColumn25"].Value.ToString();

        }

        private void оказанные_услугиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = оказанные_услугиDataGridView.Rows[rowIndex];
            this.код_услугиTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn26"].Value.ToString();
            this.код_клиентаTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn27"].Value.ToString();
            this.код_сотрудникаTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn28"].Value.ToString();
            this.примечаниеTextBox14.Text = selectedRow.Cells["dataGridViewTextBoxColumn29"].Value.ToString();

        }

        private void пропускDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = пропускDataGridView.Rows[rowIndex];
            this.код_пропускаTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn30"].Value.ToString();
            this.номерTextBox6.Text = selectedRow.Cells["dataGridViewTextBoxColumn31"].Value.ToString();
            this.примечаниеTextBox15.Text = selectedRow.Cells["dataGridViewTextBoxColumn32"].Value.ToString();

        }

        private void сотрудникDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = сотрудникDataGridView.Rows[rowIndex];
            this.код_сотрудникаTextBox6.Text = selectedRow.Cells["dataGridViewTextBoxColumn20"].Value.ToString();
            this.должностьTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn21"].Value.ToString();
            this.фИОTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn33"].Value.ToString();
            this.полTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn34"].Value.ToString();
            this.дата_рожденияDateTimePicker3.Text = selectedRow.Cells["dataGridViewTextBoxColumn35"].Value.ToString();
            this.адресTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn36"].Value.ToString();
            this.телефонTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn37"].Value.ToString();
            this.паспортTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn38"].Value.ToString();
            this.примечаниеTextBox16.Text = selectedRow.Cells["dataGridViewTextBoxColumn39"].Value.ToString();

        }

        private void уборкаDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = уборкаDataGridView.Rows[rowIndex];
            this.код_сотрудникаTextBox7.Text = selectedRow.Cells["dataGridViewTextBoxColumn14"].Value.ToString();
            this.номерTextBox7.Text = selectedRow.Cells["dataGridViewTextBoxColumn15"].Value.ToString();
            this.день_неделиTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn16"].Value.ToString();
            this.время_начала_уборкиTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn17"].Value.ToString();
            this.длительностьTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn18"].Value.ToString();
            this.примечаниеTextBox18.Text = selectedRow.Cells["dataGridViewTextBoxColumn19"].Value.ToString();

        }

        private void пользователиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = пользователиDataGridView.Rows[rowIndex];
            this.логинTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn40"].Value.ToString();
            this.парольTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn41"].Value.ToString();
            this.рольTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn52"].Value.ToString();
            this.код_сотрудникаTextBox9.Text = selectedRow.Cells["dataGridViewTextBoxColumn53"].Value.ToString();
            this.фИОTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn54"].Value.ToString();
            this.телефонTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn55"].Value.ToString();
            this.почтаTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn56"].Value.ToString();
            this.примечаниеTextBox19.Text = selectedRow.Cells["dataGridViewTextBoxColumn57"].Value.ToString();

        }
        #endregion
    }
}
