namespace саша1с
{
    partial class aftor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aftor));
            this.entrbtn = new System.Windows.Forms.Button();
            this.Logine = new System.Windows.Forms.Label();
            this.Parole = new System.Windows.Forms.Label();
            this.vhidbtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.registrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // entrbtn
            // 
            this.entrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.entrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.entrbtn.ForeColor = System.Drawing.Color.Black;
            this.entrbtn.Location = new System.Drawing.Point(73, 307);
            this.entrbtn.Name = "entrbtn";
            this.entrbtn.Size = new System.Drawing.Size(129, 34);
            this.entrbtn.TabIndex = 0;
            this.entrbtn.Text = "Вход";
            this.entrbtn.UseVisualStyleBackColor = false;
            this.entrbtn.Click += new System.EventHandler(this.entrbtn_Click);
            // 
            // Logine
            // 
            this.Logine.AutoSize = true;
            this.Logine.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logine.ForeColor = System.Drawing.Color.Black;
            this.Logine.Location = new System.Drawing.Point(69, 154);
            this.Logine.Name = "Logine";
            this.Logine.Size = new System.Drawing.Size(58, 23);
            this.Logine.TabIndex = 1;
            this.Logine.Text = "Логин";
            // 
            // Parole
            // 
            this.Parole.AutoSize = true;
            this.Parole.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parole.ForeColor = System.Drawing.Color.Black;
            this.Parole.Location = new System.Drawing.Point(69, 217);
            this.Parole.Name = "Parole";
            this.Parole.Size = new System.Drawing.Size(69, 23);
            this.Parole.TabIndex = 2;
            this.Parole.Text = "Пароль";
            // 
            // vhidbtn
            // 
            this.vhidbtn.AutoSize = true;
            this.vhidbtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vhidbtn.ForeColor = System.Drawing.Color.Black;
            this.vhidbtn.Location = new System.Drawing.Point(136, 73);
            this.vhidbtn.Name = "vhidbtn";
            this.vhidbtn.Size = new System.Drawing.Size(167, 29);
            this.vhidbtn.TabIndex = 3;
            this.vhidbtn.Text = "Вход в систему";
            this.vhidbtn.Click += new System.EventHandler(this.vhidbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.pictureBox2.Location = new System.Drawing.Point(-30, -23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 52);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBox1.Location = new System.Drawing.Point(154, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 30);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.textBox2.Location = new System.Drawing.Point(154, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(135, 30);
            this.textBox2.TabIndex = 8;
            // 
            // registrbtn
            // 
            this.registrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.registrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.registrbtn.ForeColor = System.Drawing.Color.Black;
            this.registrbtn.Location = new System.Drawing.Point(262, 307);
            this.registrbtn.Name = "registrbtn";
            this.registrbtn.Size = new System.Drawing.Size(129, 34);
            this.registrbtn.TabIndex = 9;
            this.registrbtn.Text = "Регистрация";
            this.registrbtn.UseVisualStyleBackColor = false;
            // 
            // aftor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 387);
            this.Controls.Add(this.registrbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.vhidbtn);
            this.Controls.Add(this.Parole);
            this.Controls.Add(this.Logine);
            this.Controls.Add(this.entrbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aftor";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.aftor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrbtn;
        private System.Windows.Forms.Label Logine;
        private System.Windows.Forms.Label Parole;
        private System.Windows.Forms.Label vhidbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button registrbtn;
    }
}

