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
    public partial class AddUsr : Form
    {
        public AddUsr()
        {
            InitializeComponent();
            GenderFunc();
            SectorFunc();
            QualFunc();
        }

        private void GenderFunc()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Пол FROM Пол";
            var cmd = new SqlCommand(sql, cn);
            var adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Gender.DataSource = ds.Tables[0];
            Gender.DisplayMember = "Пол";
        }

        private void SectorFunc()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Наименование_участка FROM Участки_организации";
            var cmd = new SqlCommand(sql, cn);
            var adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Sector.DataSource = ds.Tables[0];
            Sector.DisplayMember = "Наименование_участка";
        }

        private void QualFunc()
        {
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Квалификация FROM Квалификации";
            var cmd = new SqlCommand(sql, cn);
            var adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Qual.DataSource = ds.Tables[0];
            Qual.DisplayMember = "Квалификация";
        }

        private int GetGenderId(string val)
        {
            var dict = new Dictionary<string, int>();
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Код_пола, Пол FROM Пол";
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

        private int GetSectorId(string val)
        {
            var dict = new Dictionary<string, int>();
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Код_участка, Наименование_участка FROM Участки_организации";
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

        private int GetQualId(string val)
        {
            var dict = new Dictionary<string, int>();
            var cn = ConnectionString.Connect();
            var sql = @"SELECT Код_квалификации, Квалификация FROM Квалификации";
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
                if (Name.Text == "")
                {
                    MessageBox.Show("Введите ФИО", "Ошибка");
                    return;
                }
                if (Birthdate.Text == Birthdate.Mask)
                {
                    MessageBox.Show("Введите дату рождения", "Ошибка");
                    return;
                }
                if (Passport.Text == Passport.Mask)
                {
                    MessageBox.Show("Введите паспортные данные", "Ошибка");
                    return;
                }
                var cn = ConnectionString.Connect();
                var sql = @"INSERT INTO Сотрудники (ФИО_сотрудника, Дата_рождения, Код_пола, Серия_номер_паспорта, Email, Код_участка, Код_квалификации, Администратор)
VALUES (@Name, @BirthDate, @Gender, @Passport, @Email, @Sector, @Qual, @Admin);";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Name", Name.Text);
                cmd.Parameters.AddWithValue("@BirthDate", Birthdate.Text);
                cmd.Parameters.AddWithValue("@Gender", GetGenderId(Gender.Text));
                cmd.Parameters.AddWithValue("@Passport", Passport.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Sector", GetSectorId(Sector.Text));
                cmd.Parameters.AddWithValue("@Qual", GetQualId(Qual.Text));
                cmd.Parameters.AddWithValue("@Admin", AsAdm.Checked);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
        }
    }
}
