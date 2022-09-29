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
    public partial class EditSer : Form
    {
        private string Id;
        public EditSer(string id)
        {
            InitializeComponent();
            TypeFunc();
            PassportFunc();

            var cn = ConnectionString.Connect();
            var sql = @"SELECT S.Код_сертификата AS [Код сертификата], S.Код_сотрудника,
S.Номер_сертификата AS [Номер сертификата], S.Дата_начала_действия AS [Дата начала действия], 
S.Дата_окончания_действия AS [Дата окончания действия], T.Тип_сертификата AS [Тип сертификата]
FROM Сертификаты AS S
JOIN Типы_сертификатов AS T ON T.Код_типа_сертификата = S.Код_типа_сертификата
JOIN Сотрудники AS U ON U.Код_сотрудника = S.Код_сотрудника
WHERE S.Код_сертификата = @id;";
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id.ToString());

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Number.Text = dr[2].ToString();
                DateStart.Text = dr[3].ToString();
                DateEnd.Text = dr[4].ToString();
                Passport.Text = dr[1].ToString();
                Type.Text = dr[4].ToString();
            }

            Id = id;
        }

        private void TypeFunc()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Тип_сертификата FROM Типы_сертификатов;";
            var cmd = new SqlCommand(sql, cn);
            var adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Type.DataSource = ds.Tables[0];
            Type.DisplayMember = "Тип_сертификата";
        }

        private void PassportFunc()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Серия_номер_паспорта FROM Сотрудники;";
            var cmd = new SqlCommand(sql, cn);
            var adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Passport.DataSource = ds.Tables[0];
            Passport.DisplayMember = "Серия_номер_паспорта";
        }

        private int GetTypeId(string val)
        {
            var dict = new Dictionary<string, int>();
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Код_типа_сертификата, Тип_сертификата FROM Типы_сертификатов;";
            var cmd = new SqlCommand(sql, cn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dict.Add(dr[1].ToString(), Convert.ToInt32(dr[0]));
            }

            foreach (var v in dict)
                if (v.Key == val)
                    return v.Value;

            MessageBox.Show("Ошибка, такого значения нет", "Ошибка");
            return 1;
        }

        private int GetPassportId(string val)
        {
            var dict = new Dictionary<string, int>();
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Код_сотрудника, Серия_номер_паспорта FROM Сотрудники;";
            var cmd = new SqlCommand(sql, cn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dict.Add(dr[1].ToString(), Convert.ToInt32(dr[0]));
            }

            foreach (var v in dict)
                if (v.Key == val)
                    return v.Value;

            MessageBox.Show("Ошибка, такого значения нет", "Ошибка");
            return 1;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Number.Text == "")
                {
                    MessageBox.Show("Введите номер сертификата", "Ошибка");
                    return;
                }
                if (DateStart.Text == DateStart.Mask)
                {
                    MessageBox.Show("Введите дату начала действия сертификата", "Ошибка");
                    return;
                }
                if (DateEnd.Text == DateEnd.Mask)
                {
                    MessageBox.Show("Введите дату окончания действия сертификата", "Ошибка");
                    return;
                }
                var cn = ConnectionString.Connect();
                var sql = @"UPDATE Сертификаты SET Номер_сертификата = @Number, Дата_начала_действия = @DateStart, 
Дата_окончания_действия = @DateEnd, Код_сотрудника = @Passport, Код_типа_сертификата = @Type
WHERE Код_сертификата = @id;";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@Number", Number.Text);
                cmd.Parameters.AddWithValue("@DateStart", DateStart.Text);
                cmd.Parameters.AddWithValue("@DateEnd", DateEnd.Text);
                cmd.Parameters.AddWithValue("@Passport", GetPassportId(Passport.Text));
                cmd.Parameters.AddWithValue("@Type", GetTypeId(Type.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
        }
    }
}
