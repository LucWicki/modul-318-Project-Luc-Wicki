﻿using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Startstation suchen 
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            StartCombobox.Items.Clear();
            if (StartCombobox.Text == "")
            {
                MessageBox.Show("Bitte löschen Sie den Inhalt und geben Sie eine Station ein");
                StartCombobox.Text = "Hier eingeben";
            }

            //Text(Startstation) aus textbox in Variable speichern
            string StartStation = StartCombobox.Text;

           
            //Text mit ähnlichen Daten der Datenbank abgleichen/ holen/ suchen
            ITransport start = new Transport();
            Stations startstations = start.GetStations(StartStation);
            foreach (Station station in startstations.StationList)
            {
                StartCombobox.Items.Add(station.Name);
            }
            StartCombobox.DroppedDown = true;
        }

        //Endstation suchen
        private void Endsearchbutton_Click(object sender, EventArgs e)
        {
            EndCombobox.Items.Clear();
            if (EndCombobox.Text == "")
            {
                MessageBox.Show("Bitte löschen Sie den Inhalt und geben Sie eine Station ein");
                EndCombobox.Text = "Hier eingeben";
            }
            //Text(Startstation) aus textbox in Variable speichern
            string EndStation = EndCombobox.Text;
            //Text mit ähnlichen Daten der Datenbank abgleichen/ holen/ suchen
            ITransport end = new Transport();
            Stations endstations = end.GetStations(EndStation);

            foreach (Station station in endstations.StationList)
            {
                EndCombobox.Items.Add(station.Name);
            }
            EndCombobox.DroppedDown = true;
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            ConnectionTimes.Rows.Clear();
            string StartStation = StartCombobox.Text;
            string EndStation = EndCombobox.Text;
            DateTime Time = FutureTime.Value;
            DateTime Date = FutureDate.Value;

            //Verbindungen zwischen Startstation und Endstation suchen
            ITransport connect = new Transport();

            //Endstation wird von der Eingabe genommen
            if (EndStation != "")
            {
                Connections connections = connect.GetConnections(StartStation, EndStation, Date, Time);

                //Verbindungen (Zeiten) in DatatGriedview "Verbindungen" einfügen
                foreach (Connection connection in connections.ConnectionList)
                {
                    ConnectionTimes.Rows.Add(new[]
                       {
                    connection.From.Departure.ToString(),
                    connection.To.Arrival.ToString()
                });
                }
            }
            //Endstation wird von der Abfahrtstafel genommen
            else if (EndStation == "")
            {
                //StackOverflow: Es wird der Inhalt der ausgewählten Reihe abgerufen
                string DepartureRow = DepartureBoard.SelectedRows[0].Cells[0].Value.ToString();

                //Wieder mein code
                Connections Departconnections = connect.GetConnections(StartStation, DepartureRow, Date, Time);

                foreach (Connection connection in Departconnections.ConnectionList)
                {
                    ConnectionTimes.Rows.Add(new[]
                       {
                    connection.From.Departure.ToString(),
                    connection.To.Arrival.ToString()
                });
                }
            }
        }

        private void StationBoardButton_Click(object sender, EventArgs e)
        {
            if (StartCombobox.Text == "")
            {
                MessageBox.Show("Bitte löschen Sie den Inhalt und geben Sie eine Station ein");
                StartCombobox.Text = "Hier eingeben";
            }
            EndCombobox.Items.Clear();
            EndCombobox.Text = "";
            string StartStation = StartCombobox.Text;
            ITransport Depart = new Transport();
            StationBoardRoot stationBoards = Depart.GetStationBoard(StartStation, "eijadsfj");

            //Abfahrtstafel befülllen
            foreach (StationBoard stations in stationBoards.Entries)
            {
                DepartureBoard.Rows.Add(new[] {
                    stations.To
                    }); 
            }
        }
}
}
