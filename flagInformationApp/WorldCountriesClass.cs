using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace flagInformationApp
{
    public class WorldCountriesClass
    {
        public string countryName { get; set; }
        public string countryCurrency { get; set; }
        public string countryPopulation { get; set; }
        public string countryCapital { get; set; }
        public string countryImage { get; set; }

        public string continentName { get; set; }
        public string continentSource { get; set; }
    }
}