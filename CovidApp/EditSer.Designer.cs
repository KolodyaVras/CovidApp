
namespace CovidApp
{
    partial class EditSer
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
            this.Passport = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateStart = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passport
            // 
            this.Passport.FormattingEnabled = true;
            this.Passport.Location = new System.Drawing.Point(187, 90);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(202, 21);
            this.Passport.TabIndex = 23;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(268, 158);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(121, 47);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(187, 117);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(202, 21);
            this.Type.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Тип сертификата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Паспортные данные сотрудника:";
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(187, 64);
            this.DateEnd.Mask = "00/00/0000";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(202, 20);
            this.DateEnd.TabIndex = 18;
            this.DateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата окончания действия:";
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(187, 38);
            this.DateStart.Mask = "00/00/0000";
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(202, 20);
            this.DateStart.TabIndex = 16;
            this.DateStart.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата начала действия:";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(187, 12);
            this.Number.Mask = "0000 0000 0000 0000";
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(202, 20);
            this.Number.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номер сертификата:";
            // 
            // EditSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 222);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label1);
            this.Name = "EditSer";
            this.Text = "Изменение сертификата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Passport;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox DateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Number;
        private System.Windows.Forms.Label label1;
    }
}