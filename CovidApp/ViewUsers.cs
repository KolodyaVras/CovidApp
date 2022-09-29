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
    public partial class ViewUsers : Form
    {
        private void Show()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT U.Код_сотрудника AS [Код сотрудника], U.ФИО_сотрудника AS [ФИО], 
		U.Дата_рождения AS [Дата рождения], U.Серия_номер_паспорта AS [Паспорт], U.Email, 
		G.Пол,	Q.Квалификация, D.Наименование_участка AS [Наименование участка]
FROM Сотрудники AS U
JOIN Пол AS G ON G.Код_пола = U.Код_пола
JOIN Квалификации AS Q ON Q.Код_квалификации = U.Код_квалификации
JOIN Участки_организации AS D ON D.Код_участка = U.Код_участка;";
            var cmd = new SqlCommand(sql, cn);
            var dt1 = new DataTable();
            var adapt1 = new SqlDataAdapter(cmd);
            adapt1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        public ViewUsers()
        {
            InitializeComponent();
            Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            if (UInt32.TryParse(textBox1.Text, out uint check))
            {
                var frm = new EditUsr(textBox1.Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (UInt32.TryParse(textBox1.Text, out uint check))
            {
                var sql = @"DELETE FROM Сертификаты WHERE Сертификаты.Код_сотрудника = @id;
DELETE FROM Сотрудники WHERE Сотрудники.Код_сотрудника = @id;";
                var cmd = new SqlCommand(sql, ConnectionString.Connect());
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                Show();
            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
