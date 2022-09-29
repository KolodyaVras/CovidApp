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
    public partial class LoginForm : Form
    {
        MainForm mainForm = (MainForm)ActiveForm;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cn = ConnectionString.Connect();
            var sql = @"select Логин_администратора, Пароль_администратора
from Администраторы";
            var cmd = new SqlCommand(sql, cn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
                if (login.Text == dr["Логин_администратора"].ToString())
                    if (password.Text == dr["Пароль_администратора"].ToString())
                    {
                        mainForm.AsAdmin = true;                        
                        MessageBox.Show("Вы успешно вошли как администратор", "Успешно");
                        var frm = new AdminForm();
                        frm.MdiParent = mainForm;
                        frm.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Введен неверный пароль", "Ошибка");
                else
                    MessageBox.Show("Введен неверный логин", "Ошибка");
        }
    }
}
