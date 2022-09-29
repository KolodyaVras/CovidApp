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

namespace CovidApp
{    
    public partial class ViewSert : Form
    {
        MainForm mainForm = (MainForm)ActiveForm;
        int id = 0;

        private void Show()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT S.Код_сертификата AS [Код сертификата], U.ФИО_сотрудника AS [ФИО],
S.Номер_сертификата AS [Номер сертификата], S.Дата_начала_действия AS [Дата начала действия], 
S.Дата_окончания_действия AS [Дата окончания действия], T.Тип_сертификата AS [Тип сертификата]
FROM Сертификаты AS S
JOIN Типы_сертификатов AS T ON T.Код_типа_сертификата = S.Код_типа_сертификата
JOIN Сотрудники AS U ON U.Код_сотрудника = S.Код_сотрудника;";
            var cmd = new SqlCommand(sql, cn);
            var dt1 = new DataTable();
            var adapt1 = new SqlDataAdapter(cmd);
            adapt1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void ShowForUser()
        {
            {
                var cn = ConnectionString.Connect();
                var sql = @"SELECT S.Код_сертификата AS [Код сертификата], U.ФИО_сотрудника AS [ФИО],
S.Номер_сертификата AS [Номер сертификата], S.Дата_начала_действия AS [Дата начала действия], 
S.Дата_окончания_действия AS [Дата окончания действия], T.Тип_сертификата AS [Тип сертификата]
FROM Сертификаты AS S
JOIN Типы_сертификатов AS T ON T.Код_типа_сертификата = S.Код_типа_сертификата
JOIN Сотрудники AS U ON U.Код_сотрудника = S.Код_сотрудника
WHERE S.Код_сотрудника = @id;";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id.ToString());
                var dt1 = new DataTable();
                var adapt1 = new SqlDataAdapter(cmd);
                adapt1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
        }

        public ViewSert()
        {
            InitializeComponent();
            Show();
        }

        public ViewSert(MainForm mainForm)
        {
            InitializeComponent();
            id = mainForm.id;
            ShowForUser();            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (UInt32.TryParse(textBox1.Text, out uint check))
            {
                var sql = @"DELETE FROM Сертификаты WHERE Сертификаты.Код_сертификата = @id;";
                var cmd = new SqlCommand(sql, ConnectionString.Connect());
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                if (id == 0)
                    Show();
                else
                    ShowForUser();
            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var frm = new EditSer(textBox1.Text);
            frm.Show();
        }
    }
}
