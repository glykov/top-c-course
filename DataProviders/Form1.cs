using System.Configuration;
using System.Data;
using System.Data.Common;

namespace AdoNetDataProviders
{
    public partial class Form1 : Form
    {
        DbConnection _conn;
        DbProviderFactory _factory;
        string providerName;

        public Form1()
        {
            InitializeComponent();
            btnExecute.Enabled = false;
            DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient",
                Microsoft.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySqlConnector",
                MySqlConnector.MySqlConnectorFactory.Instance);
            DbProviderFactories.RegisterFactory("Npgsql",
                Npgsql.NpgsqlFactory.Instance);
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            DataTable t = DbProviderFactories.GetFactoryClasses();
            dataGridView1.DataSource = t;
            comboBox1.Items.Clear();

            foreach (DataRow dr in t.Rows)
            {
                comboBox1.Items.Add(dr["InvariantName"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _factory = DbProviderFactories.GetFactory(comboBox1.SelectedItem.ToString());
            _conn = _factory.CreateConnection();
            providerName = GetConnectionStringByProvider(comboBox1.SelectedItem.ToString());
            txtConnectionString.Text = providerName;
        }

        private string GetConnectionStringByProvider(string providerName)
        {
            return ConfigurationManager.ConnectionStrings
                .Cast<ConnectionStringSettings>()
                .FirstOrDefault(cs => cs.ProviderName == providerName)
                ?.ConnectionString ?? "";
        }

        private void txtRequest_TextChanged(object sender, EventArgs e)
        {
            if (txtRequest.Text.Length > 5)
                btnExecute.Enabled = true;
            else
                btnExecute.Enabled = false;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            _conn.ConnectionString = txtConnectionString.Text;

            DbDataAdapter adapter = _factory.CreateDataAdapter();
            adapter.SelectCommand = _conn.CreateCommand();
            adapter.SelectCommand.CommandText = txtRequest.Text.ToString();

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }
    }
}
