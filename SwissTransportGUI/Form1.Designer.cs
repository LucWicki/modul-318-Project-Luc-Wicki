﻿namespace SwissTransportGUI
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
            this.FutureDate = new System.Windows.Forms.DateTimePicker();
            this.Startstation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectionTimes = new System.Windows.Forms.DataGridView();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureBoard = new System.Windows.Forms.DataGridView();
            this.Abfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Startsearchbutton = new System.Windows.Forms.Button();
            this.Endsearchbutton = new System.Windows.Forms.Button();
            this.StartCombobox = new System.Windows.Forms.ComboBox();
            this.EndCombobox = new System.Windows.Forms.ComboBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StationBoardButton = new System.Windows.Forms.Button();
            this.FutureTime = new System.Windows.Forms.DateTimePicker();
            this.Umsteigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // FutureDate
            // 
            this.FutureDate.CustomFormat = "dd.MM.yyyy ";
            this.FutureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FutureDate.Location = new System.Drawing.Point(1662, 25);
            this.FutureDate.Name = "FutureDate";
            this.FutureDate.Size = new System.Drawing.Size(224, 43);
            this.FutureDate.TabIndex = 4;
            // 
            // Startstation
            // 
            this.Startstation.AutoSize = true;
            this.Startstation.Location = new System.Drawing.Point(25, 30);
            this.Startstation.Name = "Startstation";
            this.Startstation.Size = new System.Drawing.Size(152, 37);
            this.Startstation.TabIndex = 11;
            this.Startstation.Text = "Startstation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Endstation";
            // 
            // ConnectionTimes
            // 
            this.ConnectionTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectionTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit,
            this.Ankunftszeit});
            this.ConnectionTimes.Location = new System.Drawing.Point(40, 173);
            this.ConnectionTimes.Name = "ConnectionTimes";
            this.ConnectionTimes.RowHeadersWidth = 92;
            this.ConnectionTimes.RowTemplate.Height = 45;
            this.ConnectionTimes.Size = new System.Drawing.Size(1021, 207);
            this.ConnectionTimes.TabIndex = 6;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.MinimumWidth = 11;
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.MinimumWidth = 11;
            this.Ankunftszeit.Name = "Ankunftszeit";
            // 
            // DepartureBoard
            // 
            this.DepartureBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtstafel});
            this.DepartureBoard.Location = new System.Drawing.Point(1154, 173);
            this.DepartureBoard.MultiSelect = false;
            this.DepartureBoard.Name = "DepartureBoard";
            this.DepartureBoard.ReadOnly = true;
            this.DepartureBoard.RowHeadersWidth = 92;
            this.DepartureBoard.RowTemplate.Height = 45;
            this.DepartureBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartureBoard.Size = new System.Drawing.Size(838, 207);
            this.DepartureBoard.TabIndex = 8;
            // 
            // Abfahrtstafel
            // 
            this.Abfahrtstafel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrtstafel.HeaderText = "Abfahrtstafel";
            this.Abfahrtstafel.MinimumWidth = 11;
            this.Abfahrtstafel.Name = "Abfahrtstafel";
            this.Abfahrtstafel.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1414, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datum und Uhrzeit";
            // 
            // Startsearchbutton
            // 
            this.Startsearchbutton.Location = new System.Drawing.Point(536, 25);
            this.Startsearchbutton.Name = "Startsearchbutton";
            this.Startsearchbutton.Size = new System.Drawing.Size(169, 52);
            this.Startsearchbutton.TabIndex = 1;
            this.Startsearchbutton.Text = "Search";
            this.Startsearchbutton.UseVisualStyleBackColor = true;
            this.Startsearchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Endsearchbutton
            // 
            this.Endsearchbutton.Location = new System.Drawing.Point(1213, 25);
            this.Endsearchbutton.Name = "Endsearchbutton";
            this.Endsearchbutton.Size = new System.Drawing.Size(169, 52);
            this.Endsearchbutton.TabIndex = 3;
            this.Endsearchbutton.Text = "Search";
            this.Endsearchbutton.UseVisualStyleBackColor = true;
            this.Endsearchbutton.Click += new System.EventHandler(this.Endsearchbutton_Click);
            // 
            // StartCombobox
            // 
            this.StartCombobox.FormattingEnabled = true;
            this.StartCombobox.Location = new System.Drawing.Point(205, 25);
            this.StartCombobox.Name = "StartCombobox";
            this.StartCombobox.Size = new System.Drawing.Size(272, 45);
            this.StartCombobox.TabIndex = 0;
            // 
            // EndCombobox
            // 
            this.EndCombobox.FormattingEnabled = true;
            this.EndCombobox.Location = new System.Drawing.Point(873, 27);
            this.EndCombobox.Name = "EndCombobox";
            this.EndCombobox.Size = new System.Drawing.Size(272, 45);
            this.EndCombobox.TabIndex = 2;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(40, 100);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(368, 52);
            this.ConnectionButton.TabIndex = 6;
            this.ConnectionButton.Text = "Verbindungen anzeigen";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 18;
            // 
            // StationBoardButton
            // 
            this.StationBoardButton.Location = new System.Drawing.Point(1154, 108);
            this.StationBoardButton.Name = "StationBoardButton";
            this.StationBoardButton.Size = new System.Drawing.Size(492, 52);
            this.StationBoardButton.TabIndex = 7;
            this.StationBoardButton.Text = "Mögliche Endstationen anzeigen";
            this.StationBoardButton.UseVisualStyleBackColor = true;
            this.StationBoardButton.Click += new System.EventHandler(this.StationBoardButton_Click);
            // 
            // FutureTime
            // 
            this.FutureTime.CustomFormat = "hh:mm";
            this.FutureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FutureTime.Location = new System.Drawing.Point(1892, 25);
            this.FutureTime.Name = "FutureTime";
            this.FutureTime.Size = new System.Drawing.Size(127, 43);
            this.FutureTime.TabIndex = 5;
            this.FutureTime.Value = new System.DateTime(2022, 4, 29, 10, 15, 0, 0);
            // 
            // Umsteigen
            // 
            this.Umsteigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Umsteigen.HeaderText = "Umsteigen in";
            this.Umsteigen.MinimumWidth = 11;
            this.Umsteigen.Name = "Umsteigen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2098, 569);
            this.Controls.Add(this.FutureTime);
            this.Controls.Add(this.StationBoardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.EndCombobox);
            this.Controls.Add(this.StartCombobox);
            this.Controls.Add(this.Endsearchbutton);
            this.Controls.Add(this.Startsearchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartureBoard);
            this.Controls.Add(this.ConnectionTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Startstation);
            this.Controls.Add(this.FutureDate);
            this.Name = "Form1";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker FutureDate;
        private Label Startstation;
        private Label label2;
        private DataGridView ConnectionTimes;
        private DataGridView DepartureBoard;
        private Label label1;
        private Button Startsearchbutton;
        private Button Endsearchbutton;
        private ComboBox StartCombobox;
        private ComboBox EndCombobox;
        private Button ConnectionButton;
        private Label label3;
        private DataGridViewTextBoxColumn Abfahrtszeit;
        private DataGridViewTextBoxColumn Ankunftszeit;
        private Button StationBoardButton;
        private DateTimePicker FutureTime;
        private DataGridViewTextBoxColumn Abfahrtstafel;
        private DataGridViewTextBoxColumn Umsteigen;
    }
}