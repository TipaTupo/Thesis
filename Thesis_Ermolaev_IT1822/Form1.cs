using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Thesis_Ermolaev_IT1822
{
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

       private void ActivateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(33, 110, 182);
                    currentButton.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    btnBackToStart.Width = 22;
                    btnBackToStart.BackColor = Color.FromArgb(33, 110, 182);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 160, 233);
                    previousBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        public void OpenChildForm (Form childForm, object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelStartPanel.Controls.Add(childForm);
            this.panelStartPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSuppliers(), sender);
            btnSupCategories.Height = 53;
        }

        private void btnAvailableFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAvailableFood(), sender);
            btnSupCategories.Height = 0;
        }

        private void btnFoodIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFoodIn(), sender);
            btnSupCategories.Height = 0;
        }

        private void btnFoodOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFoodOut(), sender);
            btnSupCategories.Height = 0;
        }

        private void btnExpiredFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormExpiredFood(), sender);
            btnSupCategories.Height = 0;
        }

        private void btnSupCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSupCategories(), sender);
        }

        private void btnBackToStart_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            btnSupCategories.Height = 0;
            currentButton = null;
            btnBackToStart.Width = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btnBackToStart_Click(sender, e);
        }
    }
}
