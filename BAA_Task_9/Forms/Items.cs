using BAA_Task_9.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Directory = BAA_Task_9.Models.Directory;

namespace BAA_Task_9.Forms
{
    public partial class Items : Form
    {
        int _itemcount = 0;

        public Items(string userRole, string name)
        {
            InitializeComponent();
            labelStripRole.Text = userRole;
            labelStripName.Text = name;
            LoadAndInitData();

            var CategoryType = Auction_BAAEntities.GetContext().Directories.OrderBy(p => p.DirectoryName).ToList();
            CategoryType.Insert(0, new Directory { DirectoryName = "Все типы" });
            comboBoxCat.DataSource = CategoryType;
            comboBoxCat.DisplayMember = "DirectoryName";
            comboBoxCat.ValueMember = "DirectoryId";
        }

        // Метод загрузки данных о товаре в таблицу
        private void LoadAndInitData()
        {
            // Получение данных из бд
            var currentGoods = Auction_BAAEntities.GetContext().Goods.Join
            (Auction_BAAEntities.GetContext().Directories, p => p.GoodSellId, t => t.DirectoryId,
            (p, t) => new { p.GoodName, p.YearOfIssue, p.Owner, p.AssessedValue, t.DirectoryName, p.GoodSellId }).ToList();

            // В качестве источника данных присваиваем список
            dataGridViewGood.DataSource = currentGoods;

            // Убираем вывод id
            dataGridViewGood.Columns[5].Visible = false;

            // Загаловки столбцов
            dataGridViewGood.Columns[0].HeaderText = "Название";
            dataGridViewGood.Columns[1].HeaderText = "Год выпуска";
            dataGridViewGood.Columns[2].HeaderText = "Владелец";
            dataGridViewGood.Columns[3].HeaderText = "Оценочная стоимость";
            dataGridViewGood.Columns[4].HeaderText = "Название категории";

            // Кол-во товаров
            _itemcount = dataGridViewGood.Rows.Count;
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        private void UpdateData()
        {
            // Получение данных из бд
            var currentGoods = Auction_BAAEntities.GetContext().Goods.Join
            (Auction_BAAEntities.GetContext().Directories, p => p.GoodSellId, t => t.DirectoryId,
            (p, t) => new { p.GoodName, p.YearOfIssue, p.Owner, p.AssessedValue, t.DirectoryName, p.GoodSellId }).ToList();

            // Выбор только тех товаров, которые принадлежат данной категории
            if (comboBoxCat.SelectedIndex > 0)
                currentGoods = currentGoods.Where(y => y.GoodSellId == (comboBoxCat.SelectedItem as Directory).DirectoryId).ToList();

            // Выбор тех товаров, в названии которых есть поисковая строка
            currentGoods = currentGoods.Where(p => p.GoodName.ToLower().Contains(textBoxNameGood.Text.ToLower())).ToList();

            // Сортировка
            if (comboBoxSort.SelectedIndex >= 0)
            {
                // Сортировка по возростанию даты 
                if (comboBoxSort.SelectedIndex == 0)
                    currentGoods = currentGoods.OrderBy(p => p.YearOfIssue).ToList();

                // Сортировка по убыванию даты 
                if (comboBoxSort.SelectedIndex == 1)
                    currentGoods = currentGoods.OrderByDescending(p => p.YearOfIssue).ToList();

                // Сортировка по названию
                if (comboBoxSort.SelectedIndex == 2)
                    currentGoods = currentGoods.OrderBy(p => p.GoodName).ToList();
            }

            try
            {
                // Сортировка по возростанию оценочной стоимости
                if (radioButtonMax.Checked == true)
                {
                    int i = Convert.ToInt32(textBoxFil.Text);
                    currentGoods = currentGoods.Where(p => p.AssessedValue > i).ToList();
                }

                // Сортировка по убыванию оценочной стоимости
                if (radioButtonMin.Checked == true)
                {
                    int i = Convert.ToInt32(textBoxFil.Text);
                    currentGoods = currentGoods.Where(p => p.AssessedValue < i).ToList();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

            // В качестве источника данных присваиваем список
            dataGridViewGood.DataSource = currentGoods;

            // Убираем вывод id
            dataGridViewGood.Columns[5].Visible = false;

            // Отображение кол-ва записей
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount}";
        }

        private void UpdateData2()
        {
            // Получение данных из бд
            var currentGoods = Auction_BAAEntities.GetContext().Goods.Join
            (Auction_BAAEntities.GetContext().Directories, p => p.GoodSellId, t => t.DirectoryId,
            (p, t) => new { p.GoodName, p.YearOfIssue, p.Owner, p.AssessedValue, t.DirectoryName, p.GoodSellId }).ToList();

            textBoxFil.Clear();
            textBoxNameGood.Clear();
            comboBoxCat.Text = "Все типы";
            comboBoxSort.Text = "";
            radioButtonMax.Checked = false;
            radioButtonMin.Checked = false;
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

        private void textBoxNameGood_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void radioButtonMax_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void radioButtonMin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            UpdateData2();
        }
    }
}
