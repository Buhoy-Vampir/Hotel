using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private readonly string employee;
        public Form4(string param1, string param2)
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_registration_window.MouseDown += new MouseEventHandler(moving_MouseDown);
            label1.Text = "Сотрудник: " + param1;
            // Назначение обработчика событий для всех кнопок номеров
            button_num1.Click += ButtonNum_Click;
            button_num2.Click += ButtonNum_Click;
            button_num3.Click += ButtonNum_Click;
            button_num4.Click += ButtonNum_Click;
            button_num5.Click += ButtonNum_Click;
            button_num6.Click += ButtonNum_Click;
            button_num7.Click += ButtonNum_Click;
            button_num8.Click += ButtonNum_Click;
            button_num9.Click += ButtonNum_Click;
            button_num10.Click += ButtonNum_Click;
            button_num11.Click += ButtonNum_Click;
            button_num12.Click += ButtonNum_Click;
            this.employee = param2;
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

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CheckNumberAvailability(button_num1, 1);
            CheckNumberAvailability(button_num2, 2);
            CheckNumberAvailability(button_num3, 3);
            CheckNumberAvailability(button_num4, 4);
            CheckNumberAvailability(button_num5, 5);
            CheckNumberAvailability(button_num6, 6);
            CheckNumberAvailability(button_num7, 7);
            CheckNumberAvailability(button_num8, 8);
            CheckNumberAvailability(button_num9, 9);
            CheckNumberAvailability(button_num10, 10);
            CheckNumberAvailability(button_num11, 11);
            CheckNumberAvailability(button_num12, 12);
        }

        private void CheckNumberAvailability(Button button, int номер)
        {
            string query = $"SELECT COUNT(*) FROM Бронь WHERE Номер = {номер}";

            if (sqlQuery.ExecuteScalar(query) > 0)
            {
                button.BackColor = Color.Red; // Номер занят
                button.Enabled = false;
            }
            else
            {
                button.BackColor = Color.Green; // Номер свободен
            }

        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Form4_Load(sender, e);
            button.BackColor = Color.Orange;
            номерTextBox.Text = button.Tag.ToString();
            код_пропускаTextBox.Text = button.Tag.ToString();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            string query = "SELECT [Стоимость] FROM [Номера] WHERE [Номер] = '" + номерTextBox.Text + "'";
            // Получение значений дат и стоимости
            DateTime дата_прибытия = дата_прибытияDateTimePicker.Value;
            DateTime дата_отбытия = дата_отбытияDateTimePicker.Value;
            decimal стоимость = Convert.ToDecimal(sqlQuery.PerformsExtraction(query, "@Номер", номерTextBox.Text));

            // Рассчет разницы между датами
            TimeSpan разница = дата_отбытия - дата_прибытия;

            // Рассчет общей стоимости
            decimal общая_стоимость = (разница.Days + 1) * стоимость;

            // Отображение или использование общей стоимости
            стоимостьTextBox.Text = общая_стоимость.ToString();

        }

        private void button_select_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Добавить запись?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                sqlQuery.ExecuteNonQuery("INSERT INTO Клиент ([ФИО],[Пол],[Дата рождения],[Адрес],[Телефон],[Паспорт],[Примечание]) VALUES ('" + фИОTextBox.Text + "', '" + полTextBox.Text + "', '" + дата_рожденияDateTimePicker.Value + "', '" + адресTextBox.Text + "', '" + телефонTextBox.Text + "', '" + паспортTextBox.Text + "', '" + примечаниеTextBox.Text + "')");
                string query = "OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate; SELECT Код_клиента FROM [dbo].Клиент WHERE CONVERT(nvarchar(max), DECRYPTBYKEY([Паспорт])) = '" + паспортTextBox.Text + "'";
                sqlQuery.ExecuteNonQuery("INSERT INTO Бронь ([Код клиента],[Код сотрудника],[Номер],[Код пропуска],[Дата прибытия],[Дата отбытия],[Стоимость],[Примечание]) " +
                    "VALUES ('" + sqlQuery.PerformsExtraction(query, "@Паспорт", паспортTextBox.Text) + "','" + employee + "','" + номерTextBox.Text + "','" + код_пропускаTextBox.Text + "','" + дата_прибытияDateTimePicker.Value + "','" + дата_отбытияDateTimePicker.Value + "','" + стоимостьTextBox.Text + "','" + примечаниеTextBox1.Text + "')");

                Form6 form6 = new Form6(employee, sqlQuery.PerformsExtraction(query, "@Паспорт", паспортTextBox.Text));
                form6.ShowDialog();
                фИОTextBox.Text = "";
                полTextBox.Text = "";
                дата_рожденияDateTimePicker.Text = DateTime.Now.ToString();
                адресTextBox.Text = "";
                телефонTextBox.Text = "";
                паспортTextBox.Text = "";
                примечаниеTextBox.Text = "";
                номерTextBox.Text = "";
                код_пропускаTextBox.Text = "";
                дата_прибытияDateTimePicker.Text = DateTime.Now.ToString();
                дата_отбытияDateTimePicker.Text = DateTime.Now.ToString();
                стоимостьTextBox.Text = "";
                примечаниеTextBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            Docx docx = new Docx();
            string[] param = { дата_прибытияDateTimePicker.Text, фИОTextBox.Text, дата_рожденияDateTimePicker.Text, адресTextBox.Text,
                паспортTextBox.Text, телефонTextBox.Text, стоимостьTextBox.Text };
            docx.DocxPrint(param);
        }
    }
}
