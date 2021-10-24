using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;


namespace WpfApp1
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string geschlecht;
        string maßnahme;
        string prognose;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (rb_Herr.IsChecked == true)
            {
                geschlecht = "Herr ";
            }
            else if(rb_Frau.IsChecked == true)
            {
                geschlecht = "Frau ";
            }
            

            if (rb_FZ.IsChecked == true)
            {
                maßnahme = "Maßnahme 00";

            }
            else if (rb_AC.IsChecked == true)
            {
                maßnahme = "Maßnahme 01";
            }
            else if (rb_F.IsChecked == true)
            {
                maßnahme = "Maßnahme 02";
            }
            else if (rb_OA.IsChecked == true)
            {
                maßnahme = "Maßnahme 03";
            }
            else if (rb_JSD.IsChecked == true)
            {
                maßnahme = "Maßnahme 04";
            }
            else if (rb_TZ.IsChecked == true)
            {
                maßnahme = "Maßnahme 05";
            }
            else if (rb_Pro12.IsChecked == true)
            {
                prognose = "12";
            }
            else if (rb_Pro24.IsChecked == true)
            {
                prognose = "24";
            }
               
            txtBox_Ausgabe.Text = "Kontaktdaten mit " + geschlecht + txtBox_nachname.Text + " abgeglichen, keine Änderung, die Vermittlungshemmnisse bestehen weiterhin. \r \r" +
                "Aktivitäten seit dem letzten Termin besprochen. " + geschlecht + txtBox_nachname.Text + " teilt mit, dass [IN VERBIS VON HAND ERGÄNZEN]. \r \r" +
                "Zum Abbau der vorgenannten Defizite/Vermittlungshemmnisse wurde " + geschlecht + txtBox_nachname.Text + " der Maßnahme" + maßnahme + "vom " + dp_Beginn.Text + " bis " + dp_Ende.Text + 
                " gem. §16 Abs. 1 SGB II i.V.m. §45 SGB III zugewiesen und entsprechende Teilnahme vereinbart. Unterlagen zugesandt. \r \rDie gesetzlichen individuellen Fördervoraussetzungen der Maßnahme wurden geprüft und sind erfüllt. " +
                "Die Teilnahme ist geeignet und passgenau, um die im Profiling festgestellten vermittlungsrelevanten" +
                "Handlungsbedarfe zu beseitigen bzw. zu verringern. Es ist kein Grund erkennbar, der dem Erfolg des ausgewählten Förderinstrumentes entgegensteht. Es ist davon auszugehen, dass durch die Teilnahme " +
                "eine positive Integrationswirkung erzielt wird und sich die Eingliederungschancen erhöhen. Auch aus wirtschaftlichen Gründen handelt es ich hierbei um das wirtschaftlichste Instrument. \r \r" +
                "Neue Eingliederungsvereinbarung abgeschlossen. Cosach-Buchung ist erfolgt. Eintrag in Vormerkliste sowie Einschaltung Dritter vorgenommen. \r \rPrognose: Integration in den Arbeitsmarkt binnen " + 
                prognose + " Monaten möglich. \r \rNächster Schritt Teilnahme an der Maßnahme bei einem Träger.";

        }

    }

}
