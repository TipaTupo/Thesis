namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormSuppliers
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
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бИКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетныйСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.поставщикиTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПоставщикиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.AutoGenerateColumns = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.названиеКомпанииDataGridViewTextBoxColumn,
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn,
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn,
            this.бИКDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.расчетныйСчетDataGridViewTextBoxColumn});
            this.dgvSuppliers.DataSource = this.поставщикиBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.Location = new System.Drawing.Point(0, 0);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSuppliers.Size = new System.Drawing.Size(661, 474);
            this.dgvSuppliers.TabIndex = 0;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПоставщикаDataGridViewTextBoxColumn.Width = 119;
            // 
            // названиеКомпанииDataGridViewTextBoxColumn
            // 
            this.названиеКомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.HeaderText = "Название компании";
            this.названиеКомпанииDataGridViewTextBoxColumn.Name = "названиеКомпанииDataGridViewTextBoxColumn";
            this.названиеКомпанииDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеКомпанииDataGridViewTextBoxColumn.Width = 141;
            // 
            // контактныйНомерТелефонаDataGridViewTextBoxColumn
            // 
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Контактный номер телефона";
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.HeaderText = "Контактный номер телефона";
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.Name = "контактныйНомерТелефонаDataGridViewTextBoxColumn";
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактныйНомерТелефонаDataGridViewTextBoxColumn.Width = 118;
            // 
            // контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn
            // 
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "Контактная электронная почта";
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.HeaderText = "Контактная электронная почта";
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.Name = "контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn";
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.ReadOnly = true;
            this.контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn.Width = 131;
            // 
            // бИКDataGridViewTextBoxColumn
            // 
            this.бИКDataGridViewTextBoxColumn.DataPropertyName = "БИК";
            this.бИКDataGridViewTextBoxColumn.HeaderText = "БИК";
            this.бИКDataGridViewTextBoxColumn.Name = "бИКDataGridViewTextBoxColumn";
            this.бИКDataGridViewTextBoxColumn.ReadOnly = true;
            this.бИКDataGridViewTextBoxColumn.Width = 58;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            this.иННDataGridViewTextBoxColumn.Width = 60;
            // 
            // расчетныйСчетDataGridViewTextBoxColumn
            // 
            this.расчетныйСчетDataGridViewTextBoxColumn.DataPropertyName = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.HeaderText = "Расчетный счет";
            this.расчетныйСчетDataGridViewTextBoxColumn.Name = "расчетныйСчетDataGridViewTextBoxColumn";
            this.расчетныйСчетDataGridViewTextBoxColumn.ReadOnly = true;
            this.расчетныйСчетDataGridViewTextBoxColumn.Width = 114;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // dB_Thesis_ErmolaevDataSet
            // 
            this.dB_Thesis_ErmolaevDataSet.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "FormSuppliers";
            this.Text = "FormSuppliers";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйНомерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактнаяЭлектроннаяПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бИКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расчетныйСчетDataGridViewTextBoxColumn;
    }
}