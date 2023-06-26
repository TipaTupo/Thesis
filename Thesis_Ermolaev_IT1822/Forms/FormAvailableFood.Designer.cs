namespace Thesis_Ermolaev_IT1822.Forms
{
    partial class FormAvailableFood
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
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.кодХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОтделаХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хранениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Thesis_ErmolaevDataSet = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.продуктыХранениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.хранениеTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ХранениеTableAdapter();
            this.продуктыTableAdapter = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter();
            this.dB_Thesis_ErmolaevDataSet1 = new Thesis_Ermolaev_IT1822.DB_Thesis_ErmolaevDataSet();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.кодПродуктаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSelPRodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыХранениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.AllowUserToResizeColumns = false;
            this.dgvStorage.AllowUserToResizeRows = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
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
            this.dgvStorage.Size = new System.Drawing.Size(661, 394);
            this.dgvStorage.TabIndex = 0;
            this.dgvStorage.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellEnter);
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
            // продуктыХранениеBindingSource
            // 
            this.продуктыХранениеBindingSource.DataMember = "ПродуктыХранение";
            this.продуктыХранениеBindingSource.DataSource = this.продуктыBindingSource;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // хранениеTableAdapter
            // 
            this.хранениеTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // dB_Thesis_ErmolaevDataSet1
            // 
            this.dB_Thesis_ErmolaevDataSet1.DataSetName = "DB_Thesis_ErmolaevDataSet";
            this.dB_Thesis_ErmolaevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.dB_Thesis_ErmolaevDataSet1;
            // 
            // продуктыBindingSource2
            // 
            this.продуктыBindingSource2.DataMember = "Продукты";
            this.продуктыBindingSource2.DataSource = this.dB_Thesis_ErmolaevDataSet1;
            // 
            // продуктыBindingSource3
            // 
            this.продуктыBindingSource3.DataMember = "Продукты";
            this.продуктыBindingSource3.DataSource = this.dB_Thesis_ErmolaevDataSet1;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродуктаDataGridViewTextBoxColumn2,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.кодКатегорииПродуктаDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.продуктыBindingSource5;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(593, 74);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.Size = new System.Drawing.Size(0, 131);
            this.dgvProducts.TabIndex = 3;
            // 
            // кодПродуктаDataGridViewTextBoxColumn2
            // 
            this.кодПродуктаDataGridViewTextBoxColumn2.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn2.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn2.Name = "кодПродуктаDataGridViewTextBoxColumn2";
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
            // продуктыBindingSource5
            // 
            this.продуктыBindingSource5.DataMember = "Продукты";
            this.продуктыBindingSource5.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // продуктыBindingSource4
            // 
            this.продуктыBindingSource4.DataMember = "Продукты";
            this.продуктыBindingSource4.DataSource = this.dB_Thesis_ErmolaevDataSet;
            // 
            // tbSelPRodName
            // 
            this.tbSelPRodName.BackColor = System.Drawing.Color.White;
            this.tbSelPRodName.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbSelPRodName.ForeColor = System.Drawing.Color.Black;
            this.tbSelPRodName.Location = new System.Drawing.Point(333, 33);
            this.tbSelPRodName.Name = "tbSelPRodName";
            this.tbSelPRodName.ReadOnly = true;
            this.tbSelPRodName.Size = new System.Drawing.Size(257, 27);
            this.tbSelPRodName.TabIndex = 4;
            this.tbSelPRodName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование выбранного продукта:";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSelPRodName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 80);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStorage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 394);
            this.panel2.TabIndex = 7;
            // 
            // FormAvailableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 474);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAvailableFood";
            this.Text = "FormAvailableFood";
            this.Load += new System.EventHandler(this.FormAvailableFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.хранениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыХранениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Thesis_ErmolaevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private DB_Thesis_ErmolaevDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.BindingSource продуктыХранениеBindingSource;
        private DB_Thesis_ErmolaevDataSet dB_Thesis_ErmolaevDataSet1;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private System.Windows.Forms.BindingSource продуктыBindingSource2;
        private System.Windows.Forms.BindingSource продуктыBindingSource3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продуктыBindingSource4;
        private System.Windows.Forms.TextBox tbSelPRodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource продуктыBindingSource5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}