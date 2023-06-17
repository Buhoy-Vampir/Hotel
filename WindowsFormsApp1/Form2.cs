using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_authorization_window.MouseDown += new MouseEventHandler(moving_MouseDown);
            textBox1.Text = "admin";
            textBox2.Text = "password1";
            textBox2.UseSystemPasswordChar = true;
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
            var dataTable = sqlQuery.ExecuteQuery("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;Select * from Пользователи Where CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) = '" + textBox1.Text.Trim() + "' and CONVERT(nvarchar(max), DECRYPTBYKEY([Пароль])) = '" + textBox2.Text.Trim() + "'");
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Авторизация прошла успешно", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                string query1 = "OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT [ФИО] FROM [Пользователи] WHERE CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) = '" + textBox1.Text + "'";
                string query2 = "OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT [Код сотрудника] FROM [Пользователи] WHERE CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) = '" + textBox1.Text + "'";

                switch (sqlQuery.PerformsExtraction("OPEN SYMMETRIC KEY Babaduk DECRYPTION BY CERTIFICATE HotelCertificate;SELECT [Роль] FROM [Пользователи] WHERE CONVERT(nvarchar(max), DECRYPTBYKEY([Логин])) = '" + textBox1.Text + "'", "@Логин", textBox1.Text.Trim()))
                {
                    case "admin":
                        Form1 form1 = new Form1(sqlQuery.PerformsExtraction(query1, "@Логин", textBox1.Text.Trim()));
                        this.Visible = false;
                        form1.ShowDialog();
                        break;
                    case "employee":
                        Form4 form4 = new Form4(sqlQuery.PerformsExtraction(query1, "@Логин", textBox1.Text.Trim()), sqlQuery.PerformsExtraction(query2, "@Логин", textBox1.Text.Trim()));
                        this.Visible = false;
                        form4.ShowDialog();
                        break;
                    case "cleaner":
                        Form5 form5 = new Form5(sqlQuery.PerformsExtraction(query1, "@Логин", textBox1.Text.Trim()));
                        this.Visible = false;
                        form5.ShowDialog();
                        break;
                    case "manager":
                        Form7 form7 = new Form7(sqlQuery.PerformsExtraction(query1, "@Логин", textBox1.Text.Trim()));
                        this.Visible = false;
                        form7.ShowDialog();
                        break;
                    default:
                        break;
                }
                this.Visible = true;

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
