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

            var confirmationPopUp = MessageBox.Show($"Are you sure you want to create a new Storage '{tableName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmationPopUp == DialogResult.Yes)
            {
                // TODO: add validation for empty string before creating a table

                string createNewTable = "CREATE TABLE '" + tableName + "' ('ID' INTEGER NOT NULL UNIQUE," +
                "'Construction'  TEXT NOT NULL UNIQUE," +
                "'Meaning'   TEXT NOT NULL," +
                "'Example'   TEXT NOT NULL," +
                "'Type'  TEXT NOT NULL," +
                "PRIMARY KEY('ID' AUTOINCREMENT));";
                ExecuteQuery(createNewTable);
                TxtNewTableName.Clear();
                GetAvailableStorages();
                MessageBox.Show($"New Storage '{tableName}' has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TxtNewTableName.Clear();
                GetAvailableStorages();
                MessageBox.Show($"Adding new Storage has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSelectCurrentStorage_Click(object sender, EventArgs e)
        {
            var confirmationPopUp = MessageBox.Show($"Are you sure you want to switch the current storage to '{ComboBoxAvailableStorages.Text}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmationPopUp == DialogResult.Yes)
            {
                activeConstructionsStorage = ComboBoxAvailableStorages.Text;
                GetAvailableStorages();
                LoadData(activeConstructionsStorage);
                LabelCurrentStorage.Text = activeConstructionsStorage;
                MessageBox.Show($"Current Storage has been switched to '{ComboBoxAvailableStorages.Text}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ComboBoxAvailableStorages.ResetText();
            }
        }

        private void BtnDeletetStorage_Click(object sender, EventArgs e)
        {
            string tableName = ComboBoxAvailableStorages.Text;

            var confirmationPopUp = MessageBox.Show($"Are you sure you want to DELETE '{tableName}' Storage?", "Think Twice", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (confirmationPopUp == DialogResult.Yes)
            {
                // TODO: add validation so that the current table is not deleted

                string deleteTable = "DROP TABLE " + tableName;
                ExecuteQuery(deleteTable);
                ComboBoxAvailableStorages.ResetText();
                GetAvailableStorages();
                MessageBox.Show($"Storage '{tableName}' has been DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { }
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
