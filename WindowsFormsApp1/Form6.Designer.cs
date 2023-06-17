namespace WindowsFormsApp1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_услугиLabel;
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label примечаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.hotelDataSet = new WindowsFormsApp1.HotelDataSet();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new WindowsFormsApp1.HotelDataSetTableAdapters.ПользователиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.HotelDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_registration_window = new System.Windows.Forms.Label();
            this.оказанные_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оказанные_услугиTableAdapter = new WindowsFormsApp1.HotelDataSetTableAdapters.Оказанные_услугиTableAdapter();
            this.код_услугиTextBox = new System.Windows.Forms.TextBox();
            this.код_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.примечаниеTextBox = new System.Windows.Forms.TextBox();
            this.доп_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доп_услугиTableAdapter = new WindowsFormsApp1.HotelDataSetTableAdapters.Доп_услугиTableAdapter();
            this.доп_услугиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            код_услугиLabel = new System.Windows.Forms.Label();
            код_клиентаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            примечаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оказанные_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доп_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доп_услугиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_услугиLabel
            // 
            код_услугиLabel.AutoSize = true;
            код_услугиLabel.Location = new System.Drawing.Point(12, 35);
            код_услугиLabel.Name = "код_услугиLabel";
            код_услугиLabel.Size = new System.Drawing.Size(65, 13);
            код_услугиLabel.TabIndex = 17;
            код_услугиLabel.Text = "Код услуги:";
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Location = new System.Drawing.Point(12, 61);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(73, 13);
            код_клиентаLabel.TabIndex = 19;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(12, 87);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 21;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // примечаниеLabel
            // 
            примечаниеLabel.AutoSize = true;
            примечаниеLabel.Location = new System.Drawing.Point(12, 113);
            примечаниеLabel.Name = "примечаниеLabel";
            примечаниеLabel.Size = new System.Drawing.Size(73, 13);
            примечаниеLabel.TabIndex = 23;
            примечаниеLabel.Text = "Примечание:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.hotelDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БроньTableAdapter = null;
            this.tableAdapterManager.Доп_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.Оказанные_услугиTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager.ПропускTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.УборкаTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(38, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Завершить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lb_registration_window);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 22);
            this.panel1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(645, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 19);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_registration_window
            // 
            this.lb_registration_window.AutoSize = true;
            this.lb_registration_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_registration_window.Location = new System.Drawing.Point(2, 2);
            this.lb_registration_window.Name = "lb_registration_window";
            this.lb_registration_window.Size = new System.Drawing.Size(315, 16);
            this.lb_registration_window.TabIndex = 7;
            this.lb_registration_window.Text = "Форма для оформления дополнительных услуг";
            // 
            // оказанные_услугиBindingSource
            // 
            this.оказанные_услугиBindingSource.DataMember = "Оказанные_услуги";
            this.оказанные_услугиBindingSource.DataSource = this.hotelDataSet;
            // 
            // оказанные_услугиTableAdapter
            // 
            this.оказанные_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // код_услугиTextBox
            // 
            this.код_услугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оказанные_услугиBindingSource, "Код услуги", true));
            this.код_услугиTextBox.Location = new System.Drawing.Point(108, 32);
            this.код_услугиTextBox.Name = "код_услугиTextBox";
            this.код_услугиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_услугиTextBox.TabIndex = 18;
            // 
            // код_клиентаTextBox
            // 
            this.код_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оказанные_услугиBindingSource, "Код клиента", true));
            this.код_клиентаTextBox.Location = new System.Drawing.Point(108, 58);
            this.код_клиентаTextBox.Name = "код_клиентаTextBox";
            this.код_клиентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_клиентаTextBox.TabIndex = 20;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оказанные_услугиBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(108, 84);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сотрудникаTextBox.TabIndex = 22;
            // 
            // примечаниеTextBox
            // 
            this.примечаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оказанные_услугиBindingSource, "Примечание", true));
            this.примечаниеTextBox.Location = new System.Drawing.Point(108, 110);
            this.примечаниеTextBox.Name = "примечаниеTextBox";
            this.примечаниеTextBox.Size = new System.Drawing.Size(100, 20);
            this.примечаниеTextBox.TabIndex = 24;
            // 
            // доп_услугиBindingSource
            // 
            this.доп_услугиBindingSource.DataMember = "Доп_услуги";
            this.доп_услугиBindingSource.DataSource = this.hotelDataSet;
            // 
            // доп_услугиTableAdapter
            // 
            this.доп_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // доп_услугиDataGridView
            // 
            this.доп_услугиDataGridView.AutoGenerateColumns = false;
            this.доп_услугиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.доп_услугиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.доп_услугиDataGridView.DataSource = this.доп_услугиBindingSource;
            this.доп_услугиDataGridView.Location = new System.Drawing.Point(214, 28);
            this.доп_услугиDataGridView.Name = "доп_услугиDataGridView";
            this.доп_услугиDataGridView.Size = new System.Drawing.Size(448, 220);
            this.доп_услугиDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код услуги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код услуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Примечание";
            this.dataGridViewTextBoxColumn4.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(38, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "Добавить Доп_услугу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.доп_услугиDataGridView);
            this.Controls.Add(код_услугиLabel);
            this.Controls.Add(this.код_услугиTextBox);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(this.код_клиентаTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(примечаниеLabel);
            this.Controls.Add(this.примечаниеTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оказанные_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доп_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доп_услугиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        public System.Windows.Forms.BindingSource пользователиBindingSource;
        public HotelDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        public HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_registration_window;
        private System.Windows.Forms.BindingSource оказанные_услугиBindingSource;
        private HotelDataSetTableAdapters.Оказанные_услугиTableAdapter оказанные_услугиTableAdapter;
        private System.Windows.Forms.TextBox код_услугиTextBox;
        private System.Windows.Forms.TextBox код_клиентаTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox примечаниеTextBox;
        private System.Windows.Forms.BindingSource доп_услугиBindingSource;
        private HotelDataSetTableAdapters.Доп_услугиTableAdapter доп_услугиTableAdapter;
        private System.Windows.Forms.DataGridView доп_услугиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button2;
    }
}