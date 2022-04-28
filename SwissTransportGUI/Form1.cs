using SwissTransport.Core;
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
                ITransport trans = new Transport();
                Stations startstations = trans.GetStations(StartStation);
                foreach (Station station in startstations.StationList)
                {
                    StartCombobox.Items.Add(station.Name);
                }
                StartCombobox.DroppedDown = true;

            
        }

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
            ITransport trans = new Transport();
            Stations endstations = trans.GetStations(EndStation);

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

            //Verbindungen zwischen Startstation und Endstation suchen
            ITransport connect = new Transport();

            if (EndStation != "")
            {
                Connections connections = connect.GetConnections(StartStation, EndStation);

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
            else if (EndStation == "")
            {
                //StackOverflow
                string DepartureRow = DepartureBoard.SelectedRows[0].Cells[0].Value.ToString();

                //Mein Code
                Connections Departconnections = connect.GetConnections(StartStation, DepartureRow);

                foreach (Connection connection in Departconnections.ConnectionList)
                {
                    ConnectionTimes.Rows.Add(new[]
                       {
                    connection.From.Departure.ToString(),
                    connection.To.Arrival.ToString()
                });
                }
            }
            //Fahrzeug wechsel Umstiege in "Umsteigen" (DatatGriedview) einfügen

        }

        private void StationBoardButton_Click(object sender, EventArgs e)
        {
            string StartStation = StartCombobox.Text;
            ITransport Depart = new Transport();
            StationBoardRoot stationBoards = Depart.GetStationBoard(StartStation, "eijadsfj");

            foreach (StationBoard stations in stationBoards.Entries)
            {
                DepartureBoard.Rows.Add(new[] {
                    stations.To
                    }); 
            }


        }

       
    }

       
    
}
