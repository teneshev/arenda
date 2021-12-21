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
    public partial class Form5 : Form
    {
        string constr = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        int ID;
        public Form5(int service)
        {
            InitializeComponent();
            ID = service;
            cod.ConnectionString = constr;
            cmt.Connection = cod;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "update [Выданные автомобили] set Код_клиента = '" + textBox2.Text + "', Код_авто = '" + textBox3.Text + "', Дата_выдачи = '" + textBox4.Text + "', Количество_дней = '" + textBox5.Text + "', Ожидаемая_дата_возрата = '" + textBox6.Text + "', Наименование_скидки = '" + textBox7.Text + "', Сумма = '" + textBox8.Text + "', Штрафы = '" + textBox9.Text + "', Итоговая_сумма = '" + textBox11.Text + "' where [Код_проката]= " + ID;
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Измененно");
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
