using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_registration_window.MouseDown += new MouseEventHandler(moving_MouseDown);
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
            var sqlQuery = new SqlQuery();
            var dataTable = sqlQuery.ExecuteQuery("Select * from Пользователи Where Логин = '" + логинTextBox.Text.Trim() + "'");
            if (dataTable.Rows.Count == 0)
            {
                string sql = "INSERT INTO Пользователи ([Логин],[Пароль],[Роль],[Код сотрудника],[ФИО],[Телефон],[Почта],[Примечание]) VALUES ( '" + логинTextBox.Text + "', '" + парольTextBox.Text + "', 'Ожидает подтверждения', '" + код_сотрудникаTextBox.Text + "', '" + фИОTextBox.Text + "', '" + телефонTextBox.Text + "', '" + почтаTextBox.Text + "', '')";
                try
                {
                    sqlQuery.ExecuteNonQuery(sql);
                    MessageBox.Show("Регистрация прошла успешно, ожидайте выдачи роли!");
                    Form3_Load(sender, e);
                }
                catch (Exception ex)
                {
                    // Обработка ошибок
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Такой логин уже существует, придумайте новый!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            логинTextBox.Text = "";
            парольTextBox.Text = "";
            код_сотрудникаTextBox.Text = "";
            фИОTextBox.Text = "";
            телефонTextBox.Text = "";
            почтаTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
