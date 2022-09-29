
namespace CovidApp
{
    partial class AddSer
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
            this.Number = new System.Windows.Forms.MaskedTextBox();
            this.DateStart = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateEnd = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Passport = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер сертификата:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(190, 10);
            this.Number.Mask = "0000 0000 0000 0000";
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(202, 20);
            this.Number.TabIndex = 1;
            this.Number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Number_MaskInputRejected);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(190, 36);
            this.DateStart.Mask = "00/00/0000";
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(202, 20);
            this.DateStart.TabIndex = 3;
            this.DateStart.ValidatingType = typeof(System.DateTime);
            this.DateStart.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DateStart_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата начала действия:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(190, 62);
            this.DateEnd.Mask = "00/00/0000";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(202, 20);
            this.DateEnd.TabIndex = 5;
            this.DateEnd.ValidatingType = typeof(System.DateTime);
            this.DateEnd.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DateEnd_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата окончания действия:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Паспортные данные сотрудника:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип сертификата:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(190, 115);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(202, 21);
            this.Type.TabIndex = 9;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(271, 156);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 47);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Passport
            // 
            this.Passport.FormattingEnabled = true;
            this.Passport.Location = new System.Drawing.Point(190, 88);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(202, 21);
            this.Passport.TabIndex = 12;
            this.Passport.SelectedIndexChanged += new System.EventHandler(this.Passport_SelectedIndexChanged);
            // 
            // AddSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 222);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label1);
            this.Name = "AddSer";
            this.Text = "Добавление сертификата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Number;
        private System.Windows.Forms.MaskedTextBox DateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox Passport;
    }
}