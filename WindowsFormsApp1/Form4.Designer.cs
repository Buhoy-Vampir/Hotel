namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортLabel;
            System.Windows.Forms.Label примечаниеLabel;
            System.Windows.Forms.Label номерLabel;
            System.Windows.Forms.Label код_пропускаLabel;
            System.Windows.Forms.Label дата_прибытияLabel;
            System.Windows.Forms.Label дата_отбытияLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label примечаниеLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_registration_window = new System.Windows.Forms.Label();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new WindowsFormsApp1.HotelDataSet();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортTextBox = new System.Windows.Forms.TextBox();
            this.примечаниеTextBox = new System.Windows.Forms.TextBox();
            this.номерTextBox = new System.Windows.Forms.TextBox();
            this.броньBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_пропускаTextBox = new System.Windows.Forms.TextBox();
            this.дата_прибытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_отбытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.примечаниеTextBox1 = new System.Windows.Forms.TextBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_num12 = new System.Windows.Forms.Button();
            this.button_num8 = new System.Windows.Forms.Button();
            this.button_num9 = new System.Windows.Forms.Button();
            this.button_num7 = new System.Windows.Forms.Button();
            this.button_num11 = new System.Windows.Forms.Button();
            this.button_num5 = new System.Windows.Forms.Button();
            this.button_num6 = new System.Windows.Forms.Button();
            this.button_num4 = new System.Windows.Forms.Button();
            this.button_num10 = new System.Windows.Forms.Button();
            this.button_num2 = new System.Windows.Forms.Button();
            this.button_num3 = new System.Windows.Forms.Button();
            this.button_num1 = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.клиентTableAdapter = new WindowsFormsApp1.HotelDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.HotelDataSetTableAdapters.TableAdapterManager();
            this.броньTableAdapter = new WindowsFormsApp1.HotelDataSetTableAdapters.БроньTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортLabel = new System.Windows.Forms.Label();
            примечаниеLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            код_пропускаLabel = new System.Windows.Forms.Label();
            дата_прибытияLabel = new System.Windows.Forms.Label();
            дата_отбытияLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            примечаниеLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(6, 22);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 21;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(6, 48);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 23;
            полLabel.Text = "Пол:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(6, 75);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 25;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(6, 100);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 27;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(6, 126);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 29;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортLabel
            // 
            паспортLabel.AutoSize = true;
            паспортLabel.Location = new System.Drawing.Point(6, 152);
            паспортLabel.Name = "паспортLabel";
            паспортLabel.Size = new System.Drawing.Size(53, 13);
            паспортLabel.TabIndex = 31;
            паспортLabel.Text = "Паспорт:";
            // 
            // примечаниеLabel
            // 
            примечаниеLabel.AutoSize = true;
            примечаниеLabel.Location = new System.Drawing.Point(6, 178);
            примечаниеLabel.Name = "примечаниеLabel";
            примечаниеLabel.Size = new System.Drawing.Size(73, 13);
            примечаниеLabel.TabIndex = 33;
            примечаниеLabel.Text = "Примечание:";
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.Location = new System.Drawing.Point(6, 25);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(44, 13);
            номерLabel.TabIndex = 38;
            номерLabel.Text = "Номер:";
            // 
            // код_пропускаLabel
            // 
            код_пропускаLabel.AutoSize = true;
            код_пропускаLabel.Location = new System.Drawing.Point(6, 51);
            код_пропускаLabel.Name = "код_пропускаLabel";
            код_пропускаLabel.Size = new System.Drawing.Size(79, 13);
            код_пропускаLabel.TabIndex = 42;
            код_пропускаLabel.Text = "Код пропуска:";
            // 
            // дата_прибытияLabel
            // 
            дата_прибытияLabel.AutoSize = true;
            дата_прибытияLabel.Location = new System.Drawing.Point(6, 78);
            дата_прибытияLabel.Name = "дата_прибытияLabel";
            дата_прибытияLabel.Size = new System.Drawing.Size(88, 13);
            дата_прибытияLabel.TabIndex = 44;
            дата_прибытияLabel.Text = "Дата прибытия:";
            // 
            // дата_отбытияLabel
            // 
            дата_отбытияLabel.AutoSize = true;
            дата_отбытияLabel.Location = new System.Drawing.Point(6, 104);
            дата_отбытияLabel.Name = "дата_отбытияLabel";
            дата_отбытияLabel.Size = new System.Drawing.Size(81, 13);
            дата_отбытияLabel.TabIndex = 46;
            дата_отбытияLabel.Text = "Дата отбытия:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(6, 129);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 48;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // примечаниеLabel1
            // 
            примечаниеLabel1.AutoSize = true;
            примечаниеLabel1.Location = new System.Drawing.Point(6, 155);
            примечаниеLabel1.Name = "примечаниеLabel1";
            примечаниеLabel1.Size = new System.Drawing.Size(73, 13);
            примечаниеLabel1.TabIndex = 50;
            примечаниеLabel1.Text = "Примечание:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lb_registration_window);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 22);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(730, 1);
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
            this.lb_registration_window.Size = new System.Drawing.Size(145, 16);
            this.lb_registration_window.TabIndex = 7;
            this.lb_registration_window.Text = "Офромление номера";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(101, 19);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 22;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(101, 45);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 20);
            this.полTextBox.TabIndex = 24;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(101, 71);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 26;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(101, 97);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 20);
            this.адресTextBox.TabIndex = 28;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(101, 123);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 20);
            this.телефонTextBox.TabIndex = 30;
            // 
            // паспортTextBox
            // 
            this.паспортTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Паспорт", true));
            this.паспортTextBox.Location = new System.Drawing.Point(101, 149);
            this.паспортTextBox.Name = "паспортTextBox";
            this.паспортTextBox.Size = new System.Drawing.Size(200, 20);
            this.паспортTextBox.TabIndex = 32;
            // 
            // примечаниеTextBox
            // 
            this.примечаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Примечание", true));
            this.примечаниеTextBox.Location = new System.Drawing.Point(101, 175);
            this.примечаниеTextBox.Name = "примечаниеTextBox";
            this.примечаниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.примечаниеTextBox.TabIndex = 34;
            // 
            // номерTextBox
            // 
            this.номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньBindingSource, "Номер", true));
            this.номерTextBox.Location = new System.Drawing.Point(102, 22);
            this.номерTextBox.Name = "номерTextBox";
            this.номерTextBox.Size = new System.Drawing.Size(200, 20);
            this.номерTextBox.TabIndex = 39;
            // 
            // броньBindingSource
            // 
            this.броньBindingSource.DataMember = "Бронь";
            this.броньBindingSource.DataSource = this.hotelDataSet;
            // 
            // код_пропускаTextBox
            // 
            this.код_пропускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньBindingSource, "Код пропуска", true));
            this.код_пропускаTextBox.Location = new System.Drawing.Point(102, 48);
            this.код_пропускаTextBox.Name = "код_пропускаTextBox";
            this.код_пропускаTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_пропускаTextBox.TabIndex = 43;
            // 
            // дата_прибытияDateTimePicker
            // 
            this.дата_прибытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.броньBindingSource, "Дата прибытия", true));
            this.дата_прибытияDateTimePicker.Location = new System.Drawing.Point(102, 74);
            this.дата_прибытияDateTimePicker.Name = "дата_прибытияDateTimePicker";
            this.дата_прибытияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_прибытияDateTimePicker.TabIndex = 45;
            // 
            // дата_отбытияDateTimePicker
            // 
            this.дата_отбытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.броньBindingSource, "Дата отбытия", true));
            this.дата_отбытияDateTimePicker.Location = new System.Drawing.Point(102, 100);
            this.дата_отбытияDateTimePicker.Name = "дата_отбытияDateTimePicker";
            this.дата_отбытияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_отбытияDateTimePicker.TabIndex = 47;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(102, 126);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.стоимостьTextBox.TabIndex = 49;
            // 
            // примечаниеTextBox1
            // 
            this.примечаниеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.броньBindingSource, "Примечание", true));
            this.примечаниеTextBox1.Location = new System.Drawing.Point(102, 152);
            this.примечаниеTextBox1.Name = "примечаниеTextBox1";
            this.примечаниеTextBox1.Size = new System.Drawing.Size(200, 20);
            this.примечаниеTextBox1.TabIndex = 51;
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(339, 357);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(126, 38);
            this.button_calc.TabIndex = 52;
            this.button_calc.Text = "Расчитать стоимость";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.примечаниеTextBox);
            this.groupBox1.Controls.Add(примечаниеLabel);
            this.groupBox1.Controls.Add(this.паспортTextBox);
            this.groupBox1.Controls.Add(паспортLabel);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.groupBox1.Controls.Add(дата_рожденияLabel);
            this.groupBox1.Controls.Add(this.полTextBox);
            this.groupBox1.Controls.Add(полLabel);
            this.groupBox1.Controls.Add(this.фИОTextBox);
            this.groupBox1.Controls.Add(фИОLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 205);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма заполнения информации о клиенте";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.примечаниеTextBox1);
            this.groupBox2.Controls.Add(примечаниеLabel1);
            this.groupBox2.Controls.Add(this.стоимостьTextBox);
            this.groupBox2.Controls.Add(стоимостьLabel);
            this.groupBox2.Controls.Add(this.дата_отбытияDateTimePicker);
            this.groupBox2.Controls.Add(дата_отбытияLabel);
            this.groupBox2.Controls.Add(номерLabel);
            this.groupBox2.Controls.Add(this.дата_прибытияDateTimePicker);
            this.groupBox2.Controls.Add(this.номерTextBox);
            this.groupBox2.Controls.Add(дата_прибытияLabel);
            this.groupBox2.Controls.Add(this.код_пропускаTextBox);
            this.groupBox2.Controls.Add(код_пропускаLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 180);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Форма оформления номера";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_num12);
            this.groupBox3.Controls.Add(this.button_num8);
            this.groupBox3.Controls.Add(this.button_num9);
            this.groupBox3.Controls.Add(this.button_num7);
            this.groupBox3.Controls.Add(this.button_num11);
            this.groupBox3.Controls.Add(this.button_num5);
            this.groupBox3.Controls.Add(this.button_num6);
            this.groupBox3.Controls.Add(this.button_num4);
            this.groupBox3.Controls.Add(this.button_num10);
            this.groupBox3.Controls.Add(this.button_num2);
            this.groupBox3.Controls.Add(this.button_num3);
            this.groupBox3.Controls.Add(this.button_num1);
            this.groupBox3.Location = new System.Drawing.Point(367, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 263);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о номерах ------- Зеленый -свободен ---- Красный - занят";
            // 
            // button_num12
            // 
            this.button_num12.Location = new System.Drawing.Point(276, 182);
            this.button_num12.Name = "button_num12";
            this.button_num12.Size = new System.Drawing.Size(80, 75);
            this.button_num12.TabIndex = 11;
            this.button_num12.Tag = "12";
            this.button_num12.Text = "Номер 12 Вип";
            this.button_num12.UseVisualStyleBackColor = true;
            // 
            // button_num8
            // 
            this.button_num8.Location = new System.Drawing.Point(190, 102);
            this.button_num8.Name = "button_num8";
            this.button_num8.Size = new System.Drawing.Size(80, 75);
            this.button_num8.TabIndex = 10;
            this.button_num8.Tag = "8";
            this.button_num8.Text = "Номер 8 Комфорт";
            this.button_num8.UseVisualStyleBackColor = true;
            // 
            // button_num9
            // 
            this.button_num9.Location = new System.Drawing.Point(190, 182);
            this.button_num9.Name = "button_num9";
            this.button_num9.Size = new System.Drawing.Size(80, 75);
            this.button_num9.TabIndex = 9;
            this.button_num9.Tag = "9";
            this.button_num9.Text = "Номер 9 Комфорт";
            this.button_num9.UseVisualStyleBackColor = true;
            // 
            // button_num7
            // 
            this.button_num7.Location = new System.Drawing.Point(190, 21);
            this.button_num7.Name = "button_num7";
            this.button_num7.Size = new System.Drawing.Size(80, 75);
            this.button_num7.TabIndex = 8;
            this.button_num7.Tag = "7";
            this.button_num7.Text = "Номер 7 Комфорт";
            this.button_num7.UseVisualStyleBackColor = true;
            // 
            // button_num11
            // 
            this.button_num11.Location = new System.Drawing.Point(276, 102);
            this.button_num11.Name = "button_num11";
            this.button_num11.Size = new System.Drawing.Size(80, 75);
            this.button_num11.TabIndex = 7;
            this.button_num11.Tag = "11";
            this.button_num11.Text = "Номер 11 Вип";
            this.button_num11.UseVisualStyleBackColor = true;
            // 
            // button_num5
            // 
            this.button_num5.Location = new System.Drawing.Point(104, 101);
            this.button_num5.Name = "button_num5";
            this.button_num5.Size = new System.Drawing.Size(80, 75);
            this.button_num5.TabIndex = 6;
            this.button_num5.Tag = "5";
            this.button_num5.Text = "Номер 5 Эконом";
            this.button_num5.UseVisualStyleBackColor = true;
            // 
            // button_num6
            // 
            this.button_num6.Location = new System.Drawing.Point(104, 182);
            this.button_num6.Name = "button_num6";
            this.button_num6.Size = new System.Drawing.Size(80, 75);
            this.button_num6.TabIndex = 5;
            this.button_num6.Tag = "6";
            this.button_num6.Text = "Номер 6 Эконом";
            this.button_num6.UseVisualStyleBackColor = true;
            // 
            // button_num4
            // 
            this.button_num4.Location = new System.Drawing.Point(104, 21);
            this.button_num4.Name = "button_num4";
            this.button_num4.Size = new System.Drawing.Size(80, 75);
            this.button_num4.TabIndex = 4;
            this.button_num4.Tag = "4";
            this.button_num4.Text = "Номер 4 Эконом";
            this.button_num4.UseVisualStyleBackColor = true;
            // 
            // button_num10
            // 
            this.button_num10.Location = new System.Drawing.Point(276, 22);
            this.button_num10.Name = "button_num10";
            this.button_num10.Size = new System.Drawing.Size(80, 75);
            this.button_num10.TabIndex = 3;
            this.button_num10.Tag = "10";
            this.button_num10.Text = "Номер 10 Комфорт";
            this.button_num10.UseVisualStyleBackColor = true;
            // 
            // button_num2
            // 
            this.button_num2.Location = new System.Drawing.Point(18, 102);
            this.button_num2.Name = "button_num2";
            this.button_num2.Size = new System.Drawing.Size(80, 75);
            this.button_num2.TabIndex = 2;
            this.button_num2.Tag = "2";
            this.button_num2.Text = "Номер 2 Эконом";
            this.button_num2.UseVisualStyleBackColor = true;
            // 
            // button_num3
            // 
            this.button_num3.Location = new System.Drawing.Point(18, 182);
            this.button_num3.Name = "button_num3";
            this.button_num3.Size = new System.Drawing.Size(80, 75);
            this.button_num3.TabIndex = 1;
            this.button_num3.Tag = "3";
            this.button_num3.Text = "Номер 3 Эконом";
            this.button_num3.UseVisualStyleBackColor = true;
            // 
            // button_num1
            // 
            this.button_num1.Location = new System.Drawing.Point(18, 21);
            this.button_num1.Name = "button_num1";
            this.button_num1.Size = new System.Drawing.Size(80, 75);
            this.button_num1.TabIndex = 0;
            this.button_num1.Tag = "1";
            this.button_num1.Text = "Номер 1 Эконом";
            this.button_num1.UseVisualStyleBackColor = true;
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_select.Location = new System.Drawing.Point(597, 352);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(126, 49);
            this.button_select.TabIndex = 56;
            this.button_select.Text = "Продолжить";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БроньTableAdapter = this.броньTableAdapter;
            this.tableAdapterManager.Доп_услугиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.Оказанные_услугиTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПропускTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.УборкаTableAdapter = null;
            // 
            // броньTableAdapter
            // 
            this.броньTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 57;
            this.button1.Text = "Распечатать документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.броньBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_registration_window;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private HotelDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.БроньTableAdapter броньTableAdapter;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортTextBox;
        private System.Windows.Forms.TextBox примечаниеTextBox;
        private System.Windows.Forms.BindingSource броньBindingSource;
        private System.Windows.Forms.TextBox номерTextBox;
        private System.Windows.Forms.TextBox код_пропускаTextBox;
        private System.Windows.Forms.DateTimePicker дата_прибытияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_отбытияDateTimePicker;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox примечаниеTextBox1;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_num12;
        private System.Windows.Forms.Button button_num8;
        private System.Windows.Forms.Button button_num9;
        private System.Windows.Forms.Button button_num7;
        private System.Windows.Forms.Button button_num11;
        private System.Windows.Forms.Button button_num5;
        private System.Windows.Forms.Button button_num6;
        private System.Windows.Forms.Button button_num4;
        private System.Windows.Forms.Button button_num10;
        private System.Windows.Forms.Button button_num2;
        private System.Windows.Forms.Button button_num3;
        private System.Windows.Forms.Button button_num1;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}