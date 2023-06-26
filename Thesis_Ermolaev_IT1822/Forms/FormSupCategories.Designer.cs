namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormSupCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.кодПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.dgvRange = new System.Windows.Forms.DataGridView();
            this.кодАссортиментаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаЕдиницуТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемВУпаковкеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ассортиментыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.кодПоставщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бИКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетныйСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ассортиментыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.АссортиментыTableAdapter();
            this.продуктыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter();
            this.поставщикиTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПоставщикиTableAdapter();
            this.cbSelectedCategory = new System.Windows.Forms.ComboBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорииПродуктаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категории_продуктаTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.Категории_продуктаTableAdapter();
            this.dgvSupByCat = new System.Windows.Forms.DataGridView();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelText = new System.Windows.Forms.Label();
            this.panelChooseCat = new System.Windows.Forms.Panel();
            this.panelDgvSupByCat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ассортиментыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПродуктаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupByCat)).BeginInit();
            this.panelChooseCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродуктаDataGridViewTextBoxColumn1,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.продуктыBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(660, 424);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Size = new System.Drawing.Size(0, 0);
            this.dgvProducts.TabIndex = 0;
            // 
            // кодПродуктаDataGridViewTextBoxColumn1
            // 
            this.кодПродуктаDataGridViewTextBoxColumn1.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn1.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn1.Name = "кодПродуктаDataGridViewTextBoxColumn1";
            // 
            // наименованиеПродуктаDataGridViewTextBoxColumn
            // 
            this.наименованиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.Name = "наименованиеПродуктаDataGridViewTextBoxColumn";
            // 
            // кодКатегорииПродуктаDataGridViewTextBoxColumn
            // 
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.HeaderText = "Код категории продукта";
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn.Name = "кодКатегорииПродуктаDataGridViewTextBoxColumn";
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // dB_Thesis_ErmolaevDataSet
            // 
            this.dB_Thesis_ErmolaevDataSet.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvRange
            // 
            this.dgvRange.AllowUserToAddRows = false;
            this.dgvRange.AllowUserToDeleteRows = false;
            this.dgvRange.AllowUserToOrderColumns = true;
            this.dgvRange.AllowUserToResizeColumns = false;
            this.dgvRange.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvRange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRange.AutoGenerateColumns = false;
            this.dgvRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАссортиментаDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn,
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.ценаЗаЕдиницуТовараDataGridViewTextBoxColumn,
            this.объемВУпаковкеDataGridViewTextBoxColumn});
            this.dgvRange.DataSource = this.ассортиментыBindingSource;
            this.dgvRange.Location = new System.Drawing.Point(660, 424);
            this.dgvRange.Name = "dgvRange";
            this.dgvRange.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvRange.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRange.Size = new System.Drawing.Size(0, 0);
            this.dgvRange.TabIndex = 1;
            // 
            // кодАссортиментаDataGridViewTextBoxColumn
            // 
            this.кодАссортиментаDataGridViewTextBoxColumn.DataPropertyName = "Код ассортимента";
            this.кодАссортиментаDataGridViewTextBoxColumn.HeaderText = "Код ассортимента";
            this.кодАссортиментаDataGridViewTextBoxColumn.Name = "кодАссортиментаDataGridViewTextBoxColumn";
            // 
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            // 
            // ценаЗаЕдиницуТовараDataGridViewTextBoxColumn
            // 
            this.ценаЗаЕдиницуТовараDataGridViewTextBoxColumn.DataPropertyName = "Цена за единицу товара";
            this.ценаЗаЕдиницуТовараDataGridViewTextBoxColumn.HeaderText = "Цена за единицу товара";
            this.ценаЗаЕдиницуТовараDataGridViewTextBoxColumn.Name = "ценаЗаЕдиницуТовараDataGridViewTextBoxColumn";
            // 
            // объемВУпаковкеDataGridViewTextBoxColumn
            // 
            this.объемВУпаковкеDataGridViewTextBoxColumn.DataPropertyName = "Объем в упаковке";
            this.объемВУпаковкеDataGridViewTextBoxColumn.HeaderText = "Объем в упаковке";
            this.объемВУпаковкеDataGridViewTextBoxColumn.Name = "объемВУпаковкеDataGridViewTextBoxColumn";
            // 
            // ассортиментыBindingSource
            // 
            this.ассортиментыBindingSource.DataMember = "Ассортименты";
            this.ассортиментыBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuppliers.AutoGenerateColumns = false;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn1,
            this.названиеКомпанииDataGridViewTextBoxColumn,
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn,
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn,
            this.бИКDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.расчетныйСчетDataGridViewTextBoxColumn});
            this.dgvSuppliers.DataSource = this.поставщикиBindingSource;
            this.dgvSuppliers.Location = new System.Drawing.Point(660, 424);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSuppliers.Size = new System.Drawing.Size(0, 0);
            this.dgvSuppliers.TabIndex = 2;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn1
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn1.DataPropertyName = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn1.HeaderText = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn1.Name = "кодПоставщикаDataGridViewTextBoxColumn1";
            // 
            // названиеКомпанииDataGridViewTextBoxColumn
            // 
            this.названиеКомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.HeaderText = "Название компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.Name = "названиеКомпанииDataGridViewTextBoxColumn";
            // 
            // контактныйНомерТелефонаDataGridViewTextBoxColumn
            // 
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Контактный номер телефона";
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.HeaderText = "Контактный номер телефона";
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.Name = "контактныйНомерТелефонаDataGridViewTextBoxColumn";
            // 
            // контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn
            // 
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "Контактная электронная почта";
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.HeaderText = "Контактная электронная почта";
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.Name = "контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn";
            // 
            // бИКDataGridViewTextBoxColumn
            // 
            this.бИКDataGridViewTextBoxColumn.DataPropertyName = "БИК";
            this.бИКDataGridViewTextBoxColumn.HeaderText = "БИК";
            this.бИКDataGridViewTextBoxColumn.Name = "бИКDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // расчетныйСчетDataGridViewTextBoxColumn
            // 
            this.расчетныйСчетDataGridViewTextBoxColumn.DataPropertyName = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.HeaderText = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.Name = "расчетныйСчетDataGridViewTextBoxColumn";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // ассортиментыTableAdapter
            // 
            this.ассортиментыTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // cbSelectedCategory
            // 
            this.cbSelectedCategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbSelectedCategory.FormattingEnabled = true;
            this.cbSelectedCategory.Items.AddRange(new object[] {
            "Фрукты, овощи, др.",
            "Мясная продукция",
            "Рыбная продукция",
            "Бакалея",
            "Выпечка, кондитерское изделие",
            "Молочная продукция",
            "Чай, какао, др."});
            this.cbSelectedCategory.Location = new System.Drawing.Point(326, 33);
            this.cbSelectedCategory.Name = "cbSelectedCategory";
            this.cbSelectedCategory.Size = new System.Drawing.Size(297, 27);
            this.cbSelectedCategory.TabIndex = 3;
            this.cbSelectedCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToOrderColumns = true;
            this.dgvCategories.AllowUserToResizeColumns = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn1,
            this.наименованиеКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvCategories.DataSource = this.категорииПродуктаBindingSource;
            this.dgvCategories.Location = new System.Drawing.Point(660, 424);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategories.Size = new System.Drawing.Size(0, 0);
            this.dgvCategories.TabIndex = 4;
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
            // dgvSupByCat
            // 
            this.dgvSupByCat.AllowUserToAddRows = false;
            this.dgvSupByCat.AllowUserToDeleteRows = false;
            this.dgvSupByCat.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvSupByCat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupByCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupByCat.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupByCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupByCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSupByCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupByCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupName,
            this.SupNumber,
            this.ProdName});
            this.dgvSupByCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupByCat.Location = new System.Drawing.Point(0, 80);
            this.dgvSupByCat.Name = "dgvSupByCat";
            this.dgvSupByCat.ReadOnly = true;
            this.dgvSupByCat.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvSupByCat.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSupByCat.RowTemplate.Height = 25;
            this.dgvSupByCat.Size = new System.Drawing.Size(661, 394);
            this.dgvSupByCat.TabIndex = 5;
            // 
            // SupName
            // 
            this.SupName.HeaderText = "Наименование поставщика";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // SupNumber
            // 
            this.SupNumber.HeaderText = "Контактный номер телефона";
            this.SupNumber.Name = "SupNumber";
            this.SupNumber.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Наименование продукта";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelText.ForeColor = System.Drawing.Color.Black;
            this.labelText.Location = new System.Drawing.Point(32, 36);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(288, 19);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Выберите категорию продукта из списка";
            // 
            // panelChooseCat
            // 
            this.panelChooseCat.Controls.Add(this.labelText);
            this.panelChooseCat.Controls.Add(this.cbSelectedCategory);
            this.panelChooseCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChooseCat.Location = new System.Drawing.Point(0, 0);
            this.panelChooseCat.Name = "panelChooseCat";
            this.panelChooseCat.Size = new System.Drawing.Size(661, 80);
            this.panelChooseCat.TabIndex = 7;
            // 
            // panelDgvSupByCat
            // 
            this.panelDgvSupByCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvSupByCat.Location = new System.Drawing.Point(0, 0);
            this.panelDgvSupByCat.Name = "panelDgvSupByCat";
            this.panelDgvSupByCat.Size = new System.Drawing.Size(661, 474);
            this.panelDgvSupByCat.TabIndex = 8;
            // 
            // FormSupCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.dgvSupByCat);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.dgvRange);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelChooseCat);
            this.Controls.Add(this.panelDgvSupByCat);
            this.Name = "FormSupCategories";
            this.Text = "FormSupCategories";
            this.Load += new System.EventHandler(this.FormSupCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ассортиментыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииПродуктаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupByCat)).EndInit();
            this.panelChooseCat.ResumeLayout(false);
            this.panelChooseCat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvRange;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet;
        private System.Windows.Forms.BindingSource ассортиментыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.АссортиментыTableAdapter ассортиментыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАссортиментаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаЕдиницуТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемВУпаковкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйНомерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бИКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расчетныйСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbSelectedCategory;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.BindingSource категорииПродуктаBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.Категории_продуктаTableAdapter категории_продуктаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvSupByCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Panel panelChooseCat;
        private System.Windows.Forms.Panel panelDgvSupByCat;
    }
}