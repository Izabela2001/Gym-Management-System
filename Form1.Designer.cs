namespace Gym_Management_System
{
    partial class Fitnesso
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridView dataGridView_data;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fitnesso));
            this.fitnessoDataSet = new Gym_Management_System.FitnessoDataSet();
            this.fitnessoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1_Rezerwacje = new System.Windows.Forms.TabPage();
            this.num_Edit_Rezerwacja = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button_WyswietlanieRezerwacji = new System.Windows.Forms.Button();
            this.button_UsuwanieRezerwacji = new System.Windows.Forms.Button();
            this.button_EdytowanieRezerwacji = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_Add_ZaakceptowanaRezerwacja = new System.Windows.Forms.CheckBox();
            this.num_Add_IdKlientaRezerwacji = new System.Windows.Forms.NumericUpDown();
            this.dtPicker_Add_DataRezerwacji = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button_DodawanieRezerwacji = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cB_Add_WyborZajecRezerwacji = new System.Windows.Forms.ComboBox();
            this.tabPage2_Zajecia = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button_WyswietlanieZajec = new System.Windows.Forms.Button();
            this.button_UsuwanieZajec = new System.Windows.Forms.Button();
            this.button_EdytowanieZajec = new System.Windows.Forms.Button();
            this.gB_Add_dodwaniaZajec = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cB_Add_PoziomTrudnosci = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_DodawaniaZajec = new System.Windows.Forms.Button();
            this.dtPicker_Add_DataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.num_Add_CzasTrwaniaZajec = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cB_Add_TypZajec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker_Add_CzasRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.cB_Add_Prowadzacy = new System.Windows.Forms.ComboBox();
            this.num_Add_MaxUczestnikow = new System.Windows.Forms.NumericUpDown();
            this.num_Add_Zarezerwowane = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3_Platnosc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            dataGridView_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessoDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1_Rezerwacje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edit_Rezerwacja)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_IdKlientaRezerwacji)).BeginInit();
            this.tabPage2_Zajecia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gB_Add_dodwaniaZajec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_CzasTrwaniaZajec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_MaxUczestnikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_Zarezerwowane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_data
            // 
            dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_data.Location = new System.Drawing.Point(12, 18);
            dataGridView_data.Margin = new System.Windows.Forms.Padding(4);
            dataGridView_data.Name = "dataGridView_data";
            dataGridView_data.RowHeadersWidth = 51;
            dataGridView_data.Size = new System.Drawing.Size(499, 507);
            dataGridView_data.TabIndex = 18;
            dataGridView_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // fitnessoDataSet
            // 
            this.fitnessoDataSet.DataSetName = "FitnessoDataSet";
            this.fitnessoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnessoDataSetBindingSource
            // 
            this.fitnessoDataSetBindingSource.DataSource = this.fitnessoDataSet;
            this.fitnessoDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1_Rezerwacje);
            this.tabControl1.Controls.Add(this.tabPage2_Zajecia);
            this.tabControl1.Controls.Add(this.tabPage3_Platnosc);
            this.tabControl1.Location = new System.Drawing.Point(-1, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1_Rezerwacje
            // 
            this.tabPage1_Rezerwacje.Controls.Add(this.num_Edit_Rezerwacja);
            this.tabPage1_Rezerwacje.Controls.Add(this.label10);
            this.tabPage1_Rezerwacje.Controls.Add(this.button_WyswietlanieRezerwacji);
            this.tabPage1_Rezerwacje.Controls.Add(this.button_UsuwanieRezerwacji);
            this.tabPage1_Rezerwacje.Controls.Add(this.button_EdytowanieRezerwacji);
            this.tabPage1_Rezerwacje.Controls.Add(this.groupBox1);
            this.tabPage1_Rezerwacje.Controls.Add(dataGridView_data);
            this.tabPage1_Rezerwacje.Location = new System.Drawing.Point(4, 25);
            this.tabPage1_Rezerwacje.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1_Rezerwacje.Name = "tabPage1_Rezerwacje";
            this.tabPage1_Rezerwacje.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1_Rezerwacje.Size = new System.Drawing.Size(1115, 597);
            this.tabPage1_Rezerwacje.TabIndex = 0;
            this.tabPage1_Rezerwacje.Text = "Rezerwacje";
            this.tabPage1_Rezerwacje.UseVisualStyleBackColor = true;
            // 
            // num_Edit_Rezerwacja
            // 
            this.num_Edit_Rezerwacja.Location = new System.Drawing.Point(679, 231);
            this.num_Edit_Rezerwacja.Margin = new System.Windows.Forms.Padding(4);
            this.num_Edit_Rezerwacja.Name = "num_Edit_Rezerwacja";
            this.num_Edit_Rezerwacja.Size = new System.Drawing.Size(92, 22);
            this.num_Edit_Rezerwacja.TabIndex = 24;
            this.num_Edit_Rezerwacja.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Id rezerwacji:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button_WyswietlanieRezerwacji
            // 
            this.button_WyswietlanieRezerwacji.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_WyswietlanieRezerwacji.Location = new System.Drawing.Point(12, 533);
            this.button_WyswietlanieRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.button_WyswietlanieRezerwacji.Name = "button_WyswietlanieRezerwacji";
            this.button_WyswietlanieRezerwacji.Size = new System.Drawing.Size(499, 28);
            this.button_WyswietlanieRezerwacji.TabIndex = 22;
            this.button_WyswietlanieRezerwacji.Text = "Wyświetl rezerwacje";
            this.button_WyswietlanieRezerwacji.UseVisualStyleBackColor = false;
            this.button_WyswietlanieRezerwacji.Click += new System.EventHandler(this.button_WyswietlanieRezerwacji_Click);
            // 
            // button_UsuwanieRezerwacji
            // 
            this.button_UsuwanieRezerwacji.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_UsuwanieRezerwacji.Location = new System.Drawing.Point(577, 263);
            this.button_UsuwanieRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.button_UsuwanieRezerwacji.Name = "button_UsuwanieRezerwacji";
            this.button_UsuwanieRezerwacji.Size = new System.Drawing.Size(483, 28);
            this.button_UsuwanieRezerwacji.TabIndex = 21;
            this.button_UsuwanieRezerwacji.Text = "Usuń rezerwacje";
            this.button_UsuwanieRezerwacji.UseVisualStyleBackColor = false;
            // 
            // button_EdytowanieRezerwacji
            // 
            this.button_EdytowanieRezerwacji.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_EdytowanieRezerwacji.Location = new System.Drawing.Point(779, 228);
            this.button_EdytowanieRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.button_EdytowanieRezerwacji.Name = "button_EdytowanieRezerwacji";
            this.button_EdytowanieRezerwacji.Size = new System.Drawing.Size(281, 28);
            this.button_EdytowanieRezerwacji.TabIndex = 20;
            this.button_EdytowanieRezerwacji.Text = "Edytuj rezerwacje";
            this.button_EdytowanieRezerwacji.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_Add_ZaakceptowanaRezerwacja);
            this.groupBox1.Controls.Add(this.num_Add_IdKlientaRezerwacji);
            this.groupBox1.Controls.Add(this.dtPicker_Add_DataRezerwacji);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button_DodawanieRezerwacji);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cB_Add_WyborZajecRezerwacji);
            this.groupBox1.Location = new System.Drawing.Point(561, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(519, 202);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pole dodawania rezerwacji";
            // 
            // cB_Add_ZaakceptowanaRezerwacja
            // 
            this.cB_Add_ZaakceptowanaRezerwacja.AutoSize = true;
            this.cB_Add_ZaakceptowanaRezerwacja.Location = new System.Drawing.Point(21, 124);
            this.cB_Add_ZaakceptowanaRezerwacja.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Add_ZaakceptowanaRezerwacja.Name = "cB_Add_ZaakceptowanaRezerwacja";
            this.cB_Add_ZaakceptowanaRezerwacja.Size = new System.Drawing.Size(198, 20);
            this.cB_Add_ZaakceptowanaRezerwacja.TabIndex = 21;
            this.cB_Add_ZaakceptowanaRezerwacja.Text = "Rezerwacja zaakceptowana";
            this.cB_Add_ZaakceptowanaRezerwacja.UseVisualStyleBackColor = true;
            // 
            // num_Add_IdKlientaRezerwacji
            // 
            this.num_Add_IdKlientaRezerwacji.Location = new System.Drawing.Point(136, 92);
            this.num_Add_IdKlientaRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.num_Add_IdKlientaRezerwacji.Name = "num_Add_IdKlientaRezerwacji";
            this.num_Add_IdKlientaRezerwacji.Size = new System.Drawing.Size(87, 22);
            this.num_Add_IdKlientaRezerwacji.TabIndex = 20;
            // 
            // dtPicker_Add_DataRezerwacji
            // 
            this.dtPicker_Add_DataRezerwacji.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_Add_DataRezerwacji.Location = new System.Drawing.Point(136, 60);
            this.dtPicker_Add_DataRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.dtPicker_Add_DataRezerwacji.Name = "dtPicker_Add_DataRezerwacji";
            this.dtPicker_Add_DataRezerwacji.Size = new System.Drawing.Size(349, 22);
            this.dtPicker_Add_DataRezerwacji.TabIndex = 19;
            this.dtPicker_Add_DataRezerwacji.Value = new System.DateTime(2024, 5, 5, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Id klienta:";
            // 
            // button_DodawanieRezerwacji
            // 
            this.button_DodawanieRezerwacji.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_DodawanieRezerwacji.Location = new System.Drawing.Point(17, 158);
            this.button_DodawanieRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.button_DodawanieRezerwacji.Name = "button_DodawanieRezerwacji";
            this.button_DodawanieRezerwacji.Size = new System.Drawing.Size(483, 28);
            this.button_DodawanieRezerwacji.TabIndex = 15;
            this.button_DodawanieRezerwacji.Text = "Dodaj rezerwacje";
            this.button_DodawanieRezerwacji.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Data rezerwacji:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Zajęcia:";
            // 
            // cB_Add_WyborZajecRezerwacji
            // 
            this.cB_Add_WyborZajecRezerwacji.FormattingEnabled = true;
            this.cB_Add_WyborZajecRezerwacji.Location = new System.Drawing.Point(136, 27);
            this.cB_Add_WyborZajecRezerwacji.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Add_WyborZajecRezerwacji.Name = "cB_Add_WyborZajecRezerwacji";
            this.cB_Add_WyborZajecRezerwacji.Size = new System.Drawing.Size(349, 24);
            this.cB_Add_WyborZajecRezerwacji.TabIndex = 5;
            // 
            // tabPage2_Zajecia
            // 
            this.tabPage2_Zajecia.Controls.Add(this.numericUpDown1);
            this.tabPage2_Zajecia.Controls.Add(this.label13);
            this.tabPage2_Zajecia.Controls.Add(this.button_WyswietlanieZajec);
            this.tabPage2_Zajecia.Controls.Add(this.button_UsuwanieZajec);
            this.tabPage2_Zajecia.Controls.Add(this.button_EdytowanieZajec);
            this.tabPage2_Zajecia.Controls.Add(this.gB_Add_dodwaniaZajec);
            this.tabPage2_Zajecia.Controls.Add(this.dataGridView1);
            this.tabPage2_Zajecia.Location = new System.Drawing.Point(4, 25);
            this.tabPage2_Zajecia.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2_Zajecia.Name = "tabPage2_Zajecia";
            this.tabPage2_Zajecia.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2_Zajecia.Size = new System.Drawing.Size(1115, 597);
            this.tabPage2_Zajecia.TabIndex = 1;
            this.tabPage2_Zajecia.Text = "Zajęcia";
            this.tabPage2_Zajecia.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(633, 324);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 326);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Id zajęć:";
            // 
            // button_WyswietlanieZajec
            // 
            this.button_WyswietlanieZajec.BackColor = System.Drawing.Color.Turquoise;
            this.button_WyswietlanieZajec.Location = new System.Drawing.Point(12, 533);
            this.button_WyswietlanieZajec.Margin = new System.Windows.Forms.Padding(4);
            this.button_WyswietlanieZajec.Name = "button_WyswietlanieZajec";
            this.button_WyswietlanieZajec.Size = new System.Drawing.Size(499, 28);
            this.button_WyswietlanieZajec.TabIndex = 17;
            this.button_WyswietlanieZajec.Text = "Wyświetl zajęcia";
            this.button_WyswietlanieZajec.UseVisualStyleBackColor = false;
            // 
            // button_UsuwanieZajec
            // 
            this.button_UsuwanieZajec.BackColor = System.Drawing.Color.Turquoise;
            this.button_UsuwanieZajec.Location = new System.Drawing.Point(569, 356);
            this.button_UsuwanieZajec.Margin = new System.Windows.Forms.Padding(4);
            this.button_UsuwanieZajec.Name = "button_UsuwanieZajec";
            this.button_UsuwanieZajec.Size = new System.Drawing.Size(483, 28);
            this.button_UsuwanieZajec.TabIndex = 16;
            this.button_UsuwanieZajec.Text = "Usuń zajęcia";
            this.button_UsuwanieZajec.UseVisualStyleBackColor = false;
            // 
            // button_EdytowanieZajec
            // 
            this.button_EdytowanieZajec.BackColor = System.Drawing.Color.Turquoise;
            this.button_EdytowanieZajec.Location = new System.Drawing.Point(745, 320);
            this.button_EdytowanieZajec.Margin = new System.Windows.Forms.Padding(4);
            this.button_EdytowanieZajec.Name = "button_EdytowanieZajec";
            this.button_EdytowanieZajec.Size = new System.Drawing.Size(308, 28);
            this.button_EdytowanieZajec.TabIndex = 15;
            this.button_EdytowanieZajec.Text = "Edytuj zajęcia";
            this.button_EdytowanieZajec.UseVisualStyleBackColor = false;
            this.button_EdytowanieZajec.Click += new System.EventHandler(this.button_EdytowanieZajec_Click);
            // 
            // gB_Add_dodwaniaZajec
            // 
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label8);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.cB_Add_PoziomTrudnosci);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label14);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.button_DodawaniaZajec);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.dtPicker_Add_DataRozpoczecia);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.num_Add_CzasTrwaniaZajec);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label7);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.cB_Add_TypZajec);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label6);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label5);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label4);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label3);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.label2);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.dtPicker_Add_CzasRozpoczecia);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.cB_Add_Prowadzacy);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.num_Add_MaxUczestnikow);
            this.gB_Add_dodwaniaZajec.Controls.Add(this.num_Add_Zarezerwowane);
            this.gB_Add_dodwaniaZajec.Location = new System.Drawing.Point(552, 18);
            this.gB_Add_dodwaniaZajec.Margin = new System.Windows.Forms.Padding(4);
            this.gB_Add_dodwaniaZajec.Name = "gB_Add_dodwaniaZajec";
            this.gB_Add_dodwaniaZajec.Padding = new System.Windows.Forms.Padding(4);
            this.gB_Add_dodwaniaZajec.Size = new System.Drawing.Size(515, 294);
            this.gB_Add_dodwaniaZajec.TabIndex = 6;
            this.gB_Add_dodwaniaZajec.TabStop = false;
            this.gB_Add_dodwaniaZajec.Text = "Pole dodawania zajęć";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Poziom trudności:";
            // 
            // cB_Add_PoziomTrudnosci
            // 
            this.cB_Add_PoziomTrudnosci.FormattingEnabled = true;
            this.cB_Add_PoziomTrudnosci.Location = new System.Drawing.Point(235, 220);
            this.cB_Add_PoziomTrudnosci.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Add_PoziomTrudnosci.Name = "cB_Add_PoziomTrudnosci";
            this.cB_Add_PoziomTrudnosci.Size = new System.Drawing.Size(265, 24);
            this.cB_Add_PoziomTrudnosci.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "(w godzinach)";
            // 
            // button_DodawaniaZajec
            // 
            this.button_DodawaniaZajec.BackColor = System.Drawing.Color.Turquoise;
            this.button_DodawaniaZajec.Location = new System.Drawing.Point(17, 254);
            this.button_DodawaniaZajec.Margin = new System.Windows.Forms.Padding(4);
            this.button_DodawaniaZajec.Name = "button_DodawaniaZajec";
            this.button_DodawaniaZajec.Size = new System.Drawing.Size(483, 28);
            this.button_DodawaniaZajec.TabIndex = 15;
            this.button_DodawaniaZajec.Text = "Dodaj zajęcia";
            this.button_DodawaniaZajec.UseVisualStyleBackColor = false;
            this.button_DodawaniaZajec.Click += new System.EventHandler(this.button_DodawaniaZajec_Click);
            // 
            // dtPicker_Add_DataRozpoczecia
            // 
            this.dtPicker_Add_DataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_Add_DataRozpoczecia.Location = new System.Drawing.Point(235, 23);
            this.dtPicker_Add_DataRozpoczecia.Margin = new System.Windows.Forms.Padding(4);
            this.dtPicker_Add_DataRozpoczecia.Name = "dtPicker_Add_DataRozpoczecia";
            this.dtPicker_Add_DataRozpoczecia.Size = new System.Drawing.Size(115, 22);
            this.dtPicker_Add_DataRozpoczecia.TabIndex = 14;
            this.dtPicker_Add_DataRozpoczecia.ValueChanged += new System.EventHandler(this.dateTimePicker_DataRozpoczecia_ValueChanged);
            // 
            // num_Add_CzasTrwaniaZajec
            // 
            this.num_Add_CzasTrwaniaZajec.Location = new System.Drawing.Point(235, 55);
            this.num_Add_CzasTrwaniaZajec.Margin = new System.Windows.Forms.Padding(4);
            this.num_Add_CzasTrwaniaZajec.Name = "num_Add_CzasTrwaniaZajec";
            this.num_Add_CzasTrwaniaZajec.Size = new System.Drawing.Size(79, 22);
            this.num_Add_CzasTrwaniaZajec.TabIndex = 13;
            this.num_Add_CzasTrwaniaZajec.ValueChanged += new System.EventHandler(this.numericUpDown_CzasTrwaniaZajec_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Typ zajęć:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cB_Add_TypZajec
            // 
            this.cB_Add_TypZajec.FormattingEnabled = true;
            this.cB_Add_TypZajec.Location = new System.Drawing.Point(235, 185);
            this.cB_Add_TypZajec.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Add_TypZajec.Name = "cB_Add_TypZajec";
            this.cB_Add_TypZajec.Size = new System.Drawing.Size(265, 24);
            this.cB_Add_TypZajec.TabIndex = 11;
            this.cB_Add_TypZajec.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypZajec_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Osoba prowadząca zajęcia:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Liczba zarezerwowanych miejsc:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maksymalna liczba uczestników:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czas trwania zajęć:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data i czas rozpoczęcia zajęć:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtPicker_Add_CzasRozpoczecia
            // 
            this.dtPicker_Add_CzasRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker_Add_CzasRozpoczecia.Location = new System.Drawing.Point(359, 23);
            this.dtPicker_Add_CzasRozpoczecia.Margin = new System.Windows.Forms.Padding(4);
            this.dtPicker_Add_CzasRozpoczecia.Name = "dtPicker_Add_CzasRozpoczecia";
            this.dtPicker_Add_CzasRozpoczecia.ShowUpDown = true;
            this.dtPicker_Add_CzasRozpoczecia.Size = new System.Drawing.Size(96, 22);
            this.dtPicker_Add_CzasRozpoczecia.TabIndex = 1;
            this.dtPicker_Add_CzasRozpoczecia.ValueChanged += new System.EventHandler(this.dateTimePicker_CzasRozpoczecia_ValueChanged);
            // 
            // cB_Add_Prowadzacy
            // 
            this.cB_Add_Prowadzacy.FormattingEnabled = true;
            this.cB_Add_Prowadzacy.Location = new System.Drawing.Point(235, 151);
            this.cB_Add_Prowadzacy.Margin = new System.Windows.Forms.Padding(4);
            this.cB_Add_Prowadzacy.Name = "cB_Add_Prowadzacy";
            this.cB_Add_Prowadzacy.Size = new System.Drawing.Size(265, 24);
            this.cB_Add_Prowadzacy.TabIndex = 5;
            this.cB_Add_Prowadzacy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // num_Add_MaxUczestnikow
            // 
            this.num_Add_MaxUczestnikow.Location = new System.Drawing.Point(235, 87);
            this.num_Add_MaxUczestnikow.Margin = new System.Windows.Forms.Padding(4);
            this.num_Add_MaxUczestnikow.Name = "num_Add_MaxUczestnikow";
            this.num_Add_MaxUczestnikow.Size = new System.Drawing.Size(79, 22);
            this.num_Add_MaxUczestnikow.TabIndex = 4;
            this.num_Add_MaxUczestnikow.ValueChanged += new System.EventHandler(this.numericUpDown_MaxUczestnikow_ValueChanged);
            // 
            // num_Add_Zarezerwowane
            // 
            this.num_Add_Zarezerwowane.Location = new System.Drawing.Point(235, 119);
            this.num_Add_Zarezerwowane.Margin = new System.Windows.Forms.Padding(4);
            this.num_Add_Zarezerwowane.Name = "num_Add_Zarezerwowane";
            this.num_Add_Zarezerwowane.Size = new System.Drawing.Size(79, 22);
            this.num_Add_Zarezerwowane.TabIndex = 3;
            this.num_Add_Zarezerwowane.ValueChanged += new System.EventHandler(this.numericUpDown_Zarezerwowane_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(499, 507);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage3_Platnosc
            // 
            this.tabPage3_Platnosc.Location = new System.Drawing.Point(4, 25);
            this.tabPage3_Platnosc.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3_Platnosc.Name = "tabPage3_Platnosc";
            this.tabPage3_Platnosc.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3_Platnosc.Size = new System.Drawing.Size(1115, 597);
            this.tabPage3_Platnosc.TabIndex = 2;
            this.tabPage3_Platnosc.Text = "Płatności";
            this.tabPage3_Platnosc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fitnesso                                                          ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fitnesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fitnesso";
            this.Text = "Fitnesso";
            ((System.ComponentModel.ISupportInitialize)(dataGridView_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessoDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1_Rezerwacje.ResumeLayout(false);
            this.tabPage1_Rezerwacje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edit_Rezerwacja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_IdKlientaRezerwacji)).EndInit();
            this.tabPage2_Zajecia.ResumeLayout(false);
            this.tabPage2_Zajecia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gB_Add_dodwaniaZajec.ResumeLayout(false);
            this.gB_Add_dodwaniaZajec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_CzasTrwaniaZajec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_MaxUczestnikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Add_Zarezerwowane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnessoDataSet fitnessoDataSet;
        private System.Windows.Forms.BindingSource fitnessoDataSetBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_Rezerwacje;
        private System.Windows.Forms.TabPage tabPage2_Zajecia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3_Platnosc;
        private System.Windows.Forms.GroupBox gB_Add_dodwaniaZajec;
        private System.Windows.Forms.DateTimePicker dtPicker_Add_CzasRozpoczecia;
        private System.Windows.Forms.ComboBox cB_Add_Prowadzacy;
        private System.Windows.Forms.NumericUpDown num_Add_MaxUczestnikow;
        private System.Windows.Forms.NumericUpDown num_Add_Zarezerwowane;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cB_Add_TypZajec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_Add_CzasTrwaniaZajec;
        private System.Windows.Forms.DateTimePicker dtPicker_Add_DataRozpoczecia;
        private System.Windows.Forms.Button button_DodawaniaZajec;
        private System.Windows.Forms.Button button_EdytowanieZajec;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_UsuwanieZajec;
        private System.Windows.Forms.Button button_WyswietlanieZajec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cB_Add_PoziomTrudnosci;
        private System.Windows.Forms.Button button_WyswietlanieRezerwacji;
        private System.Windows.Forms.Button button_UsuwanieRezerwacji;
        private System.Windows.Forms.Button button_EdytowanieRezerwacji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_DodawanieRezerwacji;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cB_Add_WyborZajecRezerwacji;
        private System.Windows.Forms.CheckBox cB_Add_ZaakceptowanaRezerwacja;
        private System.Windows.Forms.NumericUpDown num_Add_IdKlientaRezerwacji;
        private System.Windows.Forms.DateTimePicker dtPicker_Add_DataRezerwacji;
        private System.Windows.Forms.NumericUpDown num_Edit_Rezerwacja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
    }
}

