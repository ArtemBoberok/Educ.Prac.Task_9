using System;
using System.Windows.Forms;

namespace BAA_Task_9.Forms
{
    public partial class MainForm : Form
    {
        public MainForm(string userRole, string name)
        {
            InitializeComponent();
            labelStripRole.Text += userRole;
            labelStripName.Text += name;

            if (userRole == "Гость")
            {
                buttonSales.Visible = false;
            }
        }
        
        private void buttonSales_Click(object sender, EventArgs e)
        {
            string userName = labelStripName.Text;
            string role = labelStripRole.Text;
            Sales sales = new Sales(role, userName);
            sales.Owner = this;
            sales.Show();
            this.Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            string userName = labelStripName.Text;
            string role = labelStripRole.Text;
            Items items = new Items(role, userName);
            items.Owner = this;
            items.Show();
            this.Hide();
        }

        private void buttonСontacts_Click(object sender, EventArgs e)
        {
            string userName = labelStripName.Text;
            string role = labelStripRole.Text;
            Сontacts contacts = new Сontacts(role, userName);
            contacts.Owner = this;
            contacts.Show();
            this.Hide();
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
    }
}
