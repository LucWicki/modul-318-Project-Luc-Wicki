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

        private void SearchStation(object sender, EventArgs e)
        {
            //string Suggest =  ;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            //Text(Startstation) aus textbox in Variable speichern
            string StartStation = StartBox.Text;
            //Text mit ähnlichen Daten der Datenbank abgleichen/ holen/ suchen
            ITransport trans = new Transport();
            Stations startstations = trans.GetStations(StartStation);


            //Suchergebnisse in der Tabelle/ Comboox aufführen, Liste von Stationen 
            foreach (Station station in startstations.StationList)
            {
                StartSuggestedStations.Rows.Add(new[]
                {
                station.Name,
            });
            }
        }

        private void Endsearchbutton_Click(object sender, EventArgs e)
        {
            //Text(Startstation) aus textbox in Variable speichern
            string EndStation = Zielbox.Text;

            //Text mit ähnlichen Daten der Datenbank abgleichen/ holen/ suchen
            ITransport trans = new Transport();
            Stations endstations = trans.GetStations(EndStation);


            //Suchergebnisse in der Tabelle/ Comboox aufführen, Liste von Stationen 
            foreach (Station station in endstations.StationList)
            {
                EndSuggestedStations.Rows.Add(new[]
                {
                station.Name,
            });
            }
            
        }
    }
}
