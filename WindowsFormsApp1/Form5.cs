using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5(string param)
        {
            InitializeComponent();
            label1.Text = "Сотрудник: " + param;
            panel1.MouseDown += new MouseEventHandler(moving_MouseDown);
            lb_cleaning_window.MouseDown += new MouseEventHandler(moving_MouseDown);
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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Уборка". При необходимости она может быть перемещена или удалена.
            this.уборкаTableAdapter.Fill(this.hotelDataSet.Уборка);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
