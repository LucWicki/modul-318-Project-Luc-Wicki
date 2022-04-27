namespace SwissTransportGUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Startstation = new System.Windows.Forms.Label();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Zielbox = new System.Windows.Forms.TextBox();
            this.StartSuggestedStations = new System.Windows.Forms.DataGridView();
            this.Startstationen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Abfahrtstafel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Umsteigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Startsearchbutton = new System.Windows.Forms.Button();
            this.EndSuggestedStations = new System.Windows.Forms.DataGridView();
            this.Endstationen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endsearchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartSuggestedStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndSuggestedStations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy | hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1405, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 43);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Startstation
            // 
            this.Startstation.AutoSize = true;
            this.Startstation.Location = new System.Drawing.Point(25, 30);
            this.Startstation.Name = "Startstation";
            this.Startstation.Size = new System.Drawing.Size(152, 37);
            this.Startstation.TabIndex = 1;
            this.Startstation.Text = "Startstation";
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(212, 30);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(318, 43);
            this.StartBox.TabIndex = 2;
            this.StartBox.Enter += new System.EventHandler(this.SearchStation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endstation";
            // 
            // Zielbox
            // 
            this.Zielbox.Location = new System.Drawing.Point(873, 30);
            this.Zielbox.Name = "Zielbox";
            this.Zielbox.Size = new System.Drawing.Size(334, 43);
            this.Zielbox.TabIndex = 4;
            this.Zielbox.Enter += new System.EventHandler(this.SearchStation);
            // 
            // StartSuggestedStations
            // 
            this.StartSuggestedStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StartSuggestedStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Startstationen});
            this.StartSuggestedStations.Location = new System.Drawing.Point(54, 157);
            this.StartSuggestedStations.Name = "StartSuggestedStations";
            this.StartSuggestedStations.RowHeadersWidth = 92;
            this.StartSuggestedStations.RowTemplate.Height = 45;
            this.StartSuggestedStations.Size = new System.Drawing.Size(521, 309);
            this.StartSuggestedStations.TabIndex = 5;
            // 
            // Startstationen
            // 
            this.Startstationen.HeaderText = "Startstationen";
            this.Startstationen.MinimumWidth = 11;
            this.Startstationen.Name = "Startstationen";
            this.Startstationen.Width = 225;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Abfahrtszeit,
            this.Ankunft,
            this.Ankunftszeit});
            this.dataGridView2.Location = new System.Drawing.Point(54, 561);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 92;
            this.dataGridView2.RowTemplate.Height = 45;
            this.dataGridView2.Size = new System.Drawing.Size(1041, 309);
            this.dataGridView2.TabIndex = 6;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 11;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.Width = 225;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.MinimumWidth = 11;
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 225;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 11;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.Width = 225;
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.MinimumWidth = 11;
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.Width = 225;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stationen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Verbindungen";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtstafel});
            this.dataGridView3.Location = new System.Drawing.Point(1195, 157);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 92;
            this.dataGridView3.RowTemplate.Height = 45;
            this.dataGridView3.Size = new System.Drawing.Size(397, 309);
            this.dataGridView3.TabIndex = 9;
            // 
            // Abfahrtstafel
            // 
            this.Abfahrtstafel.HeaderText = "Abfahrtstafel";
            this.Abfahrtstafel.MinimumWidth = 11;
            this.Abfahrtstafel.Name = "Abfahrtstafel";
            this.Abfahrtstafel.Width = 225;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Umsteigen});
            this.dataGridView4.Location = new System.Drawing.Point(1195, 561);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 92;
            this.dataGridView4.RowTemplate.Height = 45;
            this.dataGridView4.Size = new System.Drawing.Size(397, 309);
            this.dataGridView4.TabIndex = 10;
            // 
            // Umsteigen
            // 
            this.Umsteigen.HeaderText = "Umsteigen";
            this.Umsteigen.MinimumWidth = 11;
            this.Umsteigen.Name = "Umsteigen";
            this.Umsteigen.Width = 225;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1405, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum und Uhrzeit";
            // 
            // Startsearchbutton
            // 
            this.Startsearchbutton.Location = new System.Drawing.Point(536, 25);
            this.Startsearchbutton.Name = "Startsearchbutton";
            this.Startsearchbutton.Size = new System.Drawing.Size(169, 52);
            this.Startsearchbutton.TabIndex = 12;
            this.Startsearchbutton.Text = "Search";
            this.Startsearchbutton.UseVisualStyleBackColor = true;
            this.Startsearchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // EndSuggestedStations
            // 
            this.EndSuggestedStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EndSuggestedStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Endstationen});
            this.EndSuggestedStations.Location = new System.Drawing.Point(574, 157);
            this.EndSuggestedStations.Name = "EndSuggestedStations";
            this.EndSuggestedStations.RowHeadersWidth = 92;
            this.EndSuggestedStations.RowTemplate.Height = 45;
            this.EndSuggestedStations.Size = new System.Drawing.Size(521, 309);
            this.EndSuggestedStations.TabIndex = 13;
            // 
            // Endstationen
            // 
            this.Endstationen.HeaderText = "Endstationen";
            this.Endstationen.MinimumWidth = 11;
            this.Endstationen.Name = "Endstationen";
            this.Endstationen.Width = 225;
            // 
            // Endsearchbutton
            // 
            this.Endsearchbutton.Location = new System.Drawing.Point(1213, 25);
            this.Endsearchbutton.Name = "Endsearchbutton";
            this.Endsearchbutton.Size = new System.Drawing.Size(169, 52);
            this.Endsearchbutton.TabIndex = 14;
            this.Endsearchbutton.Text = "Search";
            this.Endsearchbutton.UseVisualStyleBackColor = true;
            this.Endsearchbutton.Click += new System.EventHandler(this.Endsearchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 1011);
            this.Controls.Add(this.Endsearchbutton);
            this.Controls.Add(this.EndSuggestedStations);
            this.Controls.Add(this.Startsearchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.StartSuggestedStations);
            this.Controls.Add(this.Zielbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.Startstation);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartSuggestedStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndSuggestedStations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label Startstation;
        private TextBox StartBox;
        private Label label2;
        private TextBox Zielbox;
        private DataGridView StartSuggestedStations;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Abfahrtstafel;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Umsteigen;
        private Label label1;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Abfahrtszeit;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Ankunftszeit;
        private Button Startsearchbutton;
        private DataGridViewTextBoxColumn Startstationen;
        private DataGridView EndSuggestedStations;
        private DataGridViewTextBoxColumn Endstationen;
        private Button Endsearchbutton;
    }
}