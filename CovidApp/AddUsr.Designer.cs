
namespace CovidApp
{
    partial class AddUsr
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AsAdm = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Sector = new System.Windows.Forms.ComboBox();
            this.Qual = new System.Windows.Forms.ComboBox();
            this.Birthdate = new System.Windows.Forms.MaskedTextBox();
            this.Passport = new System.Windows.Forms.MaskedTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(167, 12);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(167, 20);
            this.Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Паспортные данные:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 116);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(167, 20);
            this.Email.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Участок:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Квалификация:";
            // 
            // AsAdm
            // 
            this.AsAdm.AutoSize = true;
            this.AsAdm.Location = new System.Drawing.Point(30, 208);
            this.AsAdm.Name = "AsAdm";
            this.AsAdm.Size = new System.Drawing.Size(105, 17);
            this.AsAdm.TabIndex = 15;
            this.AsAdm.Text = "Администратор";
            this.AsAdm.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(167, 63);
            this.Gender.MaxDropDownItems = 2;
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(167, 21);
            this.Gender.TabIndex = 16;
            // 
            // Sector
            // 
            this.Sector.FormattingEnabled = true;
            this.Sector.Location = new System.Drawing.Point(167, 142);
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(167, 21);
            this.Sector.TabIndex = 17;
            // 
            // Qual
            // 
            this.Qual.FormattingEnabled = true;
            this.Qual.Location = new System.Drawing.Point(167, 168);
            this.Qual.Name = "Qual";
            this.Qual.Size = new System.Drawing.Size(167, 21);
            this.Qual.TabIndex = 18;
            // 
            // Birthdate
            // 
            this.Birthdate.Location = new System.Drawing.Point(167, 39);
            this.Birthdate.Mask = "00/00/0000";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(167, 20);
            this.Birthdate.TabIndex = 19;
            this.Birthdate.ValidatingType = typeof(System.DateTime);
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(167, 91);
            this.Passport.Mask = "0000 000000";
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(167, 20);
            this.Passport.TabIndex = 20;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(167, 201);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(167, 29);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 237);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Qual);
            this.Controls.Add(this.Sector);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.AsAdm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            //this.Name = "AddUsr";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AsAdm;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.ComboBox Sector;
        private System.Windows.Forms.ComboBox Qual;
        private System.Windows.Forms.MaskedTextBox Birthdate;
        private System.Windows.Forms.MaskedTextBox Passport;
        private System.Windows.Forms.Button AddBtn;
    }
}