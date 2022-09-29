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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ViewUsersBtn_Click(object sender, EventArgs e)
        {
            var frm = new ViewUsers();
            frm.Show();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            var frm = new AddUsr();
            frm.Show();
        }

        private void ViewAllSertBtn_Click(object sender, EventArgs e)
        {
            var frm = new ViewSert();
            frm.Show();
        }

        private void AddSertBtn_Click(object sender, EventArgs e)
        {
            var frm = new AddSer();
            frm.Show();
        }

        private void CreateRepBtn1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app =
        new Microsoft.Office.Interop.Excel.Application();

            app.Visible = true;

            Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets[1];

            var cn = ConnectionString.Connect();
            var cmd = new SqlCommand(@"SELECT Emp.ФИО_сотрудника AS ФИО, Ser.Номер_сертификата AS [Номер сертификата], 
Ser.Дата_начала_действия AS [Дата начала действия сертификата], 
Ser.Дата_окончания_действия AS [Дата окончания действия сертификата], Typ.Тип_сертификата AS [Тип сертификата],
(SELECT COUNT(*) FROM Сертификаты WHERE Сертификаты.Дата_окончания_действия >= GETDATE()) AS 'Всего действующих сертификатов'
FROM Сертификаты AS Ser
JOIN Сотрудники AS Emp ON Emp.Код_сотрудника = Ser.Код_сотрудника 
JOIN Типы_сертификатов As Typ ON Typ.Код_типа_сертификата = Ser.Код_типа_сертификата
WHERE Ser.Дата_окончания_действия >= GETDATE();", cn);

            SqlDataReader reader = cmd.ExecuteReader();

            ws.Cells[1, 1].Value = reader.GetName(0);
            ws.Cells[1, 2].Value = reader.GetName(1);
            ws.Cells[1, 3].Value = reader.GetName(2);
            ws.Cells[1, 4].Value = reader.GetName(3);
            ws.Cells[1, 5].Value = reader.GetName(4);
            //ws.Cells[1, 6].Value = reader.GetName(5);

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
            //ws.Cells[2, 6].Value = reader[5];

            reader.Close();
            cn.Close();
        }

        private void CreateRepBtn2_Click(object sender, EventArgs e)
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
FROM Сертификаты AS Ser
JOIN Сотрудники AS Emp ON Emp.Код_сотрудника = Ser.Код_сотрудника 
JOIN Типы_сертификатов As Typ ON Typ.Код_типа_сертификата = Ser.Код_типа_сертификата
WHERE DAY(GETDATE()) - DAY(Ser.Дата_окончания_действия) <= 30 AND MONTH(Ser.Дата_окончания_действия) = MONTH(GETDATE()) 
AND YEAR(Ser.Дата_окончания_действия) = YEAR(GETDATE())
OR DAY(GETDATE()) + 30 - DAY(Ser.Дата_окончания_действия) >= 30 AND MONTH(Ser.Дата_окончания_действия) - MONTH(GETDATE()) = 1 
AND YEAR(Ser.Дата_окончания_действия) = YEAR(GETDATE())
OR DAY(GETDATE()) + 30 - DAY(Ser.Дата_окончания_действия) >= 30 AND MONTH(Ser.Дата_окончания_действия) = MONTH(GETDATE()) + 11 
AND YEAR(Ser.Дата_окончания_действия) = YEAR(GETDATE()) + 1;", cn);

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
