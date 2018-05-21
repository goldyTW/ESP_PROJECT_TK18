using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TOPSUSTIOT2
{
    public partial class Form1 : Form
    {
        MySqlConnection connectionMySql;

        bool statusServer = false;
        string server = "localhost";
        string database = "topsus_iot";
        string uid = "irfan";
        string pass = "";
        string conString;
        int checkCounter = 0;
        int timeCounter = 0;
        int filesCnt = 0;
        int loopProg = 0;

        public void sqlInsert (int temp, int humidity)
        {
            try
            {
                MySqlCommand cmd = connectionMySql.CreateCommand();
                cmd.CommandText = "INSERT INTO data (device_id, temperature, humidity) VALUE(2, @temp, @humidity)";
                cmd.Parameters.AddWithValue("@temp", temp);
                cmd.Parameters.AddWithValue("@humidity", humidity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
                throw;
            }
        }

        public bool sqlClose()
        {
            try
            {
                connectionMySql.Close();
                return true;
                label4.Text = "Disconnected";
                label4.ForeColor = System.Drawing.Color.Red;
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool sqlOpen()
        {
            try
            {
                connectionMySql.Open();
                label4.Text = "Connected";
                label4.ForeColor = System.Drawing.Color.Lime;
                return true;
            }
            catch (MySqlException mx)
            {
                switch (mx.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                }
                return false;
            }

        }

        public Form1()
        {
            InitializeComponent();
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            connectionMySql = new MySqlConnection(conString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusServer = false;
            sqlOpen();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            sqlInsert((int)temperature.Value, (int)humidity.Value);
        }
        
    }
}
