namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormFoodIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoodIn));
            this.tbQuanInStorage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.кодХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хранениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.хранениеTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.cbProdId = new System.Windows.Forms.ComboBox();
            this.mtbStorageName = new System.Windows.Forms.MaskedTextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорииПродуктаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категории_продуктаTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.Категории_продуктаTableAdapter();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПродуктаBindingSource)).BeginInit();
            this.panelUpper.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuanInStorage
            // 
            this.tbQuanInStorage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuanInStorage.Location = new System.Drawing.Point(330, 223);
            this.tbQuanInStorage.Name = "tbQuanInStorage";
            this.tbQuanInStorage.Size = new System.Drawing.Size(219, 27);
            this.tbQuanInStorage.TabIndex = 3;
            this.tbQuanInStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наимененование хранилища";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите продукт из списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Укажите срок годности продукта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество продукта в доставке";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(661, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Внести в базу";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dB_Thesis_ErmolaevDataSet
            // 
            this.dB_Thesis_ErmolaevDataSet.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.dgvStorage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStorage.AutoGenerateColumns = false;
            this.dgvStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодХраненияDataGridViewTextBoxColumn,
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn1,
            this.срокГодностиDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn});
            this.dgvStorage.DataSource = this.хранениеBindingSource;
            this.dgvStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorage.Location = new System.Drawing.Point(0, 0);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.dgvStorage.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStorage.Size = new System.Drawing.Size(661, 212);
            this.dgvStorage.TabIndex = 11;
            this.dgvStorage.TabStop = false;
            // 
            // кодХраненияDataGridViewTextBoxColumn
            // 
            this.кодХраненияDataGridViewTextBoxColumn.DataPropertyName = "Код хранения";
            this.кодХраненияDataGridViewTextBoxColumn.HeaderText = "Код хранения";
            this.кодХраненияDataGridViewTextBoxColumn.Name = "кодХраненияDataGridViewTextBoxColumn";
            // 
            // наименованиеОтделаХраненияDataGridViewTextBoxColumn
            // 
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.DataPropertyName = "Наименование отдела хранения";
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.HeaderText = "Наименование отдела хранения";
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.Name = "наименованиеОтделаХраненияDataGridViewTextBoxColumn";
            // 
            // кодПродуктаDataGridViewTextBoxColumn1
            // 
            this.кодПродуктаDataGridViewTextBoxColumn1.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn1.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn1.Name = "кодПродуктаDataGridViewTextBoxColumn1";
            // 
            // срокГодностиDataGridViewTextBoxColumn
            // 
            this.срокГодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.Name = "срокГодностиDataGridViewTextBoxColumn";
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            // 
            // хранениеBindingSource
            // 
            this.хранениеBindingSource.DataMember = "Хранение";
            this.хранениеBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // хранениеTableAdapter
            // 
            this.хранениеTableAdapter.ClearBeforeFill = true;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "";
            this.dtpExpDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(330, 180);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(219, 27);
            this.dtpExpDate.TabIndex = 2;
            // 
            // cbProdId
            // 
            this.cbProdId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProdId.FormattingEnabled = true;
            this.cbProdId.IntegralHeight = false;
            this.cbProdId.Location = new System.Drawing.Point(304, 137);
            this.cbProdId.Name = "cbProdId";
            this.cbProdId.Size = new System.Drawing.Size(245, 27);
            this.cbProdId.TabIndex = 1;
            // 
            // mtbStorageName
            // 
            this.mtbStorageName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbStorageName.Location = new System.Drawing.Point(313, 94);
            this.mtbStorageName.Mask = ">L00";
            this.mtbStorageName.Name = "mtbStorageName";
            this.mtbStorageName.Size = new System.Drawing.Size(236, 27);
            this.mtbStorageName.TabIndex = 0;
            this.mtbStorageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродуктаDataGridViewTextBoxColumn,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.продуктыBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(651, 271);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProducts.Size = new System.Drawing.Size(0, 0);
            this.dgvProducts.TabIndex = 15;
            this.dgvProducts.TabStop = false;
            // 
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.FillWeight = 45.5927F;
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
            // 
            // наименованиеПродуктаDataGridViewTextBoxColumn
            // 
            this.наименованиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.FillWeight = 102.9033F;
            this.наименованиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.Name = "наименованиеПродуктаDataGridViewTextBoxColumn";
            // 
            // кодКатегорииПродуктаDataGridViewTextBoxColumn
            // 
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.FillWeight = 151.504F;
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.HeaderText = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.Name = "кодКатегорииПродуктаDataGridViewTextBoxColumn";
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1,
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvCategories.DataSource = this.категорииПродуктаBindingSource;
            this.dgvCategories.Location = new System.Drawing.Point(651, 271);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCategories.Size = new System.Drawing.Size(0, 0);
            this.dgvCategories.TabIndex = 16;
            this.dgvCategories.TabStop = false;
            // 
            // кодКатегорииПродуктаDataGridViewTextBoxColumn1
            // 
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1.DataPropertyName = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1.HeaderText = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1.Name = "кодКатегорииПродуктаDataGridViewTextBoxColumn1";
            // 
            // наименованиеКатегорииПродуктаDataGridViewTextBoxColumn
            // 
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Наименование категории продукта";
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn.HeaderText = "Наименование категории продукта";
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn.Name = "наименованиеКатегорииПродуктаDataGridViewTextBoxColumn";
            // 
            // категорииПродуктаBindingSource
            // 
            this.категорииПродуктаBindingSource.DataMember = "Категории продукта";
            this.категорииПродуктаBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // категории_продуктаTableAdapter
            // 
            this.категории_продуктаTableAdapter.ClearBeforeFill = true;
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.dgvStorage);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(661, 212);
            this.panelUpper.TabIndex = 17;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.dgvProducts);
            this.panelMain.Controls.Add(this.dgvCategories);
            this.panelMain.Controls.Add(this.mtbStorageName);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.cbProdId);
            this.panelMain.Controls.Add(this.tbQuanInStorage);
            this.panelMain.Controls.Add(this.dtpExpDate);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 212);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(661, 282);
            this.panelMain.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(555, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Выберите из меню или укажите дату\r\nокончания срока годности данного продукта");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Название хранилища состоит из:\r\nбуквы русского алфавита и двух цифр\r\n(примеры наз" +
        "ваний: А00, Я99)\r\n");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите данные:";
            // 
            // FormFoodIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 494);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUpper);
            this.Name = "FormFoodIn";
            this.Text = "FormFoodIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFoodIn_FormClosing);
            this.Load += new System.EventHandler(this.FormFoodIn_Load);
            this.Resize += new System.EventHandler(this.FormFoodIn_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПродуктаBindingSource)).EndInit();
            this.panelUpper.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbQuanInStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.BindingSource хранениеBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter хранениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОтделаХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.ComboBox cbProdId;
        private System.Windows.Forms.MaskedTextBox mtbStorageName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.BindingSource категорииПродуктаBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.Категории_продуктаTableAdapter категории_продуктаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}