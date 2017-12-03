using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                SelectData(textBox1.Text);
            }
        }

        private void SelectData(string selectCommandText)
        {
            try
            {
                string selectConnection = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(localdb)\MSSQLLocalDB";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, selectConnection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
