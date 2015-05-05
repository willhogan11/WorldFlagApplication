using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace flagInformationApp
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        // List of items of type EuropeanCountries
        public List<WorldCountriesClass> ListOfEuropeanCountries;

        // List of Items of type AsianCountries
        public List<WorldCountriesClass> ListOfAsianCountries;

        // List of Items of type AfricanCountries
        public List<WorldCountriesClass> ListOfAfricanCountries;

        // List of Items of type NorthAmericanCountries
        public List<WorldCountriesClass> ListOfNorthAmericanCountries;

        // List of Items of type SouthAmericanCountries
        public List<WorldCountriesClass> ListOfSouthAmericanCountries;

        // List of Items of type OceaniaCountries
        public List<WorldCountriesClass> ListOfOceaniaCountries;
        


        public PivotPage1()
        {
            InitializeComponent();
            loadFlagData();
        }

        private void loadFlagData()
        {

        }


        // Pivot Page Function
        private void Pivot_LoadingPivotItem(object sender, PivotItemEventArgs e)
        {
            
            switch (e.Item.Header.ToString())
            {
                case "Europe":
                    {
                        if (ListOfEuropeanCountries == null)
                        {
                            ListOfEuropeanCountries = new List<WorldCountriesClass>();
                            fillTheEuropeanList();
                            countriesEurope.ItemsSource = ListOfEuropeanCountries;
                        }
                        europe.Visibility = System.Windows.Visibility.Visible;
                        oceania.Visibility = System.Windows.Visibility.Collapsed;
                        asia.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                case "Asia":
                    {
                        if (ListOfAsianCountries == null)
                        {
                            ListOfAsianCountries = new List<WorldCountriesClass>();
                            fillTheAsianList();
                            countriesAsia.ItemsSource = ListOfAsianCountries;
                           
                        }
                        asia.Visibility = System.Windows.Visibility.Visible;
                        europe.Visibility = System.Windows.Visibility.Collapsed;
                        africa.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                case "Africa":
                    {
                        if (ListOfAfricanCountries == null)
                        {
                            ListOfAfricanCountries = new List<WorldCountriesClass>();
                            fillTheAfricanList();
                            countriesAfrica.ItemsSource = ListOfAfricanCountries;
                      
                        }
                        africa.Visibility = System.Windows.Visibility.Visible;
                        asia.Visibility = System.Windows.Visibility.Collapsed;
                        northAmerica.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                case "North America":
                    {
                        if (ListOfNorthAmericanCountries == null)
                        {
                            ListOfNorthAmericanCountries = new List<WorldCountriesClass>();
                            fillTheNorthAmericanList();
                            countriesNorthAmerica.ItemsSource = ListOfNorthAmericanCountries;
                   
                        }
                        northAmerica.Visibility = System.Windows.Visibility.Visible;
                        africa.Visibility = System.Windows.Visibility.Collapsed;
                        southAmerica.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                case "South America":
                    {
                        if (ListOfSouthAmericanCountries == null)
                        {
                            ListOfSouthAmericanCountries = new List<WorldCountriesClass>();
                            fillTheSouthAmericanList();
                            countriesSouthAmerica.ItemsSource = ListOfSouthAmericanCountries;
                           
                        }
                        southAmerica.Visibility = System.Windows.Visibility.Visible;
                        northAmerica.Visibility = System.Windows.Visibility.Collapsed;
                        oceania.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                case "Oceania":
                    {
                        if (ListOfOceaniaCountries == null)
                        {
                            ListOfOceaniaCountries = new List<WorldCountriesClass>();
                            fillTheOceaniaList();
                            countriesOceania.ItemsSource = ListOfOceaniaCountries;
                      
                        }
                        oceania.Visibility = System.Windows.Visibility.Visible;
                        southAmerica.Visibility = System.Windows.Visibility.Collapsed;
                        europe.Visibility = System.Windows.Visibility.Collapsed;
                        break;
                    }
                default:
                    break;

            } // End of switch (e.Item.Header.ToString())
            

        } // End of Pivot_LoadingPivotItem function



        // fillTheEuropeanList() Function
        private void fillTheEuropeanList()
        {
            WorldCountriesClass tmpCountry;

            // Albania
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Albania";
            tmpCountry.countryCurrency = "Lek";
            tmpCountry.countryPopulation = "2.7 Million";
            tmpCountry.countryCapital = "Tirana";
            tmpCountry.countryImage = "EuropeanImages/Albania.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Andorra
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Andorra";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "80,000";
            tmpCountry.countryCapital = "Andorra La Vella";
            tmpCountry.countryImage = "EuropeanImages/Andorra.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Armenia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Armenia";
            tmpCountry.countryCurrency = "Armenian Dram";
            tmpCountry.countryPopulation = "2.9 Million";
            tmpCountry.countryCapital = "Yerevan";
            tmpCountry.countryImage = "EuropeanImages/Armenia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Austria
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Austria";
            tmpCountry.countryCurrency = "Armenian Dram";
            tmpCountry.countryPopulation = "8.4 Million";
            tmpCountry.countryCapital = "Vienna";
            tmpCountry.countryImage = "EuropeanImages/Austria.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Belarus
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Belarus";
            tmpCountry.countryCurrency = "Belarusian Ruble";
            tmpCountry.countryPopulation = "9.4 Million";
            tmpCountry.countryCapital = "Minsk";
            tmpCountry.countryImage = "EuropeanImages/Belarus.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Belgium
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Belgium";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "11 Million";
            tmpCountry.countryCapital = "Brussels";
            tmpCountry.countryImage = "EuropeanImages/Belgium.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Bosnia Herzegovina
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bosnia Herzegovina";
            tmpCountry.countryCurrency = "Bosnia Herzegovina Mark";
            tmpCountry.countryPopulation = "3.7 Million";
            tmpCountry.countryCapital = "Sarajevo";
            tmpCountry.countryImage = "EuropeanImages/Bosnia Herzegovina.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Bulgaria
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bulgaria";
            tmpCountry.countryCurrency = "Bulgarian Lev";
            tmpCountry.countryPopulation = "7.2 Million";
            tmpCountry.countryCapital = "Sofia";
            tmpCountry.countryImage = "EuropeanImages/Bulgaria.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Croatia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Croatia";
            tmpCountry.countryCurrency = "Croatian Kuna";
            tmpCountry.countryPopulation = "4.2 Million";
            tmpCountry.countryCapital = "Zagreb";
            tmpCountry.countryImage = "EuropeanImages/Croatia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Cyprus
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cyprus";
            tmpCountry.countryCurrency = "";
            tmpCountry.countryPopulation = "865,800";
            tmpCountry.countryCapital = "Nicosia";
            tmpCountry.countryImage = "EuropeanImages/Cyprus.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Czech Republic
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Czech Republic";
            tmpCountry.countryCurrency = "Czech Koruna";
            tmpCountry.countryPopulation = "10.5 Million";
            tmpCountry.countryCapital = "Prague";
            tmpCountry.countryImage = "EuropeanImages/Czech Republic.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Denmark
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Denmark";
            tmpCountry.countryCurrency = "Danish Krone";
            tmpCountry.countryPopulation = "5.6 Million";
            tmpCountry.countryCapital = "Copenhagen";
            tmpCountry.countryImage = "EuropeanImages/Denmark.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // England
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "England";
            tmpCountry.countryCurrency = "Pound";
            tmpCountry.countryPopulation = "56 Million";
            tmpCountry.countryCapital = "London";
            tmpCountry.countryImage = "EuropeanImages/England.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Estonia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Estonia";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "1.3 Million";
            tmpCountry.countryCapital = "Tallinn";
            tmpCountry.countryImage = "EuropeanImages/Estonia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Faroe Islands
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "";
            tmpCountry.countryCurrency = "Faroese Krone";
            tmpCountry.countryPopulation = "49,460";
            tmpCountry.countryCapital = "Tórshavn";
            tmpCountry.countryImage = "EuropeanImages/Faroe Islands.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Finland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Finland";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "5.4 Million";
            tmpCountry.countryCapital = "Helsinki";
            tmpCountry.countryImage = "EuropeanImages/Finland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // France
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "France";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "65 Million";
            tmpCountry.countryCapital = "Paris";
            tmpCountry.countryImage = "EuropeanImages/France.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Georgia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Georgia";
            tmpCountry.countryCurrency = "Georgian Lari";
            tmpCountry.countryPopulation = "4.4 Million";
            tmpCountry.countryCapital = "Tbilisi";
            tmpCountry.countryImage = "EuropeanImages/Georgia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Germany
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Germany";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "80 Million";
            tmpCountry.countryCapital = "Berlin";
            tmpCountry.countryImage = "EuropeanImages/Germany.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Greece
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Greece";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "10.8 Million";
            tmpCountry.countryCapital = "Athens";
            tmpCountry.countryImage = "EuropeanImages/Greece.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Holland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Holland";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "16.8 Million";
            tmpCountry.countryCapital = "Amsterdam";
            tmpCountry.countryImage = "EuropeanImages/Holland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Hungary
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Hungary";
            tmpCountry.countryCurrency = "Hungarian Forint";
            tmpCountry.countryPopulation = "9.9 Million";
            tmpCountry.countryCapital = "Budapest";
            tmpCountry.countryImage = "EuropeanImages/Hungary.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Iceland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Iceland";
            tmpCountry.countryCurrency = "Icelandic Króna";
            tmpCountry.countryPopulation = "325,700";
            tmpCountry.countryCapital = "Reykjavík";
            tmpCountry.countryImage = "EuropeanImages/Iceland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Ireland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Ireland";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "4.5 Million";
            tmpCountry.countryCapital = "Dublin";
            tmpCountry.countryImage = "EuropeanImages/Ireland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Italy
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Italy";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "59.9 Million";
            tmpCountry.countryCapital = "Rome";
            tmpCountry.countryImage = "EuropeanImages/Italy.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Kosovo
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kosovo";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "1.8 Million";
            tmpCountry.countryCapital = "Pristina";
            tmpCountry.countryImage = "EuropeanImages/Kosovo.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Latvia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Latvia";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Riga";
            tmpCountry.countryImage = "EuropeanImages/Latvia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Liechtenstein
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Liechtenstein";
            tmpCountry.countryCurrency = "Swiss Franc";
            tmpCountry.countryPopulation = "37,132";
            tmpCountry.countryCapital = "Vaduz";
            tmpCountry.countryImage = "EuropeanImages/Liechtenstein.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Lithuania
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Lithuania";
            tmpCountry.countryCurrency = "Lithuanian Litas";
            tmpCountry.countryPopulation = "2.94 Million";
            tmpCountry.countryCapital = "Vilnius";
            tmpCountry.countryImage = "EuropeanImages/Lithuania.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Luxembourg
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Luxembourg";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "537,000";
            tmpCountry.countryCapital = "Luxembourg City";
            tmpCountry.countryImage = "EuropeanImages/Luxembourg.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Macedonia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Macedonia";
            tmpCountry.countryCurrency = "Macedonian Denar";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Skopje";
            tmpCountry.countryImage = "EuropeanImages/Macedonia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Malta
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Malta";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "416,055";
            tmpCountry.countryCapital = "Valetta";
            tmpCountry.countryImage = "EuropeanImages/Malta.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Moldova
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Moldova";
            tmpCountry.countryCurrency = "Moldovan Leu";
            tmpCountry.countryPopulation = "3.55 Million";
            tmpCountry.countryCapital = "Chisinau";
            tmpCountry.countryImage = "EuropeanImages/Moldova.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Monaco
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Monaco";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "36,136";
            tmpCountry.countryCapital = "Monaco";
            tmpCountry.countryImage = "EuropeanImages/Monaco.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Montenegro
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Montenegro";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "620,029";
            tmpCountry.countryCapital = "Podgorica";
            tmpCountry.countryImage = "EuropeanImages/Montenegro.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Norway
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Norway";
            tmpCountry.countryCurrency = "Norwegian Krone";
            tmpCountry.countryPopulation = "5.1 Million";
            tmpCountry.countryCapital = "Oslo";
            tmpCountry.countryImage = "EuropeanImages/Norway.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Poland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Poland";
            tmpCountry.countryCurrency = "Polish Zloty";
            tmpCountry.countryPopulation = "38 Million";
            tmpCountry.countryCapital = "Warsaw";
            tmpCountry.countryImage = "EuropeanImages/Poland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Portugal
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Portugal";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "10.4 Million";
            tmpCountry.countryCapital = "Lisbon";
            tmpCountry.countryImage = "EuropeanImages/Portugal.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Romania
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Romania";
            tmpCountry.countryCurrency = "Romanian Leu";
            tmpCountry.countryPopulation = "20 Million";
            tmpCountry.countryCapital = "Bucharest";
            tmpCountry.countryImage = "EuropeanImages/Romania.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Russia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Russia";
            tmpCountry.countryCurrency = "Russian Ruble";
            tmpCountry.countryPopulation = "143 Million";
            tmpCountry.countryCapital = "Moscow";
            tmpCountry.countryImage = "EuropeanImages/Russia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // San Marino
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "San Marino";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "33,540";
            tmpCountry.countryCapital = "San Marino";
            tmpCountry.countryImage = "EuropeanImages/San Marino.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Scotland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Scotland";
            tmpCountry.countryCurrency = "Pound";
            tmpCountry.countryPopulation = "5.2 Million";
            tmpCountry.countryCapital = "Glasgow";
            tmpCountry.countryImage = "EuropeanImages/Scotland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Serbia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Serbia";
            tmpCountry.countryCurrency = "Serbian Dinar";
            tmpCountry.countryPopulation = "7.1 Million";
            tmpCountry.countryCapital = "Belgrade";
            tmpCountry.countryImage = "EuropeanImages/Serbia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Slovakia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Slovakia";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "5.4 Million";
            tmpCountry.countryCapital = "Bratislava";
            tmpCountry.countryImage = "EuropeanImages/Slovakia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Slovenia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Slovenia";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Ljubljana";
            tmpCountry.countryImage = "EuropeanImages/Slovenia.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Spain
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Spain";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "46.9 Million";
            tmpCountry.countryCapital = "Madrid";
            tmpCountry.countryImage = "EuropeanImages/Spain.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Sweden
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Sweden";
            tmpCountry.countryCurrency = "Swedish Krona";
            tmpCountry.countryPopulation = "9.6 Million";
            tmpCountry.countryCapital = "Stockholm";
            tmpCountry.countryImage = "EuropeanImages/Sweden.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Switzerland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Switzerland";
            tmpCountry.countryCurrency = "Swiss Franc";
            tmpCountry.countryPopulation = "8.1 Million";
            tmpCountry.countryCapital = "Bern";
            tmpCountry.countryImage = "EuropeanImages/Switzerland.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Turkey
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Turkey";
            tmpCountry.countryCurrency = "Turkish New Lira";
            tmpCountry.countryPopulation = "76.6 Million";
            tmpCountry.countryCapital = "Ankara";
            tmpCountry.countryImage = "EuropeanImages/Turkey.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Ukraine
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Ukraine";
            tmpCountry.countryCurrency = "Ukrainian Hryvnia";
            tmpCountry.countryPopulation = "45.4 Million";
            tmpCountry.countryCapital = "Kiev";
            tmpCountry.countryImage = "EuropeanImages/Ukraine.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Vatican City
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Vatican City";
            tmpCountry.countryCurrency = "Euro";
            tmpCountry.countryPopulation = "839";
            tmpCountry.countryCapital = "Vatican City";
            tmpCountry.countryImage = "EuropeanImages/Vatican City.png";
            ListOfEuropeanCountries.Add(tmpCountry);

            // Wales
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Wales";
            tmpCountry.countryCurrency = "Pound";
            tmpCountry.countryPopulation = "3 Million";
            tmpCountry.countryCapital = "Cardiff";
            tmpCountry.countryImage = "EuropeanImages/Wales.png";
            ListOfEuropeanCountries.Add(tmpCountry);

        } //  End of fillTheEuropeanList() Function


        // fillTheAsianList() Function
        private void fillTheAsianList()
        {
            WorldCountriesClass tmpCountry;

            // Afghanistan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Afghanistan";
            tmpCountry.countryCurrency = "Afghan afghani";
            tmpCountry.countryPopulation = "25.5 Million";
            tmpCountry.countryCapital = "Kabul";
            tmpCountry.countryImage = "AsiaImages/Afghanistan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Armenia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Armenia";
            tmpCountry.countryCurrency = "Afghan afghani";
            tmpCountry.countryPopulation = "3 Million";
            tmpCountry.countryCapital = "Yerevan";
            tmpCountry.countryImage = "AsiaImages/Armenia.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Azerbaijan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Azerbaijan";
            tmpCountry.countryCurrency = "Azerbaijani manat";
            tmpCountry.countryPopulation = "9.4 Million";
            tmpCountry.countryCapital = "Baku";
            tmpCountry.countryImage = "AsiaImages/Azerbaijan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Bahrain
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bahrain";
            tmpCountry.countryCurrency = "Bahraini dinar";
            tmpCountry.countryPopulation = "1.2 Million";
            tmpCountry.countryCapital = "Manama";
            tmpCountry.countryImage = "AsiaImages/Bahrain.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Bangladesh
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bangladesh";
            tmpCountry.countryCurrency = "Bangladeshi taka";
            tmpCountry.countryPopulation = "152 Million";
            tmpCountry.countryCapital = "Dhaka";
            tmpCountry.countryImage = "AsiaImages/Bangladesh.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Bhutan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bhutan";
            tmpCountry.countryCurrency = "Bhutanese ngultrum";
            tmpCountry.countryPopulation = "745,200";
            tmpCountry.countryCapital = "Thimphu";
            tmpCountry.countryImage = "AsiaImages/Bhutan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Brunei
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Brunei";
            tmpCountry.countryCurrency = "Brunei Dollar";
            tmpCountry.countryPopulation = "393,100";
            tmpCountry.countryCapital = "Bandar Seri Begawan";
            tmpCountry.countryImage = "AsiaImages/Brunei.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Cambodia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cambodia";
            tmpCountry.countryCurrency = "Cambodian riel";
            tmpCountry.countryPopulation = "15.1 Million";
            tmpCountry.countryCapital = "Phnom Penh";
            tmpCountry.countryImage = "AsiaImages/Cambodia.png";
            ListOfAsianCountries.Add(tmpCountry);

            // East Timor
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "East Timor";
            tmpCountry.countryCurrency = "US Dollar";
            tmpCountry.countryPopulation = "1 Million";
            tmpCountry.countryCapital = "Dili";
            tmpCountry.countryImage = "AsiaImages/East Timor.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Egypt
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Egypt";
            tmpCountry.countryCurrency = "Egyptian Pound";
            tmpCountry.countryPopulation = "86 Million";
            tmpCountry.countryCapital = "Cairo";
            tmpCountry.countryImage = "AsiaImages/Egypt.png";
            ListOfAsianCountries.Add(tmpCountry);

            // India
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "India";
            tmpCountry.countryCurrency = "Indian Rupee";
            tmpCountry.countryPopulation = "1.2 Billion";
            tmpCountry.countryCapital = "New Delhi";
            tmpCountry.countryImage = "AsiaImages/India.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Indonesia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Indonesia";
            tmpCountry.countryCurrency = "Indonesian Rupiah";
            tmpCountry.countryPopulation = "249 Million";
            tmpCountry.countryCapital = "Jakarta";
            tmpCountry.countryImage = "AsiaImages/Indonesia.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Iran
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Iran";
            tmpCountry.countryCurrency = "Iranian Rila";
            tmpCountry.countryPopulation = "77.2 Million";
            tmpCountry.countryCapital = "Tehran";
            tmpCountry.countryImage = "AsiaImages/Iran.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Iraq
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Iraq";
            tmpCountry.countryCurrency = "Iraqi Dinar";
            tmpCountry.countryPopulation = "34 Million";
            tmpCountry.countryCapital = "Baghdad";
            tmpCountry.countryImage = "AsiaImages/Iraq.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Israel
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Israel";
            tmpCountry.countryCurrency = "Israeli Sheqel";
            tmpCountry.countryPopulation = "8.1 Million";
            tmpCountry.countryCapital = "Jerusalem";
            tmpCountry.countryImage = "AsiaImages/Israel.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Japan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Japan";
            tmpCountry.countryCurrency = "Japanese Yen";
            tmpCountry.countryPopulation = "127 Million";
            tmpCountry.countryCapital = "Tokyo";
            tmpCountry.countryImage = "AsiaImages/Japan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Jordan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Jordan";
            tmpCountry.countryCurrency = "Jordanian Dinar";
            tmpCountry.countryPopulation = "6.5 Million";
            tmpCountry.countryCapital = "Amman";
            tmpCountry.countryImage = "AsiaImages/Jordan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Kazakhstan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kazakhstan";
            tmpCountry.countryCurrency = "Kazakhstani tenge";
            tmpCountry.countryPopulation = "17.1 Million";
            tmpCountry.countryCapital = "Astana";
            tmpCountry.countryImage = "AsiaImages/Kazakhstan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Kuwait
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kuwait";
            tmpCountry.countryCurrency = "Kuwaiti Dinar";
            tmpCountry.countryPopulation = "3.0 Million";
            tmpCountry.countryCapital = "Kuwait City";
            tmpCountry.countryImage = "AsiaImages/Kuwait.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Kyrgyzstan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kyrgyzstan";
            tmpCountry.countryCurrency = "Kyrgyzstani som";
            tmpCountry.countryPopulation = "3.0 Million";
            tmpCountry.countryCapital = "Bishkek";
            tmpCountry.countryImage = "AsiaImages/Kyrgyzstan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Laos
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Laos";
            tmpCountry.countryCurrency = "Lao Kip";
            tmpCountry.countryPopulation = "6.5 Million";
            tmpCountry.countryCapital = "Vientiane";
            tmpCountry.countryImage = "AsiaImages/Laos.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Lebanon
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Lebanon";
            tmpCountry.countryCurrency = "Lebanese Pound";
            tmpCountry.countryPopulation = "4.8 Million";
            tmpCountry.countryCapital = "Beirut";
            tmpCountry.countryImage = "AsiaImages/Lebanon.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Malaysia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Malaysia";
            tmpCountry.countryCurrency = "Malaysian Ringgit";
            tmpCountry.countryPopulation = "30 Million";
            tmpCountry.countryCapital = "Kuala Lumpur";
            tmpCountry.countryImage = "AsiaImages/Malaysia.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Maldives
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Maldives";
            tmpCountry.countryCurrency = "Maldivian rufiyaa";
            tmpCountry.countryPopulation = "317,200";
            tmpCountry.countryCapital = "Malé";
            tmpCountry.countryImage = "AsiaImages/Maldives.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Mongolia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mongolia";
            tmpCountry.countryCurrency = "Mongolian tögrög";
            tmpCountry.countryPopulation = "2.9 Million";
            tmpCountry.countryCapital = "Ulaanbaatar";
            tmpCountry.countryImage = "AsiaImages/Mongolia.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Myanmar
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Myanmar";
            tmpCountry.countryCurrency = "Myanmar Kyat";
            tmpCountry.countryPopulation = "53.2 Million";
            tmpCountry.countryCapital = "Naypyidaw";
            tmpCountry.countryImage = "AsiaImages/Myanmar.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Nepal
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Nepal";
            tmpCountry.countryCurrency = "Nepalese rupee";
            tmpCountry.countryPopulation = "26.4 Million";
            tmpCountry.countryCapital = "Kathmandu";
            tmpCountry.countryImage = "AsiaImages/Nepal.png";
            ListOfAsianCountries.Add(tmpCountry);

            // North Korea
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "North Korea";
            tmpCountry.countryCurrency = "North Korean Won";
            tmpCountry.countryPopulation = "26.8 Million";
            tmpCountry.countryCapital = "Pyongyang";
            tmpCountry.countryImage = "AsiaImages/North Korea.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Oman
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Oman";
            tmpCountry.countryCurrency = "Omani Rial";
            tmpCountry.countryPopulation = "3.9 Million";
            tmpCountry.countryCapital = "Muscat";
            tmpCountry.countryImage = "AsiaImages/Oman.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Pakistan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Pakistan";
            tmpCountry.countryCurrency = "Pakistani Rupee";
            tmpCountry.countryPopulation = "185 Million";
            tmpCountry.countryCapital = "Islamabad";
            tmpCountry.countryImage = "AsiaImages/Pakistan.png";
            ListOfAsianCountries.Add(tmpCountry);

            // China
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "China";
            tmpCountry.countryCurrency = "Chinese Renminbi Yuan";
            tmpCountry.countryPopulation = "1.3 Billion";
            tmpCountry.countryCapital = "Beijing";
            tmpCountry.countryImage = "AsiaImages/China.png";
            ListOfAsianCountries.Add(tmpCountry);

            // The Philippines
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Philippines";
            tmpCountry.countryCurrency = "Philippine peso";
            tmpCountry.countryPopulation = "99.2 Million";
            tmpCountry.countryCapital = "Manila";
            tmpCountry.countryImage = "AsiaImages/The Philippines.png";
            ListOfAsianCountries.Add(tmpCountry);

            // Qatar
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Qatar";
            tmpCountry.countryCurrency = "Qatari riyal";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Doha";
            tmpCountry.countryImage = "AsiaImages/Qatar.png";
            ListOfAsianCountries.Add(tmpCountry);

        } // End of fillTheAsianList() function


        // fillTheAfricanList() Function
        private void fillTheAfricanList()
        {
            WorldCountriesClass tmpCountry;

            // Algeria
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Algeria";
            tmpCountry.countryCurrency = "Algerian Dinar";
            tmpCountry.countryPopulation = "38.7 Million";
            tmpCountry.countryCapital = "Algiers";
            tmpCountry.countryImage = "AfricanImages/Algeria.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Angola
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Angola";
            tmpCountry.countryCurrency = "Angolan Kwanza";
            tmpCountry.countryPopulation = "20.6 Million";
            tmpCountry.countryCapital = "Luanda";
            tmpCountry.countryImage = "AfricanImages/Angola.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Benin
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Benin";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "10.3 Million";
            tmpCountry.countryCapital = "Porto-Novo";
            tmpCountry.countryImage = "AfricanImages/Benin.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Botswana
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Botswana";
            tmpCountry.countryCurrency = "Botswana Pula";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Gaborone";
            tmpCountry.countryImage = "AfricanImages/Botswana.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Burkina Faso
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Burkina Faso";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "17.3 Million";
            tmpCountry.countryCapital = "Ouagadougou";
            tmpCountry.countryImage = "AfricanImages/Burkina Faso.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Burundi
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Burundi";
            tmpCountry.countryCurrency = "Burundian Franc";
            tmpCountry.countryPopulation = "10.1 Million";
            tmpCountry.countryCapital = "Bujumbura";
            tmpCountry.countryImage = "AfricanImages/Burundi.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Cameroon
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cameroon";
            tmpCountry.countryCurrency = "Central African cfa Franc";
            tmpCountry.countryPopulation = "20.3 Million";
            tmpCountry.countryCapital = "Yaoundé";
            tmpCountry.countryImage = "AfricanImages/Cameroon.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Cape Verde
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cape Verde";
            tmpCountry.countryCurrency = "Cape Verdean Escudo";
            tmpCountry.countryPopulation = "491,800";
            tmpCountry.countryCapital = "Praia";
            tmpCountry.countryImage = "AfricanImages/Cape Verde.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Chad
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Chad";
            tmpCountry.countryCurrency = "Central African cfa Franc";
            tmpCountry.countryPopulation = "12.8 Million";
            tmpCountry.countryCapital = "N'Djamena";
            tmpCountry.countryImage = "AfricanImages/Chad.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Cote d'Ivoire
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cote d'Ivoire";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "23.2 Million";
            tmpCountry.countryCapital = "Yamoussoukro";
            tmpCountry.countryImage = "AfricanImages/Cote d'Ivoire.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Djibouti
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Djibouti";
            tmpCountry.countryCurrency = "Djiboutian Franc";
            tmpCountry.countryPopulation = "873,000";
            tmpCountry.countryCapital = "Djibouti";
            tmpCountry.countryImage = "AfricanImages/Djibouti.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Egypt
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Egypt";
            tmpCountry.countryCurrency = "Egyptian Pound";
            tmpCountry.countryPopulation = "86.1 Million";
            tmpCountry.countryCapital = "Cairo";
            tmpCountry.countryImage = "AfricanImages/Egypt.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Equatorial Guinea
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Equatorial Guinea";
            tmpCountry.countryCurrency = "Central African cfa Franc";
            tmpCountry.countryPopulation = "736,000";
            tmpCountry.countryCapital = "Malabo";
            tmpCountry.countryImage = "AfricanImages/Equatorial Guinea.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Eritrea
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Eritrea";
            tmpCountry.countryCurrency = "Eritrean Nakfa";
            tmpCountry.countryPopulation = "6.3 Million";
            tmpCountry.countryCapital = "Asmara";
            tmpCountry.countryImage = "AfricanImages/Eritrea.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Ethiopia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Ethiopia";
            tmpCountry.countryCurrency = "Ethiopian Birr";
            tmpCountry.countryPopulation = "86.6 Million";
            tmpCountry.countryCapital = "Addis Ababa";
            tmpCountry.countryImage = "AfricanImages/Ethiopia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Gabon
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Gabon";
            tmpCountry.countryCurrency = "Central African cfa Franc";
            tmpCountry.countryPopulation = "1.6 Million";
            tmpCountry.countryCapital = "Libreville";
            tmpCountry.countryImage = "AfricanImages/Gabon.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Ghana
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Ghana";
            tmpCountry.countryCurrency = "Ghanaian Cedi";
            tmpCountry.countryPopulation = "24.6 Million";
            tmpCountry.countryCapital = "Accra";
            tmpCountry.countryImage = "AfricanImages/Ghana.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Guinea Bissau
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Guinea-Bissau";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "1.7 Million";
            tmpCountry.countryCapital = "Bissau";
            tmpCountry.countryImage = "AfricanImages/Guinea Bissau.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Guinea
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Guinea";
            tmpCountry.countryCurrency = "Guinean Franc";
            tmpCountry.countryPopulation = "10.8 Million";
            tmpCountry.countryCapital = "Conakry";
            tmpCountry.countryImage = "AfricanImages/Guinea.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Kenya
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kenya";
            tmpCountry.countryCurrency = "Kenyan Shilling";
            tmpCountry.countryPopulation = "44.3 Million";
            tmpCountry.countryCapital = "Nairobi";
            tmpCountry.countryImage = "AfricanImages/Kenya.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Lesotho
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Lesotho";
            tmpCountry.countryCurrency = "Lesotho Loti";
            tmpCountry.countryPopulation = "2 Million";
            tmpCountry.countryCapital = "Maseru";
            tmpCountry.countryImage = "AfricanImages/Lesotho.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Liberia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Liberia";
            tmpCountry.countryCurrency = "Liberian Dollar";
            tmpCountry.countryPopulation = "4.2 Million";
            tmpCountry.countryCapital = "Monrovia";
            tmpCountry.countryImage = "AfricanImages/Liberia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Libya
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Libya";
            tmpCountry.countryCurrency = "Libyan Dinar";
            tmpCountry.countryPopulation = "6.2 Million";
            tmpCountry.countryCapital = "Tripoli";
            tmpCountry.countryImage = "AfricanImages/Libya.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Madagascar
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Madagascar";
            tmpCountry.countryCurrency = "Malagasy Ariary";
            tmpCountry.countryPopulation = "21.2 Million";
            tmpCountry.countryCapital = "Antananarivo";
            tmpCountry.countryImage = "AfricanImages/Madagascar.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Malawi
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Malawi";
            tmpCountry.countryCurrency = "Malawian Kwacha";
            tmpCountry.countryPopulation = "16.3 Million";
            tmpCountry.countryCapital = "Lilongwe";
            tmpCountry.countryImage = "AfricanImages/Malawi.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Mali
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mali";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "15.3 Million";
            tmpCountry.countryCapital = "Bamako";
            tmpCountry.countryImage = "AfricanImages/Mali.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Mauritania
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mauritania";
            tmpCountry.countryCurrency = "Mauritanian Ouguiya";
            tmpCountry.countryPopulation = "3.4 Million";
            tmpCountry.countryCapital = "Nouakchott";
            tmpCountry.countryImage = "AfricanImages/Mauritania.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Mauritius
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mauritius";
            tmpCountry.countryCurrency = "Mauritian Rupee";
            tmpCountry.countryPopulation = "1.2 Million";
            tmpCountry.countryCapital = "Port Louis";
            tmpCountry.countryImage = "AfricanImages/Mauritius.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Morocco
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Morocco";
            tmpCountry.countryCurrency = "Moroccan Dirham";
            tmpCountry.countryPopulation = "33.2 Million";
            tmpCountry.countryCapital = "Rabat";
            tmpCountry.countryImage = "AfricanImages/Morocco.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Mozambique
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mozambique";
            tmpCountry.countryCurrency = "Mozambican Metical";
            tmpCountry.countryPopulation = "23.7 Million";
            tmpCountry.countryCapital = "Maputo";
            tmpCountry.countryImage = "AfricanImages/Mozambique.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Namibia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Namibia";
            tmpCountry.countryCurrency = "Namibian Dollar";
            tmpCountry.countryPopulation = "2.1 Million";
            tmpCountry.countryCapital = "Windhoek";
            tmpCountry.countryImage = "AfricanImages/Namibia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Niger
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Niger";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "17.1 Million";
            tmpCountry.countryCapital = "Niamey";
            tmpCountry.countryImage = "AfricanImages/Niger(Tweeked).png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Nigeria
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Nigeria";
            tmpCountry.countryCurrency = "Nigerian Naira";
            tmpCountry.countryPopulation = "173.6 Million";
            tmpCountry.countryCapital = "Abuja";
            tmpCountry.countryImage = "AfricanImages/Nigeria.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Rwanda
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Rwanda";
            tmpCountry.countryCurrency = "Rwandan Franc";
            tmpCountry.countryPopulation = "10.5 Million";
            tmpCountry.countryCapital = "Kigali";
            tmpCountry.countryImage = "AfricanImages/Rwanda.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Sao Tome and Principe
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Sao Tome and Principe";
            tmpCountry.countryCurrency = "Dobra";
            tmpCountry.countryPopulation = "187,000";
            tmpCountry.countryCapital = "São Tomé";
            tmpCountry.countryImage = "AfricanImages/Sao Tome and Principe.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Senegal
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Senegal";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "13.5 Million";
            tmpCountry.countryCapital = "Dakar";
            tmpCountry.countryImage = "AfricanImages/Senegal.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Sierre Leone
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Sierre Leone";
            tmpCountry.countryCurrency = "Sierra Leonean Leone";
            tmpCountry.countryPopulation = "6.1 Million";
            tmpCountry.countryCapital = "Freetown";
            tmpCountry.countryImage = "AfricanImages/Sierre Leone.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Somalia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Somalia";
            tmpCountry.countryCurrency = "Somali Shilling";
            tmpCountry.countryPopulation = "10.4 Million";
            tmpCountry.countryCapital = "Mogadishu";
            tmpCountry.countryImage = "AfricanImages/Somalia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // South Africa
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "South Africa";
            tmpCountry.countryCurrency = "South African Rand";
            tmpCountry.countryPopulation = "52.9 Million";
            tmpCountry.countryCapital = "Pretoria";
            tmpCountry.countryImage = "AfricanImages/South Africa.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Sudan
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Sudan";
            tmpCountry.countryCurrency = "Sudanese Pound";
            tmpCountry.countryPopulation = "37.9 Million";
            tmpCountry.countryCapital = "Khartoum";
            tmpCountry.countryImage = "AfricanImages/Sudan.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Swaziland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Swaziland";
            tmpCountry.countryCurrency = "Swazi Lilangeni";
            tmpCountry.countryPopulation = "1.2 Million";
            tmpCountry.countryCapital = "Mbabane";
            tmpCountry.countryImage = "AfricanImages/Swaziland.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Tanzania
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Tanzania";
            tmpCountry.countryCurrency = "Tanzanian Shilling";
            tmpCountry.countryPopulation = "44.9 Million";
            tmpCountry.countryCapital = "Dodoma";
            tmpCountry.countryImage = "AfricanImages/Tanzania.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Central African Republic
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Central African Republic";
            tmpCountry.countryCurrency = "Central African cfa Franc";
            tmpCountry.countryPopulation = "4.6 Million";
            tmpCountry.countryCapital = "Bangui";
            tmpCountry.countryImage = "AfricanImages/The Central African Republic.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // The Comoros
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Comoros";
            tmpCountry.countryCurrency = "Comoronian Franc";
            tmpCountry.countryPopulation = "743,000";
            tmpCountry.countryCapital = "Moroni";
            tmpCountry.countryImage = "AfricanImages/The Comoros.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Democratic Republic of the Congo
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Dem.Rep of the Congo";
            tmpCountry.countryCurrency = "Congolese Franc";
            tmpCountry.countryPopulation = "67.5 Million";
            tmpCountry.countryCapital = "Kinshasa";
            tmpCountry.countryImage = "AfricanImages/The Democratic Republic of the Congo.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // The Gambia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Gambia";
            tmpCountry.countryCurrency = "Gambian Dalasi";
            tmpCountry.countryPopulation = "1.8 Million";
            tmpCountry.countryCapital = "Banjul";
            tmpCountry.countryImage = "AfricanImages/The Gambia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Republic of the Congo
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Republic of the Congo";
            tmpCountry.countryCurrency = "Congolese Franc";
            tmpCountry.countryPopulation = "4.4 Million";
            tmpCountry.countryCapital = "Brazzaville";
            tmpCountry.countryImage = "AfricanImages/The Republic of the Congo.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // The Seychelles
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Seychelles";
            tmpCountry.countryCurrency = "Congolese Franc";
            tmpCountry.countryPopulation = "90,940";
            tmpCountry.countryCapital = "Victoria";
            tmpCountry.countryImage = "AfricanImages/The Seychelles.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Togo
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Togo";
            tmpCountry.countryCurrency = "West African cfa Franc";
            tmpCountry.countryPopulation = "6.1 Million";
            tmpCountry.countryCapital = "Lomé";
            tmpCountry.countryImage = "AfricanImages/Togo.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Tunisia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Tunisia";
            tmpCountry.countryCurrency = "Tunisian Dinar";
            tmpCountry.countryPopulation = "10.8 Million";
            tmpCountry.countryCapital = "Tunis";
            tmpCountry.countryImage = "AfricanImages/Tunisia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Uganda
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Uganda";
            tmpCountry.countryCurrency = "Ugandan Shilling";
            tmpCountry.countryPopulation = "35.3 Million";
            tmpCountry.countryCapital = "Kampala";
            tmpCountry.countryImage = "AfricanImages/Uganda.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Western Sahara
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Western Sahara";
            tmpCountry.countryCurrency = "Moroccan Dirham";
            tmpCountry.countryPopulation = "567,000";
            tmpCountry.countryCapital = "Laayoune";
            tmpCountry.countryImage = "AfricanImages/Western Sahara.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Zambia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Zambia";
            tmpCountry.countryCurrency = "Ugandan Shilling";
            tmpCountry.countryPopulation = "567,000";
            tmpCountry.countryCapital = "Lusaka";
            tmpCountry.countryImage = "AfricanImages/Zambia.png";
            ListOfAfricanCountries.Add(tmpCountry);

            // Zimbabwe
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Zimbabwe";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "12.9 Million";
            tmpCountry.countryCapital = "Harare";
            tmpCountry.countryImage = "AfricanImages/Zimbabwe.png";
            ListOfAfricanCountries.Add(tmpCountry); 

        } // End of fillTheAfricanList() Function


        // fillTheNorthAmericanList() Function
        private void fillTheNorthAmericanList()
        {
            WorldCountriesClass tmpCountry;

            // Antigua and Barbuda
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Antigua and Barbuda";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "86,290";
            tmpCountry.countryCapital = "St.Johns";
            tmpCountry.countryImage = "NorthAmericanImages/Antigua and Barbuda.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Barbados
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Barbados";
            tmpCountry.countryCurrency = "Barbadian Dollar";
            tmpCountry.countryPopulation = "285,500";
            tmpCountry.countryCapital = "Bridgetown";
            tmpCountry.countryImage = "NorthAmericanImages/Barbados.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Belize
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Belize";
            tmpCountry.countryCurrency = "Belize Dollar";
            tmpCountry.countryPopulation = "349,700";
            tmpCountry.countryCapital = "Belmopan";
            tmpCountry.countryImage = "NorthAmericanImages/Belize.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Canada
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Canada";
            tmpCountry.countryCurrency = "Canadian Dollar";
            tmpCountry.countryPopulation = "35.2 Million";
            tmpCountry.countryCapital = "Ottawa";
            tmpCountry.countryImage = "NorthAmericanImages/Canada.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Costa Rica
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Costa Rica";
            tmpCountry.countryCurrency = "Costa Rican Colón";
            tmpCountry.countryPopulation = "4.6 Million";
            tmpCountry.countryCapital = "San José";
            tmpCountry.countryImage = "NorthAmericanImages/Costa Rica.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Cuba
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Cuba";
            tmpCountry.countryCurrency = "Cuban Convertible Peso";
            tmpCountry.countryPopulation = "11.1 Million";
            tmpCountry.countryCapital = "Havana";
            tmpCountry.countryImage = "NorthAmericanImages/Cuba.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Dominica
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Dominica";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "71,300";
            tmpCountry.countryCapital = "Roseau";
            tmpCountry.countryImage = "NorthAmericanImages/Dominica.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // El Salvador
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "El Salvador";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "6.3 Million";
            tmpCountry.countryCapital = "San Salvador";
            tmpCountry.countryImage = "NorthAmericanImages/El Salvador.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Greenland
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Greenland";
            tmpCountry.countryCurrency = "Danish Krone";
            tmpCountry.countryPopulation = "56,960";
            tmpCountry.countryCapital = "Nuuk";
            tmpCountry.countryImage = "NorthAmericanImages/Greenland.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Grenada
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Grenada";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "103,300";
            tmpCountry.countryCapital = "St. George's";
            tmpCountry.countryImage = "NorthAmericanImages/Grenada.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Guatemala
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Guatemala";
            tmpCountry.countryCurrency = "Guatemalan Quetzal";
            tmpCountry.countryPopulation = "15.8 Million";
            tmpCountry.countryCapital = "Guatemala City";
            tmpCountry.countryImage = "NorthAmericanImages/Guatemala.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Honduras
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Honduras";
            tmpCountry.countryCurrency = "Honduran Lempira";
            tmpCountry.countryPopulation = "8.5 Million";
            tmpCountry.countryCapital = "Tegucigalpa";
            tmpCountry.countryImage = "NorthAmericanImages/Honduras.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Jamaica
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Jamaica";
            tmpCountry.countryCurrency = "Jamaican Dollar";
            tmpCountry.countryPopulation = "2.7 Million";
            tmpCountry.countryCapital = "Kingston";
            tmpCountry.countryImage = "NorthAmericanImages/Jamaica.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Mexico
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Mexico";
            tmpCountry.countryCurrency = "Mexican Peso";
            tmpCountry.countryPopulation = "119.7 Million";
            tmpCountry.countryCapital = "Mexico City";
            tmpCountry.countryImage = "NorthAmericanImages/Mexico.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Nicaragua
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Nicaragua";
            tmpCountry.countryCurrency = "Nicaraguan Córdoba";
            tmpCountry.countryPopulation = "6 Million";
            tmpCountry.countryCapital = "Managua";
            tmpCountry.countryImage = "NorthAmericanImages/Nicaragua.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Saint Kitts and Nevis
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Saint Kitts and Nevis";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "54,000";
            tmpCountry.countryCapital = "Basseterre";
            tmpCountry.countryImage = "NorthAmericanImages/Saint Kitts and Nevis.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Saint Lucia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Saint Lucia";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "180,000";
            tmpCountry.countryCapital = "Castries";
            tmpCountry.countryImage = "NorthAmericanImages/Saint Lucia.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Saint Vincent and the Grenadines
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "St.Vin and Grenadines";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "180,000";
            tmpCountry.countryCapital = "Kingstown";
            tmpCountry.countryImage = "NorthAmericanImages/Saint Vincent and the Grenadines.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // The Bahamas
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Bahamas";
            tmpCountry.countryCurrency = "Bahamian Dollar";
            tmpCountry.countryPopulation = "351,460";
            tmpCountry.countryCapital = "Nassau";
            tmpCountry.countryImage = "NorthAmericanImages/The Bahamas.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // The Dominican Republic
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Dominican Republic";
            tmpCountry.countryCurrency = "Dominican Peso";
            tmpCountry.countryPopulation = "9.4 Million";
            tmpCountry.countryCapital = "Santo Domingo";
            tmpCountry.countryImage = "NorthAmericanImages/The Dominican Republic.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // Trinidad and Tobago
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Trinidad and Tobago";
            tmpCountry.countryCurrency = "T & T Dollar";
            tmpCountry.countryPopulation = "1.3 Million";
            tmpCountry.countryCapital = "Port Of Spain";
            tmpCountry.countryImage = "NorthAmericanImages/Trinidad and Tobago.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

            // USA
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "USA";
            tmpCountry.countryCurrency = "U.S Dollar";
            tmpCountry.countryPopulation = "317.7 Million";
            tmpCountry.countryCapital = "Washington DC";
            tmpCountry.countryImage = "NorthAmericanImages/USA.png";
            ListOfNorthAmericanCountries.Add(tmpCountry);

        } // End of fillTheNorthAmericanList() function


        // fillTheSouthAmericanList() Function
        private void fillTheSouthAmericanList()
        {
            WorldCountriesClass tmpCountry;

            // Argentina
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Argentina";
            tmpCountry.countryCurrency = "East Caribbean Dollar";
            tmpCountry.countryPopulation = "2.7 Million";
            tmpCountry.countryCapital = "Buenos Aires";
            tmpCountry.countryImage = "SouthAmericanImages/Argentina.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Bolivia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Bolivia";
            tmpCountry.countryCurrency = "Bolivian Boliviano";
            tmpCountry.countryPopulation = "10 Million";
            tmpCountry.countryCapital = "Sucre";
            tmpCountry.countryImage = "SouthAmericanImages/Bolivia.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Brazil
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Brazil";
            tmpCountry.countryCurrency = "Brazilian Real";
            tmpCountry.countryPopulation = "201 Million";
            tmpCountry.countryCapital = "Brasília";
            tmpCountry.countryImage = "SouthAmericanImages/Brazil.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Chile
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Chile";
            tmpCountry.countryCurrency = "Chilean Peso";
            tmpCountry.countryPopulation = "16.3 Million";
            tmpCountry.countryCapital = "Santiago";
            tmpCountry.countryImage = "SouthAmericanImages/Chile.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Colombia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Colombia";
            tmpCountry.countryCurrency = "Colombian Peso";
            tmpCountry.countryPopulation = "47.5 Million";
            tmpCountry.countryCapital = "Bogotá";
            tmpCountry.countryImage = "SouthAmericanImages/Colombia.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Ecuador
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Ecuador";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "15.6 Million";
            tmpCountry.countryCapital = "Quito";
            tmpCountry.countryImage = "SouthAmericanImages/Ecuador.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Guyana
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Guyana";
            tmpCountry.countryCurrency = "Guyanese Dollar";
            tmpCountry.countryPopulation = "784,900";
            tmpCountry.countryCapital = "Georgetown";
            tmpCountry.countryImage = "SouthAmericanImages/Guyana.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Paraguay
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Paraguay";
            tmpCountry.countryCurrency = "Paraguayan Guaraní";
            tmpCountry.countryPopulation = "6.7 Million";
            tmpCountry.countryCapital = "Asunción";
            tmpCountry.countryImage = "SouthAmericanImages/Paraguay.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Peru
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Peru";
            tmpCountry.countryCurrency = "Peruvian Nuevo Sol";
            tmpCountry.countryPopulation = "30.4 Million";
            tmpCountry.countryCapital = "Lima";
            tmpCountry.countryImage = "SouthAmericanImages/Peru.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Suriname
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Suriname";
            tmpCountry.countryCurrency = "Surinamese Dollar ";
            tmpCountry.countryPopulation = "534,200";
            tmpCountry.countryCapital = "Paramaribo";
            tmpCountry.countryImage = "SouthAmericanImages/Suriname.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Trinidad and Tobago
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Trinidad and Tobago";
            tmpCountry.countryCurrency = "T & T Dollar";
            tmpCountry.countryPopulation = "1.3 Million";
            tmpCountry.countryCapital = "Port Of Spain";
            tmpCountry.countryImage = "SouthAmericanImages/Trinidad and Tobago.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Uruguay
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Uruguay";
            tmpCountry.countryCurrency = "Uruguayan Peso";
            tmpCountry.countryPopulation = "3.2 Million";
            tmpCountry.countryCapital = "Montevideo";
            tmpCountry.countryImage = "SouthAmericanImages/Uruguay.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

            // Venezuela
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Venezuela";
            tmpCountry.countryCurrency = "Venezuelan Bolívar";
            tmpCountry.countryPopulation = "28.9 Million";
            tmpCountry.countryCapital = "Caracas";
            tmpCountry.countryImage = "SouthAmericanImages/Venezuela.png";
            ListOfSouthAmericanCountries.Add(tmpCountry);

        } // End of fillTheSouthAmericanList() function


        // fillTheOceaniaList() Function
        private void fillTheOceaniaList()
        {
            WorldCountriesClass tmpCountry;

            // Australia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Australia";
            tmpCountry.countryCurrency = "Australian Dollar";
            tmpCountry.countryPopulation = "23.4 Million";
            tmpCountry.countryCapital = "Canberra";
            tmpCountry.countryImage = "OceaniaImages/Australia.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // East Timor
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "East Timor";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "1 Million";
            tmpCountry.countryCapital = "Dili";
            tmpCountry.countryImage = "OceaniaImages/East Timor.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Fiji
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Fiji";
            tmpCountry.countryCurrency = "Fijian Dollar";
            tmpCountry.countryPopulation = "858,000";
            tmpCountry.countryCapital = "Suva";
            tmpCountry.countryImage = "OceaniaImages/Fiji.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Indonesia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Indonesia";
            tmpCountry.countryCurrency = "Indonesian Rupiah";
            tmpCountry.countryPopulation = "249 Million";
            tmpCountry.countryCapital = "Jakarta";
            tmpCountry.countryImage = "OceaniaImages/Indonesia.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Kiribati
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Kiribati";
            tmpCountry.countryCurrency = "Australian Dollar";
            tmpCountry.countryPopulation = "106,400";
            tmpCountry.countryCapital = "South Tarawa";
            tmpCountry.countryImage = "OceaniaImages/Kiribati.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Micronesia
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Micronesia";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "101,350";
            tmpCountry.countryCapital = "Palikir";
            tmpCountry.countryImage = "OceaniaImages/Micronesia.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Nauru
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Nauru";
            tmpCountry.countryCurrency = "Australian Dollar";
            tmpCountry.countryPopulation = "9,945";
            tmpCountry.countryCapital = "Yaren District";
            tmpCountry.countryImage = "OceaniaImages/Nauru.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // New Zealand
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "New Zealand";
            tmpCountry.countryCurrency = "New Zealand Dollar";
            tmpCountry.countryPopulation = "4.5 Million";
            tmpCountry.countryCapital = "Wellington";
            tmpCountry.countryImage = "OceaniaImages/New Zealand.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Palau
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Palau";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "20,900";
            tmpCountry.countryCapital = "Ngerulmud";
            tmpCountry.countryImage = "OceaniaImages/Palau.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Papau New Guinea
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Papau New Guinea";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "7.3 Million";
            tmpCountry.countryCapital = "Port Moresby";
            tmpCountry.countryImage = "OceaniaImages/Papau New Guinea.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Samoa
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Samoa";
            tmpCountry.countryCurrency = "Samoan Tala";
            tmpCountry.countryPopulation = "187,800";
            tmpCountry.countryCapital = "Apia";
            tmpCountry.countryImage = "OceaniaImages/Samoa.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Marshall Islands
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Marshall Islands";
            tmpCountry.countryCurrency = "U.S. Dollar";
            tmpCountry.countryPopulation = "56,080";
            tmpCountry.countryCapital = "Majuro";
            tmpCountry.countryImage = "OceaniaImages/The Marshall Islands.png";
            ListOfOceaniaCountries.Add(tmpCountry);
            
            // The Solomon Islands
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "The Solomon Islands";
            tmpCountry.countryCurrency = "Solomon Islands Dollar";
            tmpCountry.countryPopulation = "581,340";
            tmpCountry.countryCapital = "Honiara";
            tmpCountry.countryImage = "OceaniaImages/The Solomon Islands.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Tonga
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Tonga";
            tmpCountry.countryCurrency = "Tongan Pa'anga";
            tmpCountry.countryPopulation = "103,000";
            tmpCountry.countryCapital = "Nuku'alofa";
            tmpCountry.countryImage = "OceaniaImages/Tonga.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Tuvalu
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Tuvalu";
            tmpCountry.countryCurrency = "Australian Dollar";
            tmpCountry.countryPopulation = "11,300";
            tmpCountry.countryCapital = "Funafuti";
            tmpCountry.countryImage = "OceaniaImages/Tuvalu.png";
            ListOfOceaniaCountries.Add(tmpCountry);

            // Vanuatu
            tmpCountry = new WorldCountriesClass();
            tmpCountry.countryName = "Vanuatu";
            tmpCountry.countryCurrency = "Vanuatu Vatu";
            tmpCountry.countryPopulation = "264,652";
            tmpCountry.countryCapital = "Port Vila";
            tmpCountry.countryImage = "OceaniaImages/Vanuatu.png";
            ListOfOceaniaCountries.Add(tmpCountry);

        } // End of fillTheOceaniaList() function


    } // End of public partial class PivotPage1

} // End of namespace flagInformationApp