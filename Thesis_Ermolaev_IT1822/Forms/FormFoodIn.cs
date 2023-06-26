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
using System.Data.SqlClient;

namespace Thesis_Ermolaev_IT1822.Forms
{
    public partial class FormFoodIn : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB_Thesis_Ermolaev.mdb";

        private OleDbConnection connectionToDB;

        public FormFoodIn()
        {
            InitializeComponent();
        }

        private void FormFoodIn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Категории_продукта". При необходимости она может быть перемещена или удалена.
            this.категории_продуктаTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Категории_продукта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Thesis_ErmolaevDataSet.Хранение". При необходимости она может быть перемещена или удалена.
            this.хранениеTableAdapter.Fill(this.dB_Thesis_ErmolaevDataSet.Хранение);

            connectionToDB = new OleDbConnection(connectString);
            connectionToDB.Open();
        }

        private void FormFoodIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionToDB.Close();
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CorrectData())
            {
                string selProdId = cbProdId.Text;
                selProdId = selProdId.Substring(0, selProdId.IndexOf(" "));
                string selDate = dtpExpDate.Value.ToString();
                selDate = selDate.Substring(0, 10);
                int selStorageId = Convert.ToInt32(dgvStorage[0, dgvStorage.Rows.Count - 1].Value) + 1;
                string queryText = "INSERT INTO Хранение ( [Код хранения], [Наименование отдела хранения], [Код продукта], [Срок годности], [Количество на складе] ) values(" + selStorageId + ", '" + mtbStorageName.Text + "', '" + selProdId + "', '" + selDate + "', '" + tbQuanInStorage.Text + "')";
                OleDbCommand query = new OleDbCommand(queryText, connectionToDB);
                query.ExecuteNonQuery();
                btnAdd.Enabled = false;
            }
            else
                MessageBox.Show("Введите корректные данные");
        }

        private bool CorrectData()
        {
            int i = 0;
            if (mtbStorageName.Text != "")
                i++;
            if (cbProdId.Text != "")
                i++;
            string s = DateTime.Now.Subtract(dtpExpDate.Value).ToString();
            if (s[0] == '-')
                i++;
            try
            {
                int quanInStorage = Convert.ToInt32(tbQuanInStorage.Text);
                i++;
            }
            catch { }
            return (i == 4);
        }

        private void FillCbProdId()
        {
            cbProdId.Items.Clear();
            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                cbProdId.Items.Add($"{dgvProducts[0, i].Value}  ({dgvProducts[1, i].Value})");
            }
        }

        private void FormFoodIn_Resize(object sender, EventArgs e)
        {
            panelUpper.Height = (Form.ActiveForm.Height - 39) * 43 / 100;
            FillCbProdId();
        }

        int easterEgg = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            easterEgg++;
            if (easterEgg == 5)
                MessageBox.Show("Э, бля! Куда залез? Эт не по-пацански. С тебя 500 рублей за такое...\r\n" +
                                "Я тя на счетчик поставил. Надо будет - из-под земли достану. Усёк?!\r\n" +
                                "Все, давай, братик, не пропадай. Куда деньги занести, знаешь. Давай!");
        }
    }
}
