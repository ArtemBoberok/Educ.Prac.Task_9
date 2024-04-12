namespace BAA_Task_9
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonCan = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonGuest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вход в систему";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAA_Task_9.Properties.Resources.Dimond;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Image = global::BAA_Task_9.Properties.Resources.vision;
            this.pictureBoxShow.Location = new System.Drawing.Point(333, 207);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 16;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            // 
            // buttonCan
            // 
            this.buttonCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCan.Location = new System.Drawing.Point(207, 269);
            this.buttonCan.Name = "buttonCan";
            this.buttonCan.Size = new System.Drawing.Size(99, 34);
            this.buttonCan.TabIndex = 15;
            this.buttonCan.Text = "Отмена";
            this.buttonCan.UseVisualStyleBackColor = true;
            this.buttonCan.Click += new System.EventHandler(this.buttonCan_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(91, 269);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(99, 34);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Image = global::BAA_Task_9.Properties.Resources.unvision;
            this.pictureBoxHide.Location = new System.Drawing.Point(333, 207);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHide.TabIndex = 13;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Visible = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPas.Location = new System.Drawing.Point(170, 207);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(155, 32);
            this.textBoxPas.TabIndex = 12;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(170, 153);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(192, 32);
            this.textBoxLog.TabIndex = 11;
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPas.Location = new System.Drawing.Point(75, 210);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(89, 26);
            this.labelPas.TabIndex = 10;
            this.labelPas.Text = "Пароль";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(92, 156);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(72, 26);
            this.labelLog.TabIndex = 9;
            this.labelLog.Text = "Логин";
            // 
            // buttonGuest
            // 
            this.buttonGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuest.Location = new System.Drawing.Point(324, 269);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(99, 34);
            this.buttonGuest.TabIndex = 17;
            this.buttonGuest.Text = "Гость";
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.buttonCan);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button buttonCan;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonGuest;
    }
}

