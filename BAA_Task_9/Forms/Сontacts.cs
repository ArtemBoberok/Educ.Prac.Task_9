using System;
using System.Windows.Forms;

namespace BAA_Task_9.Forms
{
    public partial class Сontacts : Form
    {
        public Сontacts(string userRole, string name)
        {
            InitializeComponent();
            labelStripRole.Text += userRole;
            labelStripName.Text += name;
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
    }
}
