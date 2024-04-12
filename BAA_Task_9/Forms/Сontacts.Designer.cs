namespace BAA_Task_9.Forms
{
    partial class Сontacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сontacts));
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 82);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Контакт босса: Бобриков А.А. +79876543210\r\nКонтакт горячей линии: +79870123456\r\nА" +
    "дрес: пр. Авиаконструкторов, 28, лит. А, Санкт-Петербург, 197373";
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
            this.buttonMain.Location = new System.Drawing.Point(554, 9);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(127, 37);
            this.buttonMain.TabIndex = 11;
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
            this.labelRole.Location = new System.Drawing.Point(181, 182);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(47, 13);
            this.labelRole.TabIndex = 14;
            this.labelRole.Text = "Статус: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(0, 182);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Пользователь: ";
            // 
            // labelStripRole
            // 
            this.labelStripRole.AutoSize = true;
            this.labelStripRole.Location = new System.Drawing.Point(234, 182);
            this.labelStripRole.Name = "labelStripRole";
            this.labelStripRole.Size = new System.Drawing.Size(0, 13);
            this.labelStripRole.TabIndex = 12;
            // 
            // labelStripName
            // 
            this.labelStripName.AutoSize = true;
            this.labelStripName.Location = new System.Drawing.Point(92, 182);
            this.labelStripName.Name = "labelStripName";
            this.labelStripName.Size = new System.Drawing.Size(0, 13);
            this.labelStripName.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 178);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Сontacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStripRole);
            this.Controls.Add(this.labelStripName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Сontacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контакты";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
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
    }
}