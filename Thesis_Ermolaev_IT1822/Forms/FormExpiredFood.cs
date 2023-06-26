using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Ermolaev_IT1822.Forms
{
    public partial class FormExpiredFood : Form
    {
        public FormExpiredFood()
        {
            InitializeComponent();
        }

        private void FormExpiredFood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Хранение". При необходимости она может быть перемещена или удалена.
            this.хранениеTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Хранение);

        }

        private string SearchForProdName(int i)
        {
            string prodId = dgvStorage[2, i].Value.ToString();
            int j = 0;
            string desiredNum = dgvProducts[0, j].Value.ToString();
            while ((j < dgvProducts.Rows.Count) & (prodId != desiredNum))
            {
                desiredNum = dgvProducts[0, j].Value.ToString();
                j++;
            }
            return dgvProducts[1, j - 1].Value.ToString();
        }

        private void FillTheCells(int i, int j)
        {
            dgvExpiredProds.Rows.Add();
            dgvExpiredProds[0, j].Value = dgvStorage[1, i].Value.ToString();
            dgvExpiredProds[1, j].Value = SearchForProdName(i);
            dgvExpiredProds[2, j].Value = dgvStorage[3, i].Value.ToString();
            dgvExpiredProds[3, j].Value = dgvStorage[4, i].Value.ToString();
        }

        private void btnShowRefresh_Click(object sender, EventArgs e)
        {
            dgvExpiredProds.Rows.Clear();
            DateTime actualDate = DateTime.Now;
            int rowNumInDgvExpProd = 0;
            for (int i = 0; i < dgvStorage.Rows.Count; i++)
            {
                string expDate = dgvStorage[3, i].Value.ToString();
                int expDay = Convert.ToInt32(expDate.Substring(0, 2));
                int expMonth = Convert.ToInt32(expDate.Substring(3, 2));
                int expYear = Convert.ToInt32(expDate.Substring(6, 4));
                DateTime selectDate = new DateTime(expYear, expMonth, expDay);
                string expResult = selectDate.Subtract(actualDate).ToString();
                expResult = expResult.Substring(0, 2);
                if (expResult[0] == '-')
                {
                    FillTheCells(i, rowNumInDgvExpProd);
                    dgvExpiredProds.Rows[rowNumInDgvExpProd].Cells[2].Style.BackColor = Color.LightCoral;
                    rowNumInDgvExpProd++;
                }
                else
                {
                    if ((Convert.ToInt32(expResult[0]) <= 54) & (Convert.ToInt32(expResult[0]) >= 48) & !(char.IsDigit(expResult[1])))
                    {
                        FillTheCells(i, rowNumInDgvExpProd);
                        dgvExpiredProds.Rows[rowNumInDgvExpProd].Cells[2].Style.BackColor = Color.Gold;
                        rowNumInDgvExpProd++;
                    }
                }
            }
        }

        private void btnShowRefresh_MouseEnter(object sender, EventArgs e)
        {
            pbInfo.BackColor = Color.FromArgb(0, 51, 104);
        }

        private void btnShowRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbInfo.BackColor = Color.FromArgb(33, 110, 182);
        }
    }
}
