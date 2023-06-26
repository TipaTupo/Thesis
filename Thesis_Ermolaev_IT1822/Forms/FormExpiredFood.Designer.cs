namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormExpiredFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpiredFood));
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.кодХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хранениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.хранениеTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter();
            this.dgvExpiredProds = new System.Windows.Forms.DataGridView();
            this.ColStorageDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityInStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.кодПродуктаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.panelButtonPanel = new System.Windows.Forms.Panel();
            this.btnShowRefresh = new System.Windows.Forms.Button();
            this.panelDgvPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredProds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.panelButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStorage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStorage.AutoGenerateColumns = false;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодХраненияDataGridViewTextBoxColumn,
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn,
            this.срокГодностиDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn});
            this.dgvStorage.DataSource = this.хранениеBindingSource;
            this.dgvStorage.Location = new System.Drawing.Point(654, 467);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvStorage.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStorage.Size = new System.Drawing.Size(0, 0);
            this.dgvStorage.TabIndex = 1;
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
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
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
            // dB_Thesis_ErmolaevDataSet
            // 
            this.dB_Thesis_ErmolaevDataSet.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // хранениеTableAdapter
            // 
            this.хранениеTableAdapter.ClearBeforeFill = true;
            // 
            // dgvExpiredProds
            // 
            this.dgvExpiredProds.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvExpiredProds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpiredProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpiredProds.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpiredProds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpiredProds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpiredProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiredProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStorageDepartment,
            this.ColProdName,
            this.ColExpirationDate,
            this.ColQuantityInStorage});
            this.dgvExpiredProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpiredProds.Location = new System.Drawing.Point(0, 32);
            this.dgvExpiredProds.Name = "dgvExpiredProds";
            this.dgvExpiredProds.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvExpiredProds.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpiredProds.Size = new System.Drawing.Size(661, 442);
            this.dgvExpiredProds.TabIndex = 3;
            // 
            // ColStorageDepartment
            // 
            this.ColStorageDepartment.HeaderText = "Наименование отдела хранения";
            this.ColStorageDepartment.Name = "ColStorageDepartment";
            // 
            // ColProdName
            // 
            this.ColProdName.HeaderText = "Наименование продукта";
            this.ColProdName.Name = "ColProdName";
            // 
            // ColExpirationDate
            // 
            this.ColExpirationDate.HeaderText = "Срок годности";
            this.ColExpirationDate.Name = "ColExpirationDate";
            // 
            // ColQuantityInStorage
            // 
            this.ColQuantityInStorage.HeaderText = "Количество на складе";
            this.ColQuantityInStorage.Name = "ColQuantityInStorage";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродуктаDataGridViewTextBoxColumn1,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.продуктыBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(654, 467);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.Size = new System.Drawing.Size(0, 0);
            this.dgvProducts.TabIndex = 4;
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
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbInfo.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.info__2_;
            this.pbInfo.Location = new System.Drawing.Point(0, 0);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(32, 32);
            this.pbInfo.TabIndex = 1;
            this.pbInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pbInfo, resources.GetString("pbInfo.ToolTip"));
            // 
            // panelButtonPanel
            // 
            this.panelButtonPanel.Controls.Add(this.pbInfo);
            this.panelButtonPanel.Controls.Add(this.btnShowRefresh);
            this.panelButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.panelButtonPanel.Name = "panelButtonPanel";
            this.panelButtonPanel.Size = new System.Drawing.Size(661, 32);
            this.panelButtonPanel.TabIndex = 7;
            // 
            // btnShowRefresh
            // 
            this.btnShowRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnShowRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowRefresh.FlatAppearance.BorderSize = 0;
            this.btnShowRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(104)))));
            this.btnShowRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRefresh.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnShowRefresh.ForeColor = System.Drawing.Color.White;
            this.btnShowRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnShowRefresh.Name = "btnShowRefresh";
            this.btnShowRefresh.Size = new System.Drawing.Size(661, 32);
            this.btnShowRefresh.TabIndex = 0;
            this.btnShowRefresh.Text = "Показать / Обновить";
            this.btnShowRefresh.UseVisualStyleBackColor = false;
            this.btnShowRefresh.Click += new System.EventHandler(this.btnShowRefresh_Click);
            this.btnShowRefresh.MouseEnter += new System.EventHandler(this.btnShowRefresh_MouseEnter);
            this.btnShowRefresh.MouseLeave += new System.EventHandler(this.btnShowRefresh_MouseLeave);
            // 
            // panelDgvPanel
            // 
            this.panelDgvPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvPanel.Location = new System.Drawing.Point(0, 32);
            this.panelDgvPanel.Name = "panelDgvPanel";
            this.panelDgvPanel.Size = new System.Drawing.Size(661, 442);
            this.panelDgvPanel.TabIndex = 8;
            // 
            // FormExpiredFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvStorage);
            this.Controls.Add(this.dgvExpiredProds);
            this.Controls.Add(this.panelDgvPanel);
            this.Controls.Add(this.panelButtonPanel);
            this.Name = "FormExpiredFood";
            this.Text = "FormExpiredFood";
            this.Load += new System.EventHandler(this.FormExpiredFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiredProds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.panelButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStorage;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet;
        private System.Windows.Forms.BindingSource хранениеBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter хранениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОтделаХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvExpiredProds;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorageDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityInStorage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelButtonPanel;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.Button btnShowRefresh;
        private System.Windows.Forms.Panel panelDgvPanel;
    }
}