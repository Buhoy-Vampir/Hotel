using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7(string param)
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
            tabPage9.Text = "Уборка";
            label1.Text = "Сотрудник: " + param;
            button_data1.Click += DataTransfer;
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
                default:
                    break;
            }
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

        private void Form7_Load(object sender, EventArgs e)
        {
            this.броньDataGridView.DataSource = sqlQuery.DataTable("Бронь");
            this.доп_услугиDataGridView.DataSource = sqlQuery.DataTable("Доп_услуги");
            this.клиентDataGridView.DataSource = sqlQuery.DataTable("Клиент");
            this.номераDataGridView.DataSource = sqlQuery.DataTable("Номера");
            this.оказанные_услугиDataGridView.DataSource = sqlQuery.DataTable("Оказанные_услуги");
            this.пропускDataGridView.DataSource = sqlQuery.DataTable("Пропуск");
            this.уборкаDataGridView.DataSource = sqlQuery.DataTable("Уборка");
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
                    case 7:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("INSERT INTO Уборка ([Код сотрудника],[Номер],[День недели],[Время начала уборки],[Длительность],[Примечание]) VALUES ( '" + код_сотрудникаTextBox3.Text + "', '" + номерTextBox3.Text + "', '" + день_неделиTextBox.Text + "', '" + время_начала_уборкиTextBox.Text + "', '" + длительностьTextBox.Text + "', '" + примечаниеTextBox8.Text + "')");
                        break;
                    default:
                        break;
                }
                Form7_Load(sender, e);
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
                    case 7:
                        tabname = "Уборка";
                        rowname = "[Код сотрудника]";
                        searchname = "'" + код_сотрудникаTextBox3.Text + "'";
                        break;
                    default:
                        break;
                }
                sqlQuery.ExecuteNonQuery("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; DELETE from " + tabname + " where " + rowname + " = " + searchname);
                Form7_Load(sender, e);
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
                    case 7:

                        //SQL-запрос
                        sqlQuery.ExecuteNonQuery("UPDATE Уборка SET [Код сотрудника] = '" + код_сотрудникаTextBox3.Text + "',[Номер] = '" + номерTextBox3.Text + "',[День недели] = '" + день_неделиTextBox.Text + "',[Время начала уборки] = '" + время_начала_уборкиTextBox.Text + "',[Длительность] = '" + длительностьTextBox.Text + "',[Примечание] = '" + примечаниеTextBox8.Text + "' WHERE [Код сотрудника] = '" + код_сотрудникаTextBox7.Text + "'");
                        break;
                    default:
                        break;
                }
                Form7_Load(sender, e);
            }
        }
        #endregion

        #region SelectionChanged
        private void броньDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (броньDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = броньDataGridView.SelectedRows[0];
                this.код_клиентаTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                this.код_сотрудникаTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                this.номерTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                this.код_пропускаTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                this.дата_прибытияDateTimePicker1.Text = selectedRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                this.дата_отбытияDateTimePicker1.Text = selectedRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                this.стоимостьTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                this.примечаниеTextBox10.Text = selectedRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
            }
        }

        private void доп_услугиDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (доп_услугиDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = доп_услугиDataGridView.SelectedRows[0];
                this.код_услугиTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
                this.наименованиеTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
                this.стоимостьTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn12"].Value.ToString();
                this.примечаниеTextBox11.Text = selectedRow.Cells["dataGridViewTextBoxColumn13"].Value.ToString();
            }
        }

        private void клиентDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (клиентDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = клиентDataGridView.SelectedRows[0];
                this.код_клиентаTextBox4.Text = selectedRow.Cells["dataGridViewTextBoxColumn47"].Value.ToString();
                this.фИОTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn48"].Value.ToString();
                this.полTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn49"].Value.ToString();
                this.дата_рожденияDateTimePicker2.Text = selectedRow.Cells["dataGridViewTextBoxColumn50"].Value.ToString();
                this.адресTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn51"].Value.ToString();
                this.телефонTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn75"].Value.ToString();
                this.паспортTextBox2.Text = selectedRow.Cells["dataGridViewTextBoxColumn76"].Value.ToString();
                this.примечаниеTextBox12.Text = selectedRow.Cells["dataGridViewTextBoxColumn77"].Value.ToString();
            }
        }

        private void номераDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (номераDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = номераDataGridView.SelectedRows[0];
                this.номерTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                this.вид_номераTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn23"].Value.ToString();
                this.стоимостьTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn24"].Value.ToString();
                this.примечаниеTextBox13.Text = selectedRow.Cells["dataGridViewTextBoxColumn25"].Value.ToString();
            }
        }

        private void оказанные_услугиDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (оказанные_услугиDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = оказанные_услугиDataGridView.SelectedRows[0];
                this.код_услугиTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn26"].Value.ToString();
                this.код_клиентаTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn27"].Value.ToString();
                this.код_сотрудникаTextBox5.Text = selectedRow.Cells["dataGridViewTextBoxColumn28"].Value.ToString();
                this.примечаниеTextBox14.Text = selectedRow.Cells["dataGridViewTextBoxColumn29"].Value.ToString();
            }
        }

        private void пропускDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (пропускDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = пропускDataGridView.SelectedRows[0];
                this.код_пропускаTextBox3.Text = selectedRow.Cells["dataGridViewTextBoxColumn30"].Value.ToString();
                this.номерTextBox6.Text = selectedRow.Cells["dataGridViewTextBoxColumn31"].Value.ToString();
                this.примечаниеTextBox15.Text = selectedRow.Cells["dataGridViewTextBoxColumn32"].Value.ToString();
            }
        }

        private void уборкаDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (уборкаDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = уборкаDataGridView.SelectedRows[0];
                this.код_сотрудникаTextBox7.Text = selectedRow.Cells["dataGridViewTextBoxColumn14"].Value.ToString();
                this.номерTextBox7.Text = selectedRow.Cells["dataGridViewTextBoxColumn15"].Value.ToString();
                this.день_неделиTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn16"].Value.ToString();
                this.время_начала_уборкиTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn17"].Value.ToString();
                this.длительностьTextBox1.Text = selectedRow.Cells["dataGridViewTextBoxColumn18"].Value.ToString();
                this.примечаниеTextBox18.Text = selectedRow.Cells["dataGridViewTextBoxColumn19"].Value.ToString();
            }
        }
        #endregion
    }
}
