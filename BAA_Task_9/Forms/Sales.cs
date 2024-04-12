using BAA_Task_9.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BAA_Task_9.Forms
{
    public partial class Sales : Form
    {
        public Sales(string userRole, string name)
        {
            InitializeComponent();
            labelStripRole.Text += userRole;
            labelStripName.Text += name;
            LoadAndInitData();
        }

        private void LoadAndInitData()
        {
            // Получение данных из бд
            var currentGoods = Auction_BAAEntities.GetContext().Sells.Join
            (Auction_BAAEntities.GetContext().Goods, p => p.SellId, t => t.GoodSellId,
            (p, t) => new { p.DateBargain, p.StartingPrice, p.FinalPrice, p.SignOfSale, t.GoodName, p.CodeSellId }).ToList();

            // В качестве источника данных присваиваем список
            dataGridViewSell.DataSource = currentGoods;

            // Убираем вывод id
            dataGridViewSell.Columns[5].Visible = false;

            // Загаловки столбцов
            dataGridViewSell.Columns[0].HeaderText = "Дата торга";
            dataGridViewSell.Columns[1].HeaderText = "Стартовая цена";
            dataGridViewSell.Columns[2].HeaderText = "Последняя цена";
            dataGridViewSell.Columns[3].HeaderText = "Признак продажи";
            dataGridViewSell.Columns[4].HeaderText = "Название товара";
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Authorization authorization = new Authorization();
                authorization.Show();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Продажи";

            // Заголовок таблицы в Excel
            for (int j = 0; j < 5; j++)
                worksheet.Cells[1, j + 1] = dataGridViewSell.Columns[j].HeaderCell.Value;

            // Данные таблицы
            for (int i = 2; i < dataGridViewSell.Rows.Count + 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    worksheet.Cells[i, j + 1] = dataGridViewSell[j, i - 2].Value;
                }
            }
            application.Visible = true;
        }
    }
}
