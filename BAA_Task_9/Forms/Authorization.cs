﻿using BAA_Task_9.Forms;
using BAA_Task_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BAA_Task_9
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Visible = false;
            pictureBoxHide.Visible = true;
            textBoxPas.PasswordChar = '\0';
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Visible = false;
            pictureBoxShow.Visible = true;
            textBoxPas.PasswordChar = '*';
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string username = textBoxLog.Text;
            string password = textBoxPas.Text;
            try
            {
                // Загрузка пользователей из бд в список
                List<User> users = Auction_BAAEntities.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.UserName == username && p.Passwords == password);
                if (u != null)
                {
                    // Логин и пароль 
                    MainForm mainWindow = new MainForm(u.Roles, u.UserName);
                    mainWindow.Owner = this;
                    this.Hide();
                    textBoxPas.Clear();
                    mainWindow.Show();
                }
                else
                    MessageBox.Show("Не верный логин или пароль!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Вы действительно хотите закрыть приложение?",
            "Выйти", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (x == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            string username = "Гость";
            string password = "Гость";

            List<User> users = Auction_BAAEntities.GetContext().Users.ToList();
            User u = users.FirstOrDefault(p => p.UserName == username && p.Passwords == password);
            if (u != null)
            {
                // Логин и пароль 
                MainForm mainWindow = new MainForm(u.Roles, u.UserName);
                mainWindow.Owner = this;
                this.Hide();
                textBoxPas.Clear();
                mainWindow.Show();
            }
            else
                MessageBox.Show("Ошибка!");
        }
    }
}
