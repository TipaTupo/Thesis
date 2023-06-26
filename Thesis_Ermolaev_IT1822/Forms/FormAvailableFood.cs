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
    public partial class FormAvailableFood : Form
    {
        public FormAvailableFood()
        {
            InitializeComponent();

        }

        private void FormAvailableFood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Хранение". При необходимости она может быть перемещена или удалена.
            this.хранениеTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Хранение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Продукты);

        }

        int counter = 0;
        private void dgvStorage_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (counter > 2)
            {
                tbSelPRodName.Visible = true;
                label1.Visible = true;
                int i = 0;
                int k = -1;
                try
                {
                    if (dgvStorage.SelectedCells[0].RowIndex >= 0)
                        while ((i < dgvProducts.Rows.Count) & (k != Convert.ToInt32(dgvStorage[2, dgvStorage.SelectedCells[0].RowIndex].Value)))
                        {
                            k = Convert.ToInt32(dgvProducts[0, i].Value);
                            i++;
                        }
                    tbSelPRodName.Text = dgvProducts[1, i - 1].Value.ToString();
                }
                catch { }
            }
            counter++;
        }
    }
}
