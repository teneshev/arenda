using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arenda
{
    public partial class edit : Form
    {
        string constr = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        int ID;
        public edit(int service)
        {
            InitializeComponent();
            ID = service;
            cod.ConnectionString = constr;
            cmt.Connection = cod;
        }

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "update Клиенты set ФИО = '" + textBox2.Text + "', Адрес = '" + textBox3.Text + "', Телефон = '" + textBox4.Text + "', Паспорт = '" + textBox5.Text + "'   where Код_клиента = " + ID;
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Измененно");
            Close();
        }
    }
}
