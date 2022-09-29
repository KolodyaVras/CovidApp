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
    public partial class AddSer : Form
    {
        public AddSer()
        {
            InitializeComponent();
            TypeFunc();
            PassportFunc();
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

        private void AddBtn_Click(object sender, EventArgs e)
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
                var sql = @"INSERT INTO Сертификаты (Номер_сертификата, Дата_начала_действия, Дата_окончания_действия, Код_сотрудника, Код_типа_сертификата)
VALUES (@Number, @DateStart, @DateEnd, @Passport, @Type);";
                var cmd = new SqlCommand(sql, cn);
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

        private void Passport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DateEnd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DateStart_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
