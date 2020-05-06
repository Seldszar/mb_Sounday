namespace MusicBeePlugin
{
    partial class SettingsWindow
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
            this.headersDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueVolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.requestUriLabel = new System.Windows.Forms.Label();
            this.headersLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.requestUriTextBox = new System.Windows.Forms.TextBox();
            this.requestMethodComboBox = new System.Windows.Forms.ComboBox();
            this.mediaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.fieldsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.headersDataGridView)).BeginInit();
            this.settingsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headersDataGridView
            // 
            this.headersDataGridView.AllowUserToResizeRows = false;
            this.headersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.headersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ValueVolumn});
            this.headersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headersDataGridView.EnableHeadersVisualStyles = false;
            this.headersDataGridView.Location = new System.Drawing.Point(3, 76);
            this.headersDataGridView.Name = "headersDataGridView";
            this.headersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.headersDataGridView.Size = new System.Drawing.Size(458, 134);
            this.headersDataGridView.TabIndex = 1;
            this.headersDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OnCellFormatting);
            this.headersDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OnEditingControlShowing);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // ValueVolumn
            // 
            this.ValueVolumn.HeaderText = "Value";
            this.ValueVolumn.Name = "ValueVolumn";
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.ColumnCount = 1;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.Controls.Add(this.headersDataGridView, 2, 3);
            this.settingsTableLayoutPanel.Controls.Add(this.saveButton, 0, 8);
            this.settingsTableLayoutPanel.Controls.Add(this.requestUriLabel, 0, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.headersLabel, 0, 2);
            this.settingsTableLayoutPanel.Controls.Add(this.contentLabel, 0, 5);
            this.settingsTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.settingsTableLayoutPanel.Controls.Add(this.mediaTypeComboBox, 0, 6);
            this.settingsTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 9;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(464, 441);
            this.settingsTableLayoutPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(3, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(458, 34);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSave);
            // 
            // requestUriLabel
            // 
            this.requestUriLabel.AutoSize = true;
            this.requestUriLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestUriLabel.Location = new System.Drawing.Point(0, 0);
            this.requestUriLabel.Margin = new System.Windows.Forms.Padding(0);
            this.requestUriLabel.Name = "requestUriLabel";
            this.requestUriLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.requestUriLabel.Size = new System.Drawing.Size(464, 18);
            this.requestUriLabel.TabIndex = 4;
            this.requestUriLabel.Text = "Request URI";
            this.requestUriLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // headersLabel
            // 
            this.headersLabel.AutoSize = true;
            this.headersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headersLabel.Location = new System.Drawing.Point(0, 45);
            this.headersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headersLabel.Name = "headersLabel";
            this.headersLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.headersLabel.Size = new System.Drawing.Size(464, 28);
            this.headersLabel.TabIndex = 5;
            this.headersLabel.Text = "Headers";
            this.headersLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLabel.Location = new System.Drawing.Point(0, 213);
            this.contentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.contentLabel.Size = new System.Drawing.Size(464, 28);
            this.contentLabel.TabIndex = 6;
            this.contentLabel.Text = "Content";
            this.contentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.requestUriTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.requestMethodComboBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 27);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // requestUriTextBox
            // 
            this.requestUriTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestUriTextBox.Location = new System.Drawing.Point(83, 3);
            this.requestUriTextBox.Name = "requestUriTextBox";
            this.requestUriTextBox.Size = new System.Drawing.Size(378, 20);
            this.requestUriTextBox.TabIndex = 2;
            // 
            // requestMethodComboBox
            // 
            this.requestMethodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.requestMethodComboBox.FormattingEnabled = true;
            this.requestMethodComboBox.Items.AddRange(new object[] {
            "DELETE",
            "GET",
            "PATCH",
            "POST",
            "PUT"});
            this.requestMethodComboBox.Location = new System.Drawing.Point(3, 3);
            this.requestMethodComboBox.Name = "requestMethodComboBox";
            this.requestMethodComboBox.Size = new System.Drawing.Size(74, 21);
            this.requestMethodComboBox.TabIndex = 3;
            // 
            // mediaTypeComboBox
            // 
            this.mediaTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.mediaTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaTypeComboBox.FormattingEnabled = true;
            this.mediaTypeComboBox.Items.AddRange(new object[] {
            "application/json",
            "application/x-www-form-urlencoded",
            "application/xml",
            "text/plain",
            "text/xml"});
            this.mediaTypeComboBox.Location = new System.Drawing.Point(3, 244);
            this.mediaTypeComboBox.Name = "mediaTypeComboBox";
            this.mediaTypeComboBox.Size = new System.Drawing.Size(458, 21);
            this.mediaTypeComboBox.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.contentTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fieldsPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 268);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 133);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // contentTextBox
            // 
            this.contentTextBox.AcceptsReturn = true;
            this.contentTextBox.AcceptsTab = true;
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.contentTextBox.Location = new System.Drawing.Point(3, 3);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(332, 127);
            this.contentTextBox.TabIndex = 3;
            this.contentTextBox.WordWrap = false;
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.AutoScroll = true;
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsPanel.Location = new System.Drawing.Point(341, 3);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(120, 127);
            this.fieldsPanel.TabIndex = 4;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.settingsTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Sounday";
            this.Shown += new System.EventHandler(this.OnShown);
            ((System.ComponentModel.ISupportInitialize)(this.headersDataGridView)).EndInit();
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.settingsTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label requestUriLabel;
        private System.Windows.Forms.Label headersLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueVolumn;
        private System.Windows.Forms.DataGridView headersDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox requestUriTextBox;
        private System.Windows.Forms.ComboBox requestMethodComboBox;
        private System.Windows.Forms.ComboBox mediaTypeComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Panel fieldsPanel;
    }
}