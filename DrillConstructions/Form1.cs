﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
            LabelAddingIntoStorageName.Text = activeConstructionsStorage;
            SetDefaultComboBoxSearchByType();
            SetSearchResultForLabelWhenDisplayingAllCards();
            DisableEnableBrowseCardsButtons();
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
                sqlConnection.Close();
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
                LabelAddingIntoStorageName.Text = activeConstructionsStorage;
                MessageBox.Show($"Current Storage has been switched to '{ComboBoxAvailableStorages.Text}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ComboBoxAvailableStorages.ResetText();
            }
        }

        private void BtnDeleteStorage_Click(object sender, EventArgs e)
        {
            string tableName = ComboBoxAvailableStorages.Text;

            var confirmationPopUp = MessageBox.Show($"Are you sure you want to DELETE '{tableName}' Storage?", "Think Twice", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (confirmationPopUp == DialogResult.Yes)
            {
                // TODO: add validation so that the current table is not deleted

                string deleteTable = "DROP TABLE " + tableName;
                ExecuteQuery(deleteTable);
                sqlConnection.Close();
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
            ClearAllOnAddCardsTab();

            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            string commandText = "SELECT tbl_Name FROM sqlite_master "+
                "WHERE type = 'table' AND name NOT LIKE 'sqlite_%'";

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
            sqlConnection.Close();
        }

        private void BtnCreateCard_Click(object sender, EventArgs e)
        {

            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            KeyValuePair<Label, Control>[] textFields = { new KeyValuePair<Label, Control>(LabelConstruction, (Control)TxtConstruction),
            new KeyValuePair<Label, Control>(LabelMeaning, (Control)TxtMeaning),
            new KeyValuePair<Label, Control>(LabelExample, (Control)TxtExample),
            new KeyValuePair<Label, Control>(LabelType, (Control)ComboBoxType)};

            List<string> invalidTextFields = new List<string>();

            bool emptyString = false;

            foreach (var textField in textFields)
            {
                if (textField.Value.Text == "")
                {
                    if (IsConvertibleTo<TextBox>(textField.Value))
                    {
                        var convertedValue = (TextBox)textField.Value;
                        convertedValue.Clear();
                    }
                    else if (IsConvertibleTo<ComboBox>(textField.Value))
                    {
                        var convertedValue = (ComboBox)textField.Value;
                        convertedValue.ResetText();
                    }

                    textField.Key.ForeColor = Color.Red;
                    LabelAddCardInformation.ForeColor = Color.Red;
                    invalidTextFields.Add(textField.Key.Text);
                    emptyString = true;
                } 
                else
                {
                    textField.Key.ForeColor = SystemColors.ControlText;
                }

                if (invalidTextFields.Count == 1)
                {
                    LabelAddCardInformation.Text = $"'{textField.Key.Text}' field cannot be empty!";
                }
                else
                {
                    string invalidFieldsToDisplay = "";

                    foreach(var invalidTextField in invalidTextFields)
                    {
                        if (!(invalidTextFields.IndexOf(invalidTextField) == invalidTextFields.Count - 1))
                            invalidFieldsToDisplay += $"{invalidTextField}, ";
                        else
                            invalidFieldsToDisplay += $"{invalidTextField}";
                    }

                    LabelAddCardInformation.Text = $"'{invalidFieldsToDisplay}' fields cannot be empty!";
                }
            }

            if (!emptyString)
            {
                //TODO: to think of a better way to handle lower/upper cases
                string createCard = "INSERT INTO " + activeConstructionsStorage +
                    " (Construction, Meaning, Example, Type) " +
                    "VALUES ('" + TxtConstruction.Text.ToLower() + "', '" + TxtMeaning.Text.ToLower() + "', '" + TxtExample.Text + "', '" + ComboBoxType.Text + "')";

                sqlCommand.CommandText = createCard;
                ExecuteQuery(createCard);
                sqlConnection.Close();
                LabelAddCardInformation.ForeColor = Color.ForestGreen;
                LabelAddCardInformation.Text = $"'{TxtConstruction.Text}' card has been added in '{activeConstructionsStorage}'.";
                ClearAddCardFields();
                LoadData(activeConstructionsStorage);
            }
            else { }
        }

        private void ClearAddCardFields()
        {
            TxtConstruction.Clear();
            TxtMeaning.Clear();
            TxtExample.Clear();
            ClearComboBoxOnAddCardsTab();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllOnAddCardsTab();
        }

        private void ClearLabelAddCardInformation()
        {
            LabelAddCardInformation.Text = "";
        }

        private void MakeFontForAddCardLabelsBlack()
        {
            LabelConstruction.ForeColor = Color.Black;
            LabelMeaning.ForeColor = Color.Black;
            LabelExample.ForeColor = Color.Black;
            LabelType.ForeColor = Color.Black;
        }

        private void ClearAllOnAddCardsTab()
        {
            MakeFontForAddCardLabelsBlack();
            ClearAddCardFields();
            ClearLabelAddCardInformation();
        }

        //TODO: to think of the better way to handle this
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllOnAddCardsTab();
            ClearAllOnBrowseCardsTab();
            LoadData(activeConstructionsStorage);
            ClearSearchResultsForLabelOnBrowseCardsTab();
            SetSearchResultForLabelWhenDisplayingAllCards();
        }

        #region Add Cards tab

        #region Add Cards tab: db

        #endregion Add Cards tab: db

        #region Add Cards tab: events

        #endregion Add Cards tab: events

        #region Add Cards tab: The tiniest methods

        #endregion Add Cards tab: The tiniest methods

        #endregion Add Cards tab

        #region Browse Cards tab

        #region Browse Cards tab: db

        private void SearchData(string searchQuery, string searchBy, string activeStorage)
        {
            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            string commandText;

            if (searchQuery == "")
                commandText = $"SELECT * FROM {activeStorage}";
            else
                commandText = $"SELECT * FROM {activeStorage} WHERE {searchBy} LIKE '%{searchQuery}%'";

            DB = new SQLiteDataAdapter(commandText, sqlConnection);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            DataGridBrowseCards.DataSource = sqlDT;
            sqlConnection.Close();

            if (searchQuery =="")
                LabelBrowserSearchResultsFor.Text = $"Displaying all cards in storage '{activeStorage}'";
            else
                LabelBrowserSearchResultsFor.Text = $"Search results for '{TxtSearch.Text}' in '{ComboBoxSearchBy.Text}'";
            ClearSearchTextBoxOnBrowseCardsTab();

            ClearLabelUpdateCardInformation();
            MakeFontForBrowseCardsLabelsBlack();
            ClearAllOnBrowseCardsTab();
        }

        private void DeleteCardOnBrowseCardsTab(string activeStorage)
        {
            string cardConstruction = TxtBrowserConstruction.Text;

            var confirmationPopUp = MessageBox.Show($"Are you sure you want to DELETE '{cardConstruction}' card?", "Think Twice", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (confirmationPopUp == DialogResult.Yes)
            {

                SetDBConnection();
                sqlConnection.Open();
                sqlCommand = sqlConnection.CreateCommand();
                string commandDeleteCard;

                commandDeleteCard = $"DELETE FROM {activeStorage} WHERE ID = {TxtBrowserID.Text}";

                sqlCommand.CommandText = commandDeleteCard;
                ExecuteQuery(commandDeleteCard);
                sqlConnection.Close();

                SetSearchResultForLabelWhenDisplayingAllCards();

                MakeFontForBrowseCardsLabelsBlack();
                ClearAllOnBrowseCardsTab();

                LabelUpdateCardInformation.ForeColor = Color.Red;
                LabelUpdateCardInformation.Text = $"Card '{cardConstruction}' has been DELETED.";

                DisableEnableBrowseCardsButtons();

                LoadData(activeStorage); 
            }
        }

        private void ButtonUpdateCard_Click(object sender, EventArgs e)
        {
            SetDBConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();

            KeyValuePair<Label, Control>[] textFields = { new KeyValuePair<Label, Control>(LabelBrowserConstruction, (Control)TxtBrowserConstruction),
            new KeyValuePair<Label, Control>(LabelBrowserMeaning, (Control)TxtBrowserMeaning),
            new KeyValuePair<Label, Control>(LabelBrowserExample, (Control)TxtBrowserExample),
            new KeyValuePair<Label, Control>(LabelBrowserType, (Control)ComboBoxBrowserType)};

            List<string> invalidTextFields = new List<string>();

            bool emptyString = false;

            foreach (var textField in textFields)
            {
                if (textField.Value.Text == "")
                {
                    if (IsConvertibleTo<TextBox>(textField.Value))
                    {
                        var convertedValue = (TextBox)textField.Value;
                        convertedValue.Clear();
                    }
                    else if (IsConvertibleTo<ComboBox>(textField.Value))
                    {
                        var convertedValue = (ComboBox)textField.Value;
                        convertedValue.ResetText();
                    }

                    textField.Key.ForeColor = Color.Red;
                    LabelUpdateCardInformation.ForeColor = Color.Red;
                    invalidTextFields.Add(textField.Key.Text);
                    emptyString = true;
                }
                else
                {
                    textField.Key.ForeColor = SystemColors.ControlText;
                }

                if (invalidTextFields.Count == 1)
                {
                    LabelUpdateCardInformation.Text = $"'{textField.Key.Text}' field cannot be empty!";
                }
                else
                {
                    string invalidFieldsToDisplay = "";

                    foreach (var invalidTextField in invalidTextFields)
                    {
                        if (!(invalidTextFields.IndexOf(invalidTextField) == invalidTextFields.Count - 1))
                            invalidFieldsToDisplay += $"{invalidTextField}, ";
                        else
                            invalidFieldsToDisplay += $"{invalidTextField}";
                    }

                    LabelUpdateCardInformation.Text = $"'{invalidFieldsToDisplay}' fields cannot be empty!";
                }
            }

            if (!emptyString)
            {
                //TODO: to think of a better way to handle lower/upper cases
                string updateCard = $"UPDATE {activeConstructionsStorage} " +
                    $"SET Construction = '{TxtBrowserConstruction.Text.ToLower()}', " +
                    $"Meaning = '{TxtBrowserMeaning.Text.ToLower()}', " +
                    $"Example = '{TxtBrowserExample.Text}', " +
                    $"Type = '{ComboBoxBrowserType.Text}' " +
                    $"WHERE ID = '{TxtBrowserID.Text}'";

                sqlCommand.CommandText = updateCard;
                ExecuteQuery(updateCard);
                sqlConnection.Close();

                string cardID = TxtBrowserID.Text;

                SetSearchResultForLabelWhenDisplayingAllCards();

                LabelUpdateCardInformation.ForeColor = Color.ForestGreen;
                MakeFontForBrowseCardsLabelsBlack();

                ClearAllOnBrowseCardsTab();

                LabelUpdateCardInformation.Text = $"Card with ID '{cardID}' has been updated in '{activeConstructionsStorage}'.";
                
                DisableEnableBrowseCardsButtons();

                LoadData(activeConstructionsStorage);
            }
            else { }
        }

        #endregion Browse Cards tab: db

        #region Browse Cards tab: events

        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            DeleteCardOnBrowseCardsTab(activeConstructionsStorage);
        }

        private void BtnClearCardFieldsBrowseCards_Click(object sender, EventArgs e)
        {
            ClearAllOnBrowseCardsTab();
            DisableEnableBrowseCardsButtons();
        }

        private void BtnSelectCard_Click(object sender, EventArgs e)
        {
            TxtBrowserID.Text = GetCellDataByCellNumber(0);
            TxtBrowserConstruction.Text = GetCellDataByCellNumber(1);
            TxtBrowserMeaning.Text = GetCellDataByCellNumber(2);
            TxtBrowserExample.Text = GetCellDataByCellNumber(3);
            ComboBoxBrowserType.Text = GetCellDataByCellNumber(4);

            ClearLabelUpdateCardInformation();
            MakeFontForBrowseCardsLabelsBlack();

            DisableEnableBrowseCardsButtons();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchData(TxtSearch.Text, ComboBoxSearchBy.Text, activeConstructionsStorage);
        }

        #endregion Browse Cards tab: events

        #region Browse Cards tab: The tiniest methods

        private void DisableEnableBrowseCardsButtons()
        {
            if (TxtBrowserID.Text == "")
            {
                BtnUpdateCard.Enabled = false;
                BtnDeleteCard.Enabled = false;
            }
            else
            {
                BtnUpdateCard.Enabled = true;
                BtnDeleteCard.Enabled = true;
            }
        }

        private void ClearSearchResultsForLabelOnBrowseCardsTab()
        {
            LabelBrowserSearchResultsFor.Text = "";
        }

        private void SetSearchResultForLabelWhenDisplayingAllCards()
        {
            LabelBrowserSearchResultsFor.Text = $"Displaying all cards in storage '{activeConstructionsStorage}'";
        }

        private void ClearSearchTextBoxOnBrowseCardsTab()
        {
            TxtSearch.Text = "";
        }

        private void ClearComboBoxOnBrowseCardsTab()
        {
            ComboBoxBrowserType.SelectedIndex = -1;
        }

        private string GetCellDataByCellNumber(int cellNumber)
        {
            return DataGridBrowseCards.SelectedRows[0].Cells[cellNumber].Value.ToString();
        }

        private void ClearAllOnBrowseCardsTab()
        {
            MakeFontForBrowseCardsLabelsBlack();
            ClearLabelUpdateCardInformation();
            ClearBrowseCardsFields();
            ClearComboBoxOnBrowseCardsTab();
        }

        private void ClearBrowseCardsFields()
        {
            TxtBrowserID.Text = "";
            TxtBrowserConstruction.Text = "";
            TxtBrowserMeaning.Text = "";
            TxtBrowserExample.Text = "";
        }

        private void MakeFontForBrowseCardsLabelsBlack()
        {
            LabelBrowserConstruction.ForeColor = Color.Black;
            LabelBrowserMeaning.ForeColor = Color.Black;
            LabelBrowserExample.ForeColor = Color.Black;
            LabelBrowserType.ForeColor = Color.Black;
        }

        private void ClearLabelUpdateCardInformation()
        {
            LabelUpdateCardInformation.Text = "";
        }

        private void ClearComboBoxOnAddCardsTab()
        {
            ComboBoxType.SelectedIndex = -1;
        }

        private void SetDefaultComboBoxSearchByType()
        {
            ComboBoxSearchBy.SelectedItem = "Construction";
        }

        #endregion Browse Cards tab: The tiniest methods

        #endregion Browse Cards tab

        #region General helper methods

        private bool IsConvertibleTo<T>(object value)
        {
            try
            {
                T convertedValue = (T)Convert.ChangeType(value, typeof(T));
                return true;
            }
            catch (InvalidCastException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }


        #endregion

        
    
    }
}
