using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
namespace arenda
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "Insert into Клиенты ([ФИО], [Адрес], [Телефон], [Паспорт]) values ('" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "' )";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Клиенты"];

            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arendaDataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.arendaDataSet1.Клиенты);

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "SELECT * FROM Клиенты";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
