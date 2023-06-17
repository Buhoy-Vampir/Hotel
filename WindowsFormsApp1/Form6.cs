using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6(string param1, string param2)
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_registration_window.MouseDown += new MouseEventHandler(moving_MouseDown);
            код_сотрудникаTextBox.Text = param1;
            код_клиентаTextBox.Text = param2;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оформление завершено.");
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Доп_услуги". При необходимости она может быть перемещена или удалена.
            this.доп_услугиTableAdapter.Fill(this.hotelDataSet.Доп_услуги);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sqlQuery = new SqlQuery();
            string sql = "INSERT INTO Оказанные_услуги ([Код услуги],[Код клиента],[Код сотрудника],[Примечание]) VALUES " +
                "( '" + код_услугиTextBox.Text + "', '" + код_клиентаTextBox.Text + "', '" + код_сотрудникаTextBox.Text + "', '" + примечаниеTextBox.Text + "')";

            try
            {
                sqlQuery.ExecuteNonQuery(sql);
                MessageBox.Show("Услуга оформлена успешно.");
                Form6_Load(sender, e);
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
