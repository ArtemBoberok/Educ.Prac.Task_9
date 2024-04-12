namespace BAA_Task_9.Forms
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStripRole = new System.Windows.Forms.Label();
            this.labelStripName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNameGood = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.labelCountGood = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.textBoxFil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonMain);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 2;
            // 
            // buttonMain
            // 
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMain.Location = new System.Drawing.Point(552, 9);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(129, 37);
            this.buttonMain.TabIndex = 9;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
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
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(181, 428);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(47, 13);
            this.labelRole.TabIndex = 19;
            this.labelRole.Text = "Статус: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(0, 428);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Пользователь: ";
            // 
            // labelStripRole
            // 
            this.labelStripRole.AutoSize = true;
            this.labelStripRole.Location = new System.Drawing.Point(234, 428);
            this.labelStripRole.Name = "labelStripRole";
            this.labelStripRole.Size = new System.Drawing.Size(0, 13);
            this.labelStripRole.TabIndex = 17;
            // 
            // labelStripName
            // 
            this.labelStripName.AutoSize = true;
            this.labelStripName.Location = new System.Drawing.Point(92, 428);
            this.labelStripName.Name = "labelStripName";
            this.labelStripName.Size = new System.Drawing.Size(0, 13);
            this.labelStripName.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNameGood);
            this.panel2.Controls.Add(this.comboBoxSort);
            this.panel2.Controls.Add(this.comboBoxCat);
            this.panel2.Controls.Add(this.labelCountGood);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 20;
            // 
            // textBoxNameGood
            // 
            this.textBoxNameGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameGood.Location = new System.Drawing.Point(356, 9);
            this.textBoxNameGood.Name = "textBoxNameGood";
            this.textBoxNameGood.Size = new System.Drawing.Size(198, 26);
            this.textBoxNameGood.TabIndex = 7;
            this.textBoxNameGood.TextChanged += new System.EventHandler(this.textBoxNameGood_TextChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "по возростанию года выпуска",
            "по убыванию года выпуска",
            "по названию"});
            this.comboBoxSort.Location = new System.Drawing.Point(560, 41);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSort.TabIndex = 6;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(188, 41);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(200, 28);
            this.comboBoxCat.TabIndex = 5;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // labelCountGood
            // 
            this.labelCountGood.AutoSize = true;
            this.labelCountGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountGood.Location = new System.Drawing.Point(12, 80);
            this.labelCountGood.Name = "labelCountGood";
            this.labelCountGood.Size = new System.Drawing.Size(138, 17);
            this.labelCountGood.TabIndex = 3;
            this.labelCountGood.Text = "Результат запроса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(432, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Сортировка по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите наименование товара для поиска";
            // 
            // dataGridViewGood
            // 
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewGood.Location = new System.Drawing.Point(0, 157);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.Size = new System.Drawing.Size(548, 267);
            this.dataGridViewGood.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.radioButtonMin);
            this.panel3.Controls.Add(this.radioButtonMax);
            this.panel3.Controls.Add(this.textBoxFil);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(554, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 267);
            this.panel3.TabIndex = 22;
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMin.Location = new System.Drawing.Point(156, 32);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(79, 21);
            this.radioButtonMin.TabIndex = 11;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "Меньше";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            this.radioButtonMin.CheckedChanged += new System.EventHandler(this.radioButtonMin_CheckedChanged);
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMax.Location = new System.Drawing.Point(73, 32);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(77, 21);
            this.radioButtonMax.TabIndex = 10;
            this.radioButtonMax.TabStop = true;
            this.radioButtonMax.Text = "Больше";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            this.radioButtonMax.CheckedChanged += new System.EventHandler(this.radioButtonMax_CheckedChanged);
            // 
            // textBoxFil
            // 
            this.textBoxFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFil.Location = new System.Drawing.Point(6, 32);
            this.textBoxFil.Name = "textBoxFil";
            this.textBoxFil.Size = new System.Drawing.Size(61, 23);
            this.textBoxFil.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Фильтр по оценочной стоимости:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(50, 77);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 26);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отменить фильтры";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewGood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStripRole);
            this.Controls.Add(this.labelStripName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStripRole;
        private System.Windows.Forms.Label labelStripName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNameGood;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label labelCountGood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewGood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFil;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.Button buttonCancel;
    }
}