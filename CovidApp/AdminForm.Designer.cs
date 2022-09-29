
namespace CovidApp
{
    partial class AdminForm
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
            this.ViewUsersBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.ViewAllSertBtn = new System.Windows.Forms.Button();
            this.AddSertBtn = new System.Windows.Forms.Button();
            this.CreateRepBtn1 = new System.Windows.Forms.Button();
            this.CreateRepBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewUsersBtn
            // 
            this.ViewUsersBtn.Location = new System.Drawing.Point(13, 13);
            this.ViewUsersBtn.Name = "ViewUsersBtn";
            this.ViewUsersBtn.Size = new System.Drawing.Size(135, 45);
            this.ViewUsersBtn.TabIndex = 0;
            this.ViewUsersBtn.Text = "Просмотреть список сотрудников";
            this.ViewUsersBtn.UseVisualStyleBackColor = true;
            this.ViewUsersBtn.Click += new System.EventHandler(this.ViewUsersBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(12, 64);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(135, 45);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "Добавить сотрудника";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // ViewAllSertBtn
            // 
            this.ViewAllSertBtn.Location = new System.Drawing.Point(12, 115);
            this.ViewAllSertBtn.Name = "ViewAllSertBtn";
            this.ViewAllSertBtn.Size = new System.Drawing.Size(135, 45);
            this.ViewAllSertBtn.TabIndex = 3;
            this.ViewAllSertBtn.Text = "Просмотреть все сертификаты";
            this.ViewAllSertBtn.UseVisualStyleBackColor = true;
            this.ViewAllSertBtn.Click += new System.EventHandler(this.ViewAllSertBtn_Click);
            // 
            // AddSertBtn
            // 
            this.AddSertBtn.Location = new System.Drawing.Point(12, 166);
            this.AddSertBtn.Name = "AddSertBtn";
            this.AddSertBtn.Size = new System.Drawing.Size(135, 45);
            this.AddSertBtn.TabIndex = 4;
            this.AddSertBtn.Text = "Добавить сертификат";
            this.AddSertBtn.UseVisualStyleBackColor = true;
            this.AddSertBtn.Click += new System.EventHandler(this.AddSertBtn_Click);
            // 
            // CreateRepBtn1
            // 
            this.CreateRepBtn1.Location = new System.Drawing.Point(12, 217);
            this.CreateRepBtn1.Name = "CreateRepBtn1";
            this.CreateRepBtn1.Size = new System.Drawing.Size(135, 45);
            this.CreateRepBtn1.TabIndex = 5;
            this.CreateRepBtn1.Text = "Создать отчет \"Список вакцинированных\"";
            this.CreateRepBtn1.UseVisualStyleBackColor = true;
            this.CreateRepBtn1.Click += new System.EventHandler(this.CreateRepBtn1_Click);
            // 
            // CreateRepBtn2
            // 
            this.CreateRepBtn2.Location = new System.Drawing.Point(12, 268);
            this.CreateRepBtn2.Name = "CreateRepBtn2";
            this.CreateRepBtn2.Size = new System.Drawing.Size(135, 68);
            this.CreateRepBtn2.TabIndex = 6;
            this.CreateRepBtn2.Text = "Создать отчет \"Список вакцинированных с истекающим сертификатом\"";
            this.CreateRepBtn2.UseVisualStyleBackColor = true;
            this.CreateRepBtn2.Click += new System.EventHandler(this.CreateRepBtn2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 347);
            this.Controls.Add(this.CreateRepBtn2);
            this.Controls.Add(this.CreateRepBtn1);
            this.Controls.Add(this.AddSertBtn);
            this.Controls.Add(this.ViewAllSertBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.ViewUsersBtn);
            this.Name = "AdminForm";
            this.Text = "Меню администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewUsersBtn;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button ViewAllSertBtn;
        private System.Windows.Forms.Button AddSertBtn;
        private System.Windows.Forms.Button CreateRepBtn1;
        private System.Windows.Forms.Button CreateRepBtn2;
    }
}