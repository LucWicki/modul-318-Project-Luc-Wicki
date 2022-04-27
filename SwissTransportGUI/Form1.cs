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
            string StartStation = StartCombobox.Text;
            string EndStation = EndCombobox.Text;

            //Verbindungen zwischen Startstation und Endstation suchen
            ITransport connect = new Transport();
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

        //Fahrzeug wechsel Umstiege in "Umsteigen" (DatatGriedview) einfügen



    }

       
    
}
