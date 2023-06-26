using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Thesis_Ermolaev_IT1822.Forms
{
    public partial class FormFoodOut : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB_Thesis_Ermolaev.mdb";

        private OleDbConnection connectionToDB;

        public FormFoodOut()
        {
            InitializeComponent();
        }

        private void FormFoodOut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Хранение". При необходимости она может быть перемещена или удалена.
            this.хранениеTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Хранение);

            connectionToDB = new OleDbConnection(connectString);
            connectionToDB.Open();
        }

        private void FormFoodOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionToDB.Close();
            btnUpdateRemove.Enabled = true;
        }

        private void FillCbProdId()
        {
            cbProdId.Items.Clear();
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                cbProdId.Items.Add($"{dgvProducts[0, i].Value}  ({dgvProducts[1, i].Value})");
            }
        }

        private void FormFoodOut_Resize(object sender, EventArgs e)
        {
            panelUpper.Height = (Form.ActiveForm.Height - 39) * 43 / 100;
            FillCbProdId();
        }

        private int SearchStorageId()
        {
            int j = 0;
            string storName = dgvStorage[1, j].Value.ToString();
            string prodId = dgvStorage[2, j].Value.ToString();
            string enterStorName = mtbStorageName.Text;
            string enterProdId = cbProdId.Text;
            enterProdId = enterProdId.Substring(0, enterProdId.IndexOf(" "));
            while ((j < dgvStorage.Rows.Count) & (enterStorName != storName) & (enterProdId != prodId))
            {
                storName = dgvStorage[1, j].Value.ToString();
                prodId = dgvStorage[2, j].Value.ToString();
                j++;
            }
            if (j > 0)
                j--;
            int k = Convert.ToInt32(dgvStorage[0, j].Value);
            return k;
        }

        private void btnUpdateRemove_Click(object sender, EventArgs e)
        {
            if (CorrectData() == 4)
            {
                string selProdIdCb = cbProdId.Text;
                selProdIdCb = selProdIdCb.Substring(0, selProdIdCb.IndexOf(" "));
                int i = 0;
                string selProdInStorage = dgvStorage[2, i].Value.ToString();
                while (selProdIdCb != selProdInStorage)
                {
                    selProdInStorage = dgvStorage[2, i].Value.ToString();
                    i++;
                }
                int selQuanInStorageTb = Convert.ToInt32(tbQuanInStorage.Text);
                int remainProdId;
                if (i == 0)
                    remainProdId = i;
                else
                    remainProdId = i - 1;
                int selStorageCell = Convert.ToInt32(dgvStorage[4, remainProdId].Value);
                int remainQuan = selStorageCell - selQuanInStorageTb;

                if (remainQuan > 0)
                {
                    //MessageBox.Show($"UPDATE Хранение SET [Количество на складе] = {remainQuan} WHERE [Код хранения] = {SearchStorageId()}");
                    //UPDATE
                    string queryText = $"UPDATE Хранение SET [Количество на складе] = {remainQuan} WHERE [Код хранения] = {SearchStorageId()}";
                    OleDbCommand query = new OleDbCommand(queryText, connectionToDB);
                    query.ExecuteNonQuery();
                    btnUpdateRemove.Enabled = false;
                }
                else
                {
                    if (remainQuan == 0)
                    {
                        //DELETE
                        string queryText = $"DELETE FROM Хранение WHERE [Код хранения] = {SearchStorageId()}";
                        OleDbCommand query = new OleDbCommand(queryText, connectionToDB);
                        query.ExecuteNonQuery();
                        btnUpdateRemove.Enabled = false;
                    }
                    else
                        MessageBox.Show("На скалде нет столько единиц товара, сколько сказано его списать. Проверьте данные еще раз");
                }
            }
            else
                MessageBox.Show("Введите корректные данные");
        }

        private int CorrectData()
        {
            int i = 0;
            if (mtbStorageName.Text != "")
                i++;
            if (cbProdId.Text != "")
                i++;
            try
            {
                int quanInStorage = Convert.ToInt32(tbQuanInStorage.Text);
                i++;
            }
            catch { }

            int j = 0;
            string storName = dgvStorage[1, j].Value.ToString();
            string prodId = dgvStorage[2, j].Value.ToString();
            string enterStorName = mtbStorageName.Text;
            string enterProdId = cbProdId.Text;
            try
            {
                enterProdId = enterProdId.Substring(0, enterProdId.IndexOf(" "));
            }
            catch { }
            while ((j < dgvStorage.Rows.Count) & (enterStorName != storName) & (enterProdId != prodId))
            {
                storName = dgvStorage[1, j].Value.ToString();
                prodId = dgvStorage[2, j].Value.ToString();
                j++;
            }
            if (j == 0)
            {
                if ((enterStorName == dgvStorage[1, j].Value.ToString()) & (enterProdId == dgvStorage[2, j].Value.ToString()))
                    i++;
            }
            else
            {
                if ((enterStorName == dgvStorage[1, j - 1].Value.ToString()) & (enterProdId == dgvStorage[2, j - 1].Value.ToString()))
                    i++;
            }
            return i;
        }
    }
}
