using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CovidApp
{
    public partial class MainForm : Form
    {
        public int id = 0;
        public bool AsAdmin = false;
        
        public MainForm()
        {
            InitializeComponent();
            просмотретьСертификатToolStripMenuItem.Enabled = false;
            добавитьСертификатToolStripMenuItem.Enabled = false;
            отчетИсторияВакцинацииToolStripMenuItem.Enabled = false;
        }

        private void войтиКакАдминистраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(this);
            loginForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutBox1();
            frmAbout.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void просмотретьСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewSert = new ViewSert(this);
            viewSert.MdiParent = this;
            viewSert.Show();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (InpId.Text == "0")
            {
                MessageBox.Show("Введен 0", "Ошибка");
            }
            else if (UInt32.TryParse(InpId.Text, out uint check))
            {
                id = Convert.ToInt32(InpId.Text);
                просмотретьСертификатToolStripMenuItem.Enabled = true;
                добавитьСертификатToolStripMenuItem.Enabled = true;
                отчетИсторияВакцинацииToolStripMenuItem.Enabled = true;
            }           
            else
            {
                MessageBox.Show("Введено не число", "Ошибка");
                
            }
        }

        private void добавитьСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AddSer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void отчетИсторияВакцинацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app =
        new Microsoft.Office.Interop.Excel.Application();

            app.Visible = true;

            Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets[1];

            var cn = ConnectionString.Connect();
            var cmd = new SqlCommand(@"SELECT Emp.ФИО_сотрудника AS ФИО, Ser.Номер_сертификата AS [Номер сертификата], 
Ser.Дата_начала_действия AS [Дата начала действия сертификата], 
Ser.Дата_окончания_действия AS [Дата окончания действия сертификата], Typ.Тип_сертификата AS [Тип сертификата]
FROM  Сотрудники AS Emp
JOIN Сертификаты AS Ser ON Emp.Код_сотрудника = Ser.Код_сотрудника 
JOIN Типы_сертификатов As Typ ON Typ.Код_типа_сертификата = Ser.Код_типа_сертификата
WHERE Emp.Код_сотрудника = @id;", cn);
            cmd.Parameters.AddWithValue("@id", id.ToString());

            SqlDataReader reader = cmd.ExecuteReader();

            ws.Cells[1, 1].Value = reader.GetName(0);
            ws.Cells[1, 2].Value = reader.GetName(1);
            ws.Cells[1, 3].Value = reader.GetName(2);
            ws.Cells[1, 4].Value = reader.GetName(3);
            ws.Cells[1, 5].Value = reader.GetName(4);

            int i = 2;
            while (reader.Read())
            {
                ws.Cells[i, 1].Value = reader[0];
                ws.Cells[i, 2].Value = reader[1];
                ws.Cells[i, 3].Value = reader[2];
                ws.Cells[i, 4].Value = reader[3];
                ws.Cells[i, 5].Value = reader[4];
                i++;
            }

            reader.Close();
            cn.Close();
        }
    }
}
