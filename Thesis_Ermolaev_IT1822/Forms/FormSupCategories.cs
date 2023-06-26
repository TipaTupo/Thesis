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
    public partial class FormSupCategories : Form
    {
        public FormSupCategories()
        {
            InitializeComponent();
        }

        private void FormSupCategories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Категории_продукта". При необходимости она может быть перемещена или удалена.
            this.категории_продуктаTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Категории_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Ассортименты". При необходимости она может быть перемещена или удалена.
            this.ассортиментыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Ассортименты);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvSupByCat.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            int counter = 0;
            string selCategory = dgvCategories[1, counter].Value.ToString();
            while ((counter < dgvCategories.Rows.Count) & (cbSelectedCategory.Text != selCategory))
            {
                selCategory = dgvCategories[1, counter].Value.ToString();
                counter++;
            }
            string selCatId;
            if (counter == 0)
            {
                selCatId = dgvCategories[0, counter].Value.ToString();
            }
            else
            {
                selCatId = dgvCategories[0, counter - 1].Value.ToString();
            }
            dgvSupByCat.Rows.Clear();
            string activeSup = "";
            int currentRow = 0;
            for (int i = 0; i < dgvSuppliers.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProducts.Rows.Count; j++)
                {
                    if (selCatId == dgvProducts[2, j].Value.ToString())
                    {
                        for (int k = 0; k < dgvRange.Rows.Count; k++)
                        {
                            if ((dgvRange[1, k].Value.ToString() == dgvProducts[0, j].Value.ToString()) & (dgvRange[2, k].Value.ToString() == dgvSuppliers[0, i].Value.ToString()))
                            {
                                dgvSupByCat.Rows.Add();
                                if (activeSup != dgvSuppliers[1, i].Value.ToString())
                                {
                                    activeSup = dgvSuppliers[1, i].Value.ToString();
                                    dgvSupByCat[0, currentRow].Value = activeSup;
                                    dgvSupByCat[1, currentRow].Value = dgvSuppliers[2, i].Value.ToString();
                                }
                                dgvSupByCat[2, currentRow].Value = dgvProducts[1, j].Value.ToString();
                                currentRow++;

                            }
                        }
                    }
                }
            }
            if (dgvSupByCat.Rows.Count == 0)
                dgvSupByCat.Rows.Add("Ничего не найдено");
        }
    }
}
