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
    public partial class EditUsr : Form
    {
        string Id;
        public EditUsr(string id)
        {
            InitializeComponent();
            GenderFunc();
            SectorFunc();
            QualFunc();

            var cn = ConnectionString.Connect();
            var sql = @"SELECT U.Код_сотрудника AS [Код сотрудника], U.ФИО_сотрудника AS [ФИО], 
		U.Дата_рождения AS [Дата рождения], U.Серия_номер_паспорта AS [Паспорт], U.Email, 
		G.Пол,	Q.Квалификация, D.Наименование_участка AS [Наименование участка]
FROM Сотрудники AS U
JOIN Пол AS G ON G.Код_пола = U.Код_пола
JOIN Квалификации AS Q ON Q.Код_квалификации = U.Код_квалификации
JOIN Участки_организации AS D ON D.Код_участка = U.Код_участка
WHERE U.Код_сотрудника = @id;";
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name.Text = dr[1].ToString();
                Birthdate.Text = dr[2].ToString();
                Gender.Text = dr[5].ToString();
                Passport.Text = dr[3].ToString();
                Email.Text = dr[4].ToString();
                Sector.Text = dr[7].ToString();
                Qual.Text = dr[6].ToString();
            }

            Id = id;
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
                var sql = @"UPDATE Сотрудники
SET ФИО_сотрудника = @Name, Дата_рождения = @BirthDate,
Код_пола = @Gender, Серия_номер_паспорта = @Passport,
Email = @Email, Код_участка = @Sector,
Код_квалификации = @Qual, Администратор = @Admin
WHERE Код_сотрудника = @id;";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", Id);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
        }
    }
}
