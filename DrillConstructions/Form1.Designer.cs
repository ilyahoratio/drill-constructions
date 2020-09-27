using System;

namespace DrillConstructions
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabDrillsGenerator = new System.Windows.Forms.TabPage();
            this.TabStudyCards = new System.Windows.Forms.TabPage();
            this.TabAddCards = new System.Windows.Forms.TabPage();
            this.LabelAddCardInformation = new System.Windows.Forms.Label();
            this.LabelAddingIntoStorageName = new System.Windows.Forms.Label();
            this.LabelAddingCardsInto = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCreateCard = new System.Windows.Forms.Button();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.TxtExample = new System.Windows.Forms.TextBox();
            this.TxtMeaning = new System.Windows.Forms.TextBox();
            this.TxtConstruction = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelExample = new System.Windows.Forms.Label();
            this.LabelMeaning = new System.Windows.Forms.Label();
            this.LabelConstruction = new System.Windows.Forms.Label();
            this.TabBrowseCards = new System.Windows.Forms.TabPage();
            this.DataGridBrowseCards = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.PanelSelectStorage = new System.Windows.Forms.Panel();
            this.LabelStorageColons = new System.Windows.Forms.Label();
            this.LabelCurrentStorage = new System.Windows.Forms.Label();
            this.ComboBoxAvailableStorages = new System.Windows.Forms.ComboBox();
            this.BtnDeleteStorage = new System.Windows.Forms.Button();
            this.BtnSelectCurrentStorage = new System.Windows.Forms.Button();
            this.PanelCreateStorage = new System.Windows.Forms.Panel();
            this.LabelNewStorageName = new System.Windows.Forms.Label();
            this.TxtNewTableName = new System.Windows.Forms.TextBox();
            this.BtnCreateTable = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabAddCards.SuspendLayout();
            this.TabBrowseCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBrowseCards)).BeginInit();
            this.TabSettings.SuspendLayout();
            this.PanelSelectStorage.SuspendLayout();
            this.PanelCreateStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabDrillsGenerator);
            this.TabControl.Controls.Add(this.TabStudyCards);
            this.TabControl.Controls.Add(this.TabAddCards);
            this.TabControl.Controls.Add(this.TabBrowseCards);
            this.TabControl.Controls.Add(this.TabSettings);
            this.TabControl.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(20, 8);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1114, 624);
            this.TabControl.TabIndex = 0;
            this.TabControl.Click += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabDrillsGenerator
            // 
            this.TabDrillsGenerator.Location = new System.Drawing.Point(4, 46);
            this.TabDrillsGenerator.Name = "TabDrillsGenerator";
            this.TabDrillsGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.TabDrillsGenerator.Size = new System.Drawing.Size(1106, 574);
            this.TabDrillsGenerator.TabIndex = 0;
            this.TabDrillsGenerator.Text = "Drills Generator";
            this.TabDrillsGenerator.UseVisualStyleBackColor = true;
            // 
            // TabStudyCards
            // 
            this.TabStudyCards.Location = new System.Drawing.Point(4, 46);
            this.TabStudyCards.Name = "TabStudyCards";
            this.TabStudyCards.Padding = new System.Windows.Forms.Padding(3);
            this.TabStudyCards.Size = new System.Drawing.Size(1106, 574);
            this.TabStudyCards.TabIndex = 3;
            this.TabStudyCards.Text = "Study Cards";
            this.TabStudyCards.UseVisualStyleBackColor = true;
            // 
            // TabAddCards
            // 
            this.TabAddCards.Controls.Add(this.LabelAddCardInformation);
            this.TabAddCards.Controls.Add(this.LabelAddingIntoStorageName);
            this.TabAddCards.Controls.Add(this.LabelAddingCardsInto);
            this.TabAddCards.Controls.Add(this.BtnClear);
            this.TabAddCards.Controls.Add(this.BtnCreateCard);
            this.TabAddCards.Controls.Add(this.ComboBoxType);
            this.TabAddCards.Controls.Add(this.TxtExample);
            this.TabAddCards.Controls.Add(this.TxtMeaning);
            this.TabAddCards.Controls.Add(this.TxtConstruction);
            this.TabAddCards.Controls.Add(this.LabelType);
            this.TabAddCards.Controls.Add(this.LabelExample);
            this.TabAddCards.Controls.Add(this.LabelMeaning);
            this.TabAddCards.Controls.Add(this.LabelConstruction);
            this.TabAddCards.Location = new System.Drawing.Point(4, 46);
            this.TabAddCards.Name = "TabAddCards";
            this.TabAddCards.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddCards.Size = new System.Drawing.Size(1106, 574);
            this.TabAddCards.TabIndex = 1;
            this.TabAddCards.Text = "Add Cards";
            this.TabAddCards.UseVisualStyleBackColor = true;
            // 
            // LabelAddCardInformation
            // 
            this.LabelAddCardInformation.AutoSize = true;
            this.LabelAddCardInformation.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.LabelAddCardInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelAddCardInformation.Location = new System.Drawing.Point(192, 303);
            this.LabelAddCardInformation.Name = "LabelAddCardInformation";
            this.LabelAddCardInformation.Size = new System.Drawing.Size(17, 27);
            this.LabelAddCardInformation.TabIndex = 8;
            this.LabelAddCardInformation.Text = " ";
            // 
            // LabelAddingIntoStorageName
            // 
            this.LabelAddingIntoStorageName.AutoSize = true;
            this.LabelAddingIntoStorageName.Location = new System.Drawing.Point(308, 28);
            this.LabelAddingIntoStorageName.Name = "LabelAddingIntoStorageName";
            this.LabelAddingIntoStorageName.Size = new System.Drawing.Size(141, 27);
            this.LabelAddingIntoStorageName.TabIndex = 6;
            this.LabelAddingIntoStorageName.Text = "storage name";
            // 
            // LabelAddingCardsInto
            // 
            this.LabelAddingCardsInto.AutoSize = true;
            this.LabelAddingCardsInto.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.LabelAddingCardsInto.Location = new System.Drawing.Point(23, 28);
            this.LabelAddingCardsInto.Name = "LabelAddingCardsInto";
            this.LabelAddingCardsInto.Size = new System.Drawing.Size(285, 27);
            this.LabelAddingCardsInto.TabIndex = 5;
            this.LabelAddingCardsInto.Text = "Adding Cards into Storage: ";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(344, 412);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(105, 40);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCreateCard
            // 
            this.BtnCreateCard.Location = new System.Drawing.Point(213, 412);
            this.BtnCreateCard.Name = "BtnCreateCard";
            this.BtnCreateCard.Size = new System.Drawing.Size(105, 40);
            this.BtnCreateCard.TabIndex = 5;
            this.BtnCreateCard.Text = "Create";
            this.BtnCreateCard.UseVisualStyleBackColor = true;
            this.BtnCreateCard.Click += new System.EventHandler(this.BtnCreateCard_Click);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Conjunction",
            "Filler",
            "Intense",
            "Interjection",
            "Moreover",
            "Question",
            "Regarding",
            "Sarcasm",
            "Sentence Start",
            "Subjunctive",
            "Time"});
            this.ComboBoxType.Location = new System.Drawing.Point(197, 234);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(260, 35);
            this.ComboBoxType.TabIndex = 4;
            // 
            // TxtExample
            // 
            this.TxtExample.Location = new System.Drawing.Point(197, 190);
            this.TxtExample.Name = "TxtExample";
            this.TxtExample.Size = new System.Drawing.Size(260, 35);
            this.TxtExample.TabIndex = 3;
            // 
            // TxtMeaning
            // 
            this.TxtMeaning.Location = new System.Drawing.Point(197, 146);
            this.TxtMeaning.Name = "TxtMeaning";
            this.TxtMeaning.Size = new System.Drawing.Size(260, 35);
            this.TxtMeaning.TabIndex = 2;
            // 
            // TxtConstruction
            // 
            this.TxtConstruction.Location = new System.Drawing.Point(197, 102);
            this.TxtConstruction.Name = "TxtConstruction";
            this.TxtConstruction.Size = new System.Drawing.Size(260, 35);
            this.TxtConstruction.TabIndex = 1;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(121, 237);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(56, 27);
            this.LabelType.TabIndex = 0;
            this.LabelType.Text = "Type";
            // 
            // LabelExample
            // 
            this.LabelExample.AutoSize = true;
            this.LabelExample.Location = new System.Drawing.Point(85, 193);
            this.LabelExample.Name = "LabelExample";
            this.LabelExample.Size = new System.Drawing.Size(92, 27);
            this.LabelExample.TabIndex = 0;
            this.LabelExample.Text = "Example";
            // 
            // LabelMeaning
            // 
            this.LabelMeaning.AutoSize = true;
            this.LabelMeaning.Location = new System.Drawing.Point(84, 149);
            this.LabelMeaning.Name = "LabelMeaning";
            this.LabelMeaning.Size = new System.Drawing.Size(93, 27);
            this.LabelMeaning.TabIndex = 0;
            this.LabelMeaning.Text = "Meaning";
            // 
            // LabelConstruction
            // 
            this.LabelConstruction.AutoSize = true;
            this.LabelConstruction.Location = new System.Drawing.Point(45, 105);
            this.LabelConstruction.Name = "LabelConstruction";
            this.LabelConstruction.Size = new System.Drawing.Size(132, 27);
            this.LabelConstruction.TabIndex = 0;
            this.LabelConstruction.Text = "Construction";
            // 
            // TabBrowseCards
            // 
            this.TabBrowseCards.Controls.Add(this.DataGridBrowseCards);
            this.TabBrowseCards.Controls.Add(this.BtnSearch);
            this.TabBrowseCards.Controls.Add(this.TxtSearch);
            this.TabBrowseCards.Location = new System.Drawing.Point(4, 46);
            this.TabBrowseCards.Name = "TabBrowseCards";
            this.TabBrowseCards.Padding = new System.Windows.Forms.Padding(3);
            this.TabBrowseCards.Size = new System.Drawing.Size(1106, 574);
            this.TabBrowseCards.TabIndex = 2;
            this.TabBrowseCards.Text = "Browse Cards";
            this.TabBrowseCards.UseVisualStyleBackColor = true;
            // 
            // DataGridBrowseCards
            // 
            this.DataGridBrowseCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBrowseCards.Location = new System.Drawing.Point(27, 327);
            this.DataGridBrowseCards.Name = "DataGridBrowseCards";
            this.DataGridBrowseCards.RowHeadersWidth = 62;
            this.DataGridBrowseCards.RowTemplate.Height = 28;
            this.DataGridBrowseCards.Size = new System.Drawing.Size(1053, 222);
            this.DataGridBrowseCards.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(501, 122);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(105, 40);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(345, 58);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(416, 35);
            this.TxtSearch.TabIndex = 1;
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.PanelSelectStorage);
            this.TabSettings.Controls.Add(this.PanelCreateStorage);
            this.TabSettings.Location = new System.Drawing.Point(4, 46);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(1106, 574);
            this.TabSettings.TabIndex = 4;
            this.TabSettings.Text = "Settings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // PanelSelectStorage
            // 
            this.PanelSelectStorage.BackColor = System.Drawing.Color.MintCream;
            this.PanelSelectStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSelectStorage.Controls.Add(this.LabelStorageColons);
            this.PanelSelectStorage.Controls.Add(this.LabelCurrentStorage);
            this.PanelSelectStorage.Controls.Add(this.ComboBoxAvailableStorages);
            this.PanelSelectStorage.Controls.Add(this.BtnDeleteStorage);
            this.PanelSelectStorage.Controls.Add(this.BtnSelectCurrentStorage);
            this.PanelSelectStorage.Location = new System.Drawing.Point(24, 37);
            this.PanelSelectStorage.Name = "PanelSelectStorage";
            this.PanelSelectStorage.Size = new System.Drawing.Size(1058, 136);
            this.PanelSelectStorage.TabIndex = 7;
            // 
            // LabelStorageColons
            // 
            this.LabelStorageColons.AutoSize = true;
            this.LabelStorageColons.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.LabelStorageColons.Location = new System.Drawing.Point(24, 27);
            this.LabelStorageColons.Name = "LabelStorageColons";
            this.LabelStorageColons.Size = new System.Drawing.Size(179, 27);
            this.LabelStorageColons.TabIndex = 2;
            this.LabelStorageColons.Text = "Current Storage:";
            // 
            // LabelCurrentStorage
            // 
            this.LabelCurrentStorage.AutoSize = true;
            this.LabelCurrentStorage.Location = new System.Drawing.Point(203, 27);
            this.LabelCurrentStorage.Name = "LabelCurrentStorage";
            this.LabelCurrentStorage.Size = new System.Drawing.Size(141, 27);
            this.LabelCurrentStorage.TabIndex = 5;
            this.LabelCurrentStorage.Text = "storage name";
            // 
            // ComboBoxAvailableStorages
            // 
            this.ComboBoxAvailableStorages.FormattingEnabled = true;
            this.ComboBoxAvailableStorages.Location = new System.Drawing.Point(555, 23);
            this.ComboBoxAvailableStorages.Name = "ComboBoxAvailableStorages";
            this.ComboBoxAvailableStorages.Size = new System.Drawing.Size(310, 35);
            this.ComboBoxAvailableStorages.TabIndex = 1;
            // 
            // BtnDeleteStorage
            // 
            this.BtnDeleteStorage.BackColor = System.Drawing.Color.Crimson;
            this.BtnDeleteStorage.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteStorage.Location = new System.Drawing.Point(882, 78);
            this.BtnDeleteStorage.Name = "BtnDeleteStorage";
            this.BtnDeleteStorage.Size = new System.Drawing.Size(160, 40);
            this.BtnDeleteStorage.TabIndex = 3;
            this.BtnDeleteStorage.Text = "Delete Storage";
            this.BtnDeleteStorage.UseVisualStyleBackColor = false;
            this.BtnDeleteStorage.Click += new System.EventHandler(this.BtnDeletetStorage_Click);
            // 
            // BtnSelectCurrentStorage
            // 
            this.BtnSelectCurrentStorage.Location = new System.Drawing.Point(882, 20);
            this.BtnSelectCurrentStorage.Name = "BtnSelectCurrentStorage";
            this.BtnSelectCurrentStorage.Size = new System.Drawing.Size(160, 40);
            this.BtnSelectCurrentStorage.TabIndex = 2;
            this.BtnSelectCurrentStorage.Text = "Select Storage";
            this.BtnSelectCurrentStorage.UseVisualStyleBackColor = true;
            this.BtnSelectCurrentStorage.Click += new System.EventHandler(this.BtnSelectCurrentStorage_Click);
            // 
            // PanelCreateStorage
            // 
            this.PanelCreateStorage.BackColor = System.Drawing.Color.Honeydew;
            this.PanelCreateStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCreateStorage.Controls.Add(this.LabelNewStorageName);
            this.PanelCreateStorage.Controls.Add(this.TxtNewTableName);
            this.PanelCreateStorage.Controls.Add(this.BtnCreateTable);
            this.PanelCreateStorage.Location = new System.Drawing.Point(24, 209);
            this.PanelCreateStorage.Name = "PanelCreateStorage";
            this.PanelCreateStorage.Size = new System.Drawing.Size(369, 198);
            this.PanelCreateStorage.TabIndex = 8;
            // 
            // LabelNewStorageName
            // 
            this.LabelNewStorageName.AutoSize = true;
            this.LabelNewStorageName.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.LabelNewStorageName.Location = new System.Drawing.Point(24, 30);
            this.LabelNewStorageName.Name = "LabelNewStorageName";
            this.LabelNewStorageName.Size = new System.Drawing.Size(211, 27);
            this.LabelNewStorageName.TabIndex = 2;
            this.LabelNewStorageName.Text = "New Storage Name:";
            // 
            // TxtNewTableName
            // 
            this.TxtNewTableName.Location = new System.Drawing.Point(24, 74);
            this.TxtNewTableName.Name = "TxtNewTableName";
            this.TxtNewTableName.Size = new System.Drawing.Size(304, 35);
            this.TxtNewTableName.TabIndex = 4;
            // 
            // BtnCreateTable
            // 
            this.BtnCreateTable.Location = new System.Drawing.Point(24, 126);
            this.BtnCreateTable.Name = "BtnCreateTable";
            this.BtnCreateTable.Size = new System.Drawing.Size(175, 40);
            this.BtnCreateTable.TabIndex = 5;
            this.BtnCreateTable.Text = "Create";
            this.BtnCreateTable.UseVisualStyleBackColor = true;
            this.BtnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 622);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.TabAddCards.ResumeLayout(false);
            this.TabAddCards.PerformLayout();
            this.TabBrowseCards.ResumeLayout(false);
            this.TabBrowseCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBrowseCards)).EndInit();
            this.TabSettings.ResumeLayout(false);
            this.PanelSelectStorage.ResumeLayout(false);
            this.PanelSelectStorage.PerformLayout();
            this.PanelCreateStorage.ResumeLayout(false);
            this.PanelCreateStorage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabDrillsGenerator;
        private System.Windows.Forms.TabPage TabStudyCards;
        private System.Windows.Forms.TabPage TabAddCards;
        private System.Windows.Forms.TabPage TabBrowseCards;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelExample;
        private System.Windows.Forms.Label LabelMeaning;
        private System.Windows.Forms.Label LabelConstruction;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCreateCard;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.TextBox TxtExample;
        private System.Windows.Forms.TextBox TxtMeaning;
        private System.Windows.Forms.TextBox TxtConstruction;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DataGridBrowseCards;
        private System.Windows.Forms.TextBox TxtNewTableName;
        private System.Windows.Forms.Button BtnCreateTable;
        private System.Windows.Forms.Label LabelStorageColons;
        private System.Windows.Forms.Button BtnSelectCurrentStorage;
        private System.Windows.Forms.Label LabelCurrentStorage;
        private System.Windows.Forms.ComboBox ComboBoxAvailableStorages;
        private System.Windows.Forms.Panel PanelSelectStorage;
        private System.Windows.Forms.Panel PanelCreateStorage;
        private System.Windows.Forms.Label LabelNewStorageName;
        private System.Windows.Forms.Button BtnDeleteStorage;
        private System.Windows.Forms.Label LabelAddingCardsInto;
        private System.Windows.Forms.Label LabelAddingIntoStorageName;
        private System.Windows.Forms.Label LabelAddCardInformation;
    }
}

