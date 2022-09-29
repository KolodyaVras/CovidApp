
namespace CovidApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.войтиКакАдминистраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ываToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеСертификатамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.отчетИсторияВакцинацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.управлениеСертификатамиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиКакАдминистраторToolStripMenuItem,
            this.ываToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // войтиКакАдминистраторToolStripMenuItem
            // 
            this.войтиКакАдминистраторToolStripMenuItem.Name = "войтиКакАдминистраторToolStripMenuItem";
            this.войтиКакАдминистраторToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.войтиКакАдминистраторToolStripMenuItem.Text = "Войти как администратор";
            this.войтиКакАдминистраторToolStripMenuItem.Click += new System.EventHandler(this.войтиКакАдминистраторToolStripMenuItem_Click);
            // 
            // ываToolStripMenuItem
            // 
            this.ываToolStripMenuItem.Name = "ываToolStripMenuItem";
            this.ываToolStripMenuItem.Size = new System.Drawing.Size(213, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеСертификатамиToolStripMenuItem
            // 
            this.управлениеСертификатамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСертификатToolStripMenuItem,
            this.просмотретьСертификатToolStripMenuItem,
            this.отчетИсторияВакцинацииToolStripMenuItem});
            this.управлениеСертификатамиToolStripMenuItem.Name = "управлениеСертификатамиToolStripMenuItem";
            this.управлениеСертификатамиToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.управлениеСертификатамиToolStripMenuItem.Text = "Управление сертификатами";
            // 
            // добавитьСертификатToolStripMenuItem
            // 
            this.добавитьСертификатToolStripMenuItem.Name = "добавитьСертификатToolStripMenuItem";
            this.добавитьСертификатToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.добавитьСертификатToolStripMenuItem.Text = "Добавить сертификат";
            this.добавитьСертификатToolStripMenuItem.Click += new System.EventHandler(this.добавитьСертификатToolStripMenuItem_Click);
            // 
            // просмотретьСертификатToolStripMenuItem
            // 
            this.просмотретьСертификатToolStripMenuItem.Name = "просмотретьСертификатToolStripMenuItem";
            this.просмотретьСертификатToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.просмотретьСертификатToolStripMenuItem.Text = "Просмотреть сертификаты";
            this.просмотретьСертификатToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСертификатToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // InpId
            // 
            this.InpId.Location = new System.Drawing.Point(180, 27);
            this.InpId.Name = "InpId";
            this.InpId.Size = new System.Drawing.Size(100, 20);
            this.InpId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите свой код сотрудника:";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(286, 26);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(126, 21);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "Идентифицироваться";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // отчетИсторияВакцинацииToolStripMenuItem
            // 
            this.отчетИсторияВакцинацииToolStripMenuItem.Name = "отчетИсторияВакцинацииToolStripMenuItem";
            this.отчетИсторияВакцинацииToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.отчетИсторияВакцинацииToolStripMenuItem.Text = "Отчет \"История вакцинации\"";
            this.отчетИсторияВакцинацииToolStripMenuItem.Click += new System.EventHandler(this.отчетИсторияВакцинацииToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 562);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InpId);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem войтиКакАдминистраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ываToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеСертификатамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСертификатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСертификатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.TextBox InpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ToolStripMenuItem отчетИсторияВакцинацииToolStripMenuItem;
    }
}