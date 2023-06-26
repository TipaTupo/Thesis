namespace Thesis_Ermolaev_IT1822
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExpiredFood = new System.Windows.Forms.Button();
            this.btnFoodOut = new System.Windows.Forms.Button();
            this.btnFoodIn = new System.Windows.Forms.Button();
            this.btnAvailableFood = new System.Windows.Forms.Button();
            this.btnSupCategories = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnBackToStart = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStartPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelStartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.panelMenu.Controls.Add(this.btnExpiredFood);
            this.panelMenu.Controls.Add(this.btnFoodOut);
            this.panelMenu.Controls.Add(this.btnFoodIn);
            this.panelMenu.Controls.Add(this.btnAvailableFood);
            this.panelMenu.Controls.Add(this.btnSupCategories);
            this.panelMenu.Controls.Add(this.btnSuppliers);
            this.panelMenu.Controls.Add(this.btnBackToStart);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(660, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 504);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExpiredFood
            // 
            this.btnExpiredFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpiredFood.FlatAppearance.BorderSize = 0;
            this.btnExpiredFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnExpiredFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredFood.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnExpiredFood.ForeColor = System.Drawing.Color.White;
            this.btnExpiredFood.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.incident;
            this.btnExpiredFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpiredFood.Location = new System.Drawing.Point(0, 306);
            this.btnExpiredFood.Name = "btnExpiredFood";
            this.btnExpiredFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExpiredFood.Size = new System.Drawing.Size(236, 53);
            this.btnExpiredFood.TabIndex = 7;
            this.btnExpiredFood.Text = "     Просроченные\r\n     продукты";
            this.btnExpiredFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpiredFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpiredFood.UseVisualStyleBackColor = true;
            this.btnExpiredFood.Click += new System.EventHandler(this.btnExpiredFood_Click);
            // 
            // btnFoodOut
            // 
            this.btnFoodOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodOut.FlatAppearance.BorderSize = 0;
            this.btnFoodOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnFoodOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodOut.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnFoodOut.ForeColor = System.Drawing.Color.White;
            this.btnFoodOut.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.log_out;
            this.btnFoodOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodOut.Location = new System.Drawing.Point(0, 253);
            this.btnFoodOut.Name = "btnFoodOut";
            this.btnFoodOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFoodOut.Size = new System.Drawing.Size(236, 53);
            this.btnFoodOut.TabIndex = 6;
            this.btnFoodOut.Text = "     Заказ на\r\n     отгрузку";
            this.btnFoodOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodOut.UseVisualStyleBackColor = true;
            this.btnFoodOut.Click += new System.EventHandler(this.btnFoodOut_Click);
            // 
            // btnFoodIn
            // 
            this.btnFoodIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodIn.FlatAppearance.BorderSize = 0;
            this.btnFoodIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnFoodIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodIn.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnFoodIn.ForeColor = System.Drawing.Color.White;
            this.btnFoodIn.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.log_in__1_;
            this.btnFoodIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodIn.Location = new System.Drawing.Point(0, 200);
            this.btnFoodIn.Name = "btnFoodIn";
            this.btnFoodIn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFoodIn.Size = new System.Drawing.Size(236, 53);
            this.btnFoodIn.TabIndex = 5;
            this.btnFoodIn.Text = "     Регистрация\r\n     поставки";
            this.btnFoodIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodIn.UseVisualStyleBackColor = true;
            this.btnFoodIn.Click += new System.EventHandler(this.btnFoodIn_Click);
            // 
            // btnAvailableFood
            // 
            this.btnAvailableFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAvailableFood.FlatAppearance.BorderSize = 0;
            this.btnAvailableFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnAvailableFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableFood.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAvailableFood.ForeColor = System.Drawing.Color.White;
            this.btnAvailableFood.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.healthy_food;
            this.btnAvailableFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableFood.Location = new System.Drawing.Point(0, 147);
            this.btnAvailableFood.Name = "btnAvailableFood";
            this.btnAvailableFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAvailableFood.Size = new System.Drawing.Size(236, 53);
            this.btnAvailableFood.TabIndex = 4;
            this.btnAvailableFood.Text = "     Имеющиеся\r\n     продукты";
            this.btnAvailableFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvailableFood.UseVisualStyleBackColor = true;
            this.btnAvailableFood.Click += new System.EventHandler(this.btnAvailableFood_Click);
            // 
            // btnSupCategories
            // 
            this.btnSupCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupCategories.FlatAppearance.BorderSize = 0;
            this.btnSupCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnSupCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupCategories.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSupCategories.ForeColor = System.Drawing.Color.White;
            this.btnSupCategories.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.list__1_;
            this.btnSupCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupCategories.Location = new System.Drawing.Point(0, 147);
            this.btnSupCategories.Name = "btnSupCategories";
            this.btnSupCategories.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSupCategories.Size = new System.Drawing.Size(236, 0);
            this.btnSupCategories.TabIndex = 2;
            this.btnSupCategories.Text = "     Поставщики\r\n     по категориям";
            this.btnSupCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupCategories.UseVisualStyleBackColor = true;
            this.btnSupCategories.Click += new System.EventHandler(this.btnSupCategories_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(110)))), ((int)(((byte)(182)))));
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.supplier;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 94);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(236, 53);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "     Поставщики";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnBackToStart
            // 
            this.btnBackToStart.BackColor = System.Drawing.Color.White;
            this.btnBackToStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackToStart.FlatAppearance.BorderSize = 0;
            this.btnBackToStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(104)))));
            this.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToStart.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.cancel__1_;
            this.btnBackToStart.Location = new System.Drawing.Point(0, 94);
            this.btnBackToStart.Name = "btnBackToStart";
            this.btnBackToStart.Size = new System.Drawing.Size(0, 410);
            this.btnBackToStart.TabIndex = 0;
            this.btnBackToStart.UseVisualStyleBackColor = false;
            this.btnBackToStart.Click += new System.EventHandler(this.btnBackToStart_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(104)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(236, 94);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(28, 17, 0, 0);
            this.label1.Size = new System.Drawing.Size(211, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Склад ДСОЛ\r\n\"Морская волна\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelStartPanel
            // 
            this.panelStartPanel.BackColor = System.Drawing.Color.White;
            this.panelStartPanel.Controls.Add(this.pictureBox1);
            this.panelStartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartPanel.Location = new System.Drawing.Point(0, 0);
            this.panelStartPanel.Name = "panelStartPanel";
            this.panelStartPanel.Size = new System.Drawing.Size(660, 504);
            this.panelStartPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Thesis_Ermolaev_IT1822.Properties.Resources.d04a106d16fb36463fbcd0a770bbd004;
            this.pictureBox1.Location = new System.Drawing.Point(113, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 504);
            this.Controls.Add(this.panelStartPanel);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 504);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelStartPanel.ResumeLayout(false);
            this.panelStartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSupCategories;
        private System.Windows.Forms.Button btnAvailableFood;
        private System.Windows.Forms.Button btnExpiredFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStartPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoodOut;
        private System.Windows.Forms.Button btnFoodIn;
        private System.Windows.Forms.Button btnBackToStart;
    }
}

