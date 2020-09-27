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
            this.TabCardsStorage = new System.Windows.Forms.TabPage();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.TxtExample = new System.Windows.Forms.TextBox();
            this.TxtMeaning = new System.Windows.Forms.TextBox();
            this.TxtConstruction = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelExample = new System.Windows.Forms.Label();
            this.LabelMeaning = new System.Windows.Forms.Label();
            this.LableConstruction = new System.Windows.Forms.Label();
            this.TabBrowseCards = new System.Windows.Forms.TabPage();
            this.DataGridBrowseCards = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.TxtCurrentStorage = new System.Windows.Forms.TextBox();
            this.BtnSelectCurrentStorage = new System.Windows.Forms.Button();
            this.TxtSetCurrentStorage = new System.Windows.Forms.TextBox();
            this.LabelCurrentStorage = new System.Windows.Forms.Label();
            this.TxtNewTableName = new System.Windows.Forms.TextBox();
            this.BtnCreateTable = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabCardsStorage.SuspendLayout();
            this.TabBrowseCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBrowseCards)).BeginInit();
            this.TabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabDrillsGenerator);
            this.TabControl.Controls.Add(this.TabStudyCards);
            this.TabControl.Controls.Add(this.TabCardsStorage);
            this.TabControl.Controls.Add(this.TabBrowseCards);
            this.TabControl.Controls.Add(this.TabSettings);
            this.TabControl.Font = new System.Drawing.Font("Noto Sans", 10F);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(20, 8);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1114, 624);
            this.TabControl.TabIndex = 0;
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
            // TabCardsStorage
            // 
            this.TabCardsStorage.Controls.Add(this.BtnClear);
            this.TabCardsStorage.Controls.Add(this.BtnCreate);
            this.TabCardsStorage.Controls.Add(this.ComboBoxType);
            this.TabCardsStorage.Controls.Add(this.TxtExample);
            this.TabCardsStorage.Controls.Add(this.TxtMeaning);
            this.TabCardsStorage.Controls.Add(this.TxtConstruction);
            this.TabCardsStorage.Controls.Add(this.LabelType);
            this.TabCardsStorage.Controls.Add(this.LabelExample);
            this.TabCardsStorage.Controls.Add(this.LabelMeaning);
            this.TabCardsStorage.Controls.Add(this.LableConstruction);
            this.TabCardsStorage.Location = new System.Drawing.Point(4, 46);
            this.TabCardsStorage.Name = "TabCardsStorage";
            this.TabCardsStorage.Padding = new System.Windows.Forms.Padding(3);
            this.TabCardsStorage.Size = new System.Drawing.Size(1106, 574);
            this.TabCardsStorage.TabIndex = 1;
            this.TabCardsStorage.Text = "Cards Storage";
            this.TabCardsStorage.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(154, 322);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(105, 40);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(23, 322);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(105, 40);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(202, 199);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(260, 35);
            this.ComboBoxType.TabIndex = 2;
            // 
            // TxtExample
            // 
            this.TxtExample.Location = new System.Drawing.Point(202, 155);
            this.TxtExample.Name = "TxtExample";
            this.TxtExample.Size = new System.Drawing.Size(260, 35);
            this.TxtExample.TabIndex = 1;
            // 
            // TxtMeaning
            // 
            this.TxtMeaning.Location = new System.Drawing.Point(202, 111);
            this.TxtMeaning.Name = "TxtMeaning";
            this.TxtMeaning.Size = new System.Drawing.Size(260, 35);
            this.TxtMeaning.TabIndex = 1;
            // 
            // TxtConstruction
            // 
            this.TxtConstruction.Location = new System.Drawing.Point(202, 67);
            this.TxtConstruction.Name = "TxtConstruction";
            this.TxtConstruction.Size = new System.Drawing.Size(260, 35);
            this.TxtConstruction.TabIndex = 1;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(126, 202);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(56, 27);
            this.LabelType.TabIndex = 0;
            this.LabelType.Text = "Type";
            // 
            // LabelExample
            // 
            this.LabelExample.AutoSize = true;
            this.LabelExample.Location = new System.Drawing.Point(90, 158);
            this.LabelExample.Name = "LabelExample";
            this.LabelExample.Size = new System.Drawing.Size(92, 27);
            this.LabelExample.TabIndex = 0;
            this.LabelExample.Text = "Example";
            // 
            // LabelMeaning
            // 
            this.LabelMeaning.AutoSize = true;
            this.LabelMeaning.Location = new System.Drawing.Point(89, 114);
            this.LabelMeaning.Name = "LabelMeaning";
            this.LabelMeaning.Size = new System.Drawing.Size(93, 27);
            this.LabelMeaning.TabIndex = 0;
            this.LabelMeaning.Text = "Meaning";
            // 
            // LableConstruction
            // 
            this.LableConstruction.AutoSize = true;
            this.LableConstruction.Location = new System.Drawing.Point(50, 70);
            this.LableConstruction.Name = "LableConstruction";
            this.LableConstruction.Size = new System.Drawing.Size(132, 27);
            this.LableConstruction.TabIndex = 0;
            this.LableConstruction.Text = "Construction";
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
            this.TabSettings.Controls.Add(this.TxtCurrentStorage);
            this.TabSettings.Controls.Add(this.BtnSelectCurrentStorage);
            this.TabSettings.Controls.Add(this.TxtSetCurrentStorage);
            this.TabSettings.Controls.Add(this.LabelCurrentStorage);
            this.TabSettings.Controls.Add(this.TxtNewTableName);
            this.TabSettings.Controls.Add(this.BtnCreateTable);
            this.TabSettings.Location = new System.Drawing.Point(4, 46);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(1106, 574);
            this.TabSettings.TabIndex = 4;
            this.TabSettings.Text = "Settings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // TxtCurrentStorage
            // 
            this.TxtCurrentStorage.Enabled = false;
            this.TxtCurrentStorage.Location = new System.Drawing.Point(192, 23);
            this.TxtCurrentStorage.Name = "TxtCurrentStorage";
            this.TxtCurrentStorage.Size = new System.Drawing.Size(330, 35);
            this.TxtCurrentStorage.TabIndex = 5;
            // 
            // BtnSelectCurrentStorage
            // 
            this.BtnSelectCurrentStorage.Location = new System.Drawing.Point(853, 15);
            this.BtnSelectCurrentStorage.Name = "BtnSelectCurrentStorage";
            this.BtnSelectCurrentStorage.Size = new System.Drawing.Size(105, 40);
            this.BtnSelectCurrentStorage.TabIndex = 4;
            this.BtnSelectCurrentStorage.Text = "Select";
            this.BtnSelectCurrentStorage.UseVisualStyleBackColor = true;
            this.BtnSelectCurrentStorage.Click += new System.EventHandler(this.BtnSelectCurrentStorage_Click);
            // 
            // TxtSetCurrentStorage
            // 
            this.TxtSetCurrentStorage.Location = new System.Drawing.Point(664, 15);
            this.TxtSetCurrentStorage.Name = "TxtSetCurrentStorage";
            this.TxtSetCurrentStorage.Size = new System.Drawing.Size(168, 35);
            this.TxtSetCurrentStorage.TabIndex = 3;
            // 
            // LabelCurrentStorage
            // 
            this.LabelCurrentStorage.AutoSize = true;
            this.LabelCurrentStorage.Location = new System.Drawing.Point(26, 23);
            this.LabelCurrentStorage.Name = "LabelCurrentStorage";
            this.LabelCurrentStorage.Size = new System.Drawing.Size(160, 27);
            this.LabelCurrentStorage.TabIndex = 2;
            this.LabelCurrentStorage.Text = "Current Storage";
            // 
            // TxtNewTableName
            // 
            this.TxtNewTableName.Location = new System.Drawing.Point(125, 99);
            this.TxtNewTableName.Name = "TxtNewTableName";
            this.TxtNewTableName.Size = new System.Drawing.Size(304, 35);
            this.TxtNewTableName.TabIndex = 1;
            // 
            // BtnCreateTable
            // 
            this.BtnCreateTable.Location = new System.Drawing.Point(125, 159);
            this.BtnCreateTable.Name = "BtnCreateTable";
            this.BtnCreateTable.Size = new System.Drawing.Size(175, 40);
            this.BtnCreateTable.TabIndex = 0;
            this.BtnCreateTable.Text = "Create Storage";
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
            this.TabCardsStorage.ResumeLayout(false);
            this.TabCardsStorage.PerformLayout();
            this.TabBrowseCards.ResumeLayout(false);
            this.TabBrowseCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBrowseCards)).EndInit();
            this.TabSettings.ResumeLayout(false);
            this.TabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabDrillsGenerator;
        private System.Windows.Forms.TabPage TabStudyCards;
        private System.Windows.Forms.TabPage TabCardsStorage;
        private System.Windows.Forms.TabPage TabBrowseCards;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelExample;
        private System.Windows.Forms.Label LabelMeaning;
        private System.Windows.Forms.Label LableConstruction;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.TextBox TxtExample;
        private System.Windows.Forms.TextBox TxtMeaning;
        private System.Windows.Forms.TextBox TxtConstruction;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DataGridBrowseCards;
        private System.Windows.Forms.TextBox TxtNewTableName;
        private System.Windows.Forms.Button BtnCreateTable;
        private System.Windows.Forms.TextBox TxtSetCurrentStorage;
        private System.Windows.Forms.Label LabelCurrentStorage;
        private System.Windows.Forms.Button BtnSelectCurrentStorage;
        private System.Windows.Forms.TextBox TxtCurrentStorage;
    }
}

