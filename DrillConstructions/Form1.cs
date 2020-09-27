using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrillConstructions
{
    public partial class Form1 : Form
    {

        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;
        private string activeConstructionsStorage = "LanguageConstructions";
        private List<Storage> listOfAvailableStorages = new List<Storage>();

        public Form1()
        {
            InitializeComponent();
            LoadData(activeConstructionsStorage);
            GetAvailableStorages();
            LabelCurrentStorage.Text = activeConstructionsStorage;
        }

        private void SetDBConnection()
        {
            sqlConnection = new SQLiteConnection($"Data Source=.\\LanguageConstructions.db; Version=3");
        }

        private void ExecuteQuery(string query)
        {
            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
        }

        private void LoadData(string activeStorage)
        {
            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            string commandText = "SELECT * FROM " + activeStorage;
            DB = new SQLiteDataAdapter(commandText, sqlConnection);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            DataGridBrowseCards.DataSource = sqlDT;
            sqlConnection.Close();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            string tableName = TxtNewTableName.Text;
            string createNewTable = "CREATE TABLE '"+ tableName + "' ('ID' INTEGER NOT NULL UNIQUE," +
            "'Construction'  TEXT NOT NULL UNIQUE," +
            "'Meaning'   TEXT NOT NULL," +
            "'Example'   TEXT NOT NULL," +
            "'Type'  TEXT NOT NULL," +
            "PRIMARY KEY('ID' AUTOINCREMENT));";
            ExecuteQuery(createNewTable);
            GetAvailableStorages();
        }

        private void BtnSelectCurrentStorage_Click(object sender, EventArgs e)
        {
            activeConstructionsStorage = ComboBoxAvailableStorages.Text;
            GetAvailableStorages();
            LoadData(activeConstructionsStorage);
            LabelCurrentStorage.Text = activeConstructionsStorage;
        }

        private void GetAvailableStorages()
        {
            ComboBoxAvailableStorages.Items.Clear();
            listOfAvailableStorages.Clear();

            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            string commandText = "select tbl_Name from sqlite_master "+
                "where type = 'table' AND name NOT LIKE 'sqlite_%'";

            sqlCommand.CommandText = commandText;
            SQLiteDataReader dataBaseReader = sqlCommand.ExecuteReader();

            string tableName; ;
            while(dataBaseReader.Read())
            {
                tableName = (string)dataBaseReader["tbl_Name"];
                listOfAvailableStorages.Add(new Storage { TableName = tableName });
            }

            foreach(var availableTable in listOfAvailableStorages)
            {
                ComboBoxAvailableStorages.Items.Add(availableTable.TableName);
            }

        }

    }
}
