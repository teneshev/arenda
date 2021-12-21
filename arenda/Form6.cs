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
    public partial class Form6 : Form
    {
        static string constr = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
        string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Штрафы по прокату].Наименование_штрафа , [Выданные автомобили].Итоговая_сумма FROM [Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки JOIN [Штрафы по прокату] on [Штрафы по прокату].Код_штрафа = [Выданные автомобили].Штрафы";
        DataContext cont = new DataContext(constr);
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "Insert into [Выданные автомобили] ([Код_клиента], [Код_авто], [Дата_выдачи], [Количество_дней], [Ожидаемая_дата_возрата], [Наименование_скидки], [Сумма], [Штрафы], [Итоговая_сумма])  values ( '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "' )";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables["[Выданные автомобили]"];

            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-1PNR289;Initial Catalog=arenda;Integrated Security=True";
            string sql = "SELECT [Выданные автомобили].Код_проката, Клиенты.ФИО, Автомобили.Госномер, [Выданные автомобили].Дата_выдачи, [Выданные автомобили].Количество_дней, [Выданные автомобили].Ожидаемая_дата_возрата, [Система скидок].Наименование_скидки, [Выданные автомобили].Сумма, [Штрафы по прокату].Наименование_штрафа , [Выданные автомобили].Итоговая_сумма FROM [Выданные автомобили] JOIN Клиенты on Клиенты.Код_клиента = [Выданные автомобили].Код_клиента JOIN Автомобили on Автомобили.Код_авто = [Выданные автомобили].Код_авто JOIN[Система скидок] on [Система скидок].Код_скидки = [Выданные автомобили].Наименование_скидки JOIN [Штрафы по прокату] on [Штрафы по прокату].Код_штрафа = [Выданные автомобили].Штрафы";
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
