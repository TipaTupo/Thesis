namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormFoodOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoodOut));
            this.panelUpper = new System.Windows.Forms.Panel();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.кодХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хранениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.кодПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbStorageName = new System.Windows.Forms.MaskedTextBox();
            this.cbProdId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuanInStorage = new System.Windows.Forms.TextBox();
            this.хранениеTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter();
            this.продуктыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.dgvStorage);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(661, 212);
            this.panelUpper.TabIndex = 0;
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvStorage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStorage.AutoGenerateColumns = false;
            this.dgvStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодХраненияDataGridViewTextBoxColumn,
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn,
            this.срокГодностиDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn});
            this.dgvStorage.DataSource = this.хранениеBindingSource;
            this.dgvStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorage.Location = new System.Drawing.Point(0, 0);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            this.dgvStorage.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvStorage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStorage.Size = new System.Drawing.Size(661, 212);
            this.dgvStorage.TabIndex = 12;
            this.dgvStorage.TabStop = false;
            // 
            // кодХраненияDataGridViewTextBoxColumn
            // 
            this.кодХраненияDataGridViewTextBoxColumn.DataPropertyName = "Код хранения";
            this.кодХраненияDataGridViewTextBoxColumn.HeaderText = "Код хранения";
            this.кодХраненияDataGridViewTextBoxColumn.Name = "кодХраненияDataGridViewTextBoxColumn";
            this.кодХраненияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеОтделаХраненияDataGridViewTextBoxColumn
            // 
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.DataPropertyName = "Наименование отдела хранения";
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.HeaderText = "Наименование отдела хранения";
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.Name = "наименованиеОтделаХраненияDataGridViewTextBoxColumn";
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
            this.кодПродуктаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // срокГодностиDataGridViewTextBoxColumn
            // 
            this.срокГодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.Name = "срокГодностиDataGridViewTextBoxColumn";
            this.срокГодностиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            this.количествоНаСкладеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // хранениеBindingSource
            // 
            this.хранениеBindingSource.DataMember = "Хранение";
            this.хранениеBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // dB_Thesis_ErmolaevDataSet
            // 
            this.dB_Thesis_ErmolaevDataSet.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.dgvProducts);
            this.panelMain.Controls.Add(this.mtbStorageName);
            this.panelMain.Controls.Add(this.cbProdId);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btnUpdateRemove);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.tbQuanInStorage);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 212);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(661, 262);
            this.panelMain.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(555, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Выберите из меню или укажите дату\r\nокончания срока годности данного продукта");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Название хранилища состоит из:\r\nбуквы русского алфавита и двух цифр\r\n(примеры наз" +
        "ваний: А00, Я99)");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Введите данные:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродуктаDataGridViewTextBoxColumn1,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.продуктыBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(654, 252);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(0, 0);
            this.dgvProducts.TabIndex = 24;
            this.dgvProducts.TabStop = false;
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
            // mtbStorageName
            // 
            this.mtbStorageName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbStorageName.Location = new System.Drawing.Point(315, 94);
            this.mtbStorageName.Mask = ">L00";
            this.mtbStorageName.Name = "mtbStorageName";
            this.mtbStorageName.Size = new System.Drawing.Size(234, 27);
            this.mtbStorageName.TabIndex = 0;
            this.mtbStorageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbProdId
            // 
            this.cbProdId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProdId.FormattingEnabled = true;
            this.cbProdId.Location = new System.Drawing.Point(304, 137);
            this.cbProdId.Name = "cbProdId";
            this.cbProdId.Size = new System.Drawing.Size(245, 27);
            this.cbProdId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наимененование хранилища";
            // 
            // btnUpdateRemove
            // 
            this.btnUpdateRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnUpdateRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateRemove.FlatAppearance.BorderSize = 0;
            this.btnUpdateRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnUpdateRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRemove.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnUpdateRemove.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRemove.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateRemove.Name = "btnUpdateRemove";
            this.btnUpdateRemove.Size = new System.Drawing.Size(661, 32);
            this.btnUpdateRemove.TabIndex = 3;
            this.btnUpdateRemove.Text = "Выписать из базы";
            this.btnUpdateRemove.UseVisualStyleBackColor = false;
            this.btnUpdateRemove.Click += new System.EventHandler(this.btnUpdateRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Количество продукта в заявке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите продукт из списка";
            // 
            // tbQuanInStorage
            // 
            this.tbQuanInStorage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuanInStorage.Location = new System.Drawing.Point(315, 180);
            this.tbQuanInStorage.Name = "tbQuanInStorage";
            this.tbQuanInStorage.Size = new System.Drawing.Size(234, 27);
            this.tbQuanInStorage.TabIndex = 2;
            this.tbQuanInStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // хранениеTableAdapter
            // 
            this.хранениеTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // FormFoodOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelUpper);
            this.Name = "FormFoodOut";
            this.Text = "FormFoodOut";
            this.Load += new System.EventHandler(this.FormFoodOut_Load);
            this.Resize += new System.EventHandler(this.FormFoodOut_Resize);
            this.panelUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MaskedTextBox mtbStorageName;
        private System.Windows.Forms.ComboBox cbProdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuanInStorage;
        private System.Windows.Forms.DataGridView dgvStorage;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet;
        private System.Windows.Forms.BindingSource хранениеBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter хранениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОтделаХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}