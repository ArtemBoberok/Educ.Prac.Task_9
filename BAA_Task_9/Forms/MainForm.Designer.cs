namespace BAA_Task_9.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStripRole = new System.Windows.Forms.Label();
            this.labelStripName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonContacts);
            this.panel1.Controls.Add(this.buttonSales);
            this.panel1.Controls.Add(this.buttonItems);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 1;
            // 
            // buttonContacts
            // 
            this.buttonContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContacts.Location = new System.Drawing.Point(554, 9);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(127, 37);
            this.buttonContacts.TabIndex = 11;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new System.EventHandler(this.buttonСontacts_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSales.Location = new System.Drawing.Point(284, 9);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(129, 37);
            this.buttonSales.TabIndex = 10;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItems.Location = new System.Drawing.Point(419, 9);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(129, 37);
            this.buttonItems.TabIndex = 9;
            this.buttonItems.Text = "Предметы";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(687, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(101, 37);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Выход";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Аукционер\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAA_Task_9.Properties.Resources.Dimond;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStripRole
            // 
            this.labelStripRole.AutoSize = true;
            this.labelStripRole.Location = new System.Drawing.Point(234, 437);
            this.labelStripRole.Name = "labelStripRole";
            this.labelStripRole.Size = new System.Drawing.Size(0, 13);
            this.labelStripRole.TabIndex = 7;
            // 
            // labelStripName
            // 
            this.labelStripName.AutoSize = true;
            this.labelStripName.Location = new System.Drawing.Point(92, 437);
            this.labelStripName.Name = "labelStripName";
            this.labelStripName.Size = new System.Drawing.Size(0, 13);
            this.labelStripName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(0, 437);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Пользователь: ";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(181, 437);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(47, 13);
            this.labelRole.TabIndex = 9;
            this.labelRole.Text = "Статус: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BAA_Task_9.Properties.Resources.Auction;
            this.pictureBox2.Location = new System.Drawing.Point(13, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(668, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStripRole);
            this.Controls.Add(this.labelStripName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labelStripRole;
        private System.Windows.Forms.Label labelStripName;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}