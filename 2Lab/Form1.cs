using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _2Lab
{
    public partial class Form1 : Form
    {

        const string CFd1 = "Data1.txt"; //Trolleybus data file
        const string CFd2 = "Data2.txt"; //Bus data file
        const string CFd3 = "Data3.txt"; //Additional data file
        const string CFr = "Results.txt"; //Result file
        const string CFr2 = "Results.csv"; //CSV file
        const string CFu = "Task.txt"; //Task file
        const string CFg = "UserGuide.txt"; //User guide file

        private List<Transport> Trolleybus; //Trolleybus route list
        private List<Transport> Buses; // Bus route list
        private List<Transport> Additional; //Additional route list
        private List<Transport> Combined; //Combined route list

        string company1, company2, company3; //Transport company names

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(CFr)) //deletes previous data from results.txt file
                File.Delete(CFr);
            if (File.Exists(CFr2)) //deletes previous data from results.csv file
                File.Delete(CFr2);

            FindToolStripMenuItem.Enabled = false;
            CombinesListToolStripMenuItem.Enabled = false;
            ArrangeToolStripMenuItem.Enabled = false;
            RemoveToolStripMenuItem.Enabled = false;
            AddToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Menu strip item adds data to Trolleybus list from data file and prints 
        /// results to a results files and displays it on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TroleysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Pasirinkite rezultatu faila";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fv = openFileDialog1.FileName;
                Trolleybus = ReadTransportCont(fv, out company1);
                PrintTransportCont(CFr, Trolleybus, "Troleibusu marsrutai", company1);
                results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
                Message.Text = "Atlikti veiksmai: " + "įvesta troleibusų maršrutų " +
                               "duomenys.";
                BusesToolStripMenuItem.Enabled = true;
                TroleysToolStripMenuItem.Enabled = false;

            }
        }

        /// <summary>
        /// Menu strip item adds data to Buses list from data file and prints 
        /// results to a results files and displays it on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Pasirinkite rezultatu faila";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fv = openFileDialog1.FileName;
                Buses = ReadTransportCont(fv, out company2);
                PrintTransportCont(CFr, Buses, "Autobusu marsrutai", company2);
                results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
                Message.Text = "Atlikti veiksmai: " + "įvesta autobusų maršrutų duomenys";
                FindToolStripMenuItem.Enabled = true;
                BusesToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Menu strip item adds data to Additional list from data file and prints 
        /// results to a results files and displays it on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Pasirinkite duomenų failą";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fv = openFileDialog1.FileName;
                Additional = ReadTransportCont(fv, out company3);
                PrintTransportCont(CFr, Additional, "Papildomi transporto marsrutai",
                                   company3);
                results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
                Message.Text = "Atlikti veiksmai: " + "įvesta papildomų maršrutų duomenys";
            }
        }

        /// <summary>
        /// Menu strip item finds distance length in Trolleybus and Busses lists and 
        /// displays it through a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sum1 = CombinedRouteDistance(Trolleybus);
            int sum2 = CombinedRouteDistance(Buses);

            Length.Text = "Autobusu kelio ilgis " + sum1 + " km, \no Troleibusu - " +
                sum2 + "km";

            SpecialPrinting(CFr, "Troleibusu", sum1);
            SpecialPrinting(CFr, "Autubusu", sum2);

            Message.Text = "Atlikti veiksmai: " + "surasti transporto priemonių bendri" +
                           " atstumai";

            CombinesListToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Menu strip item that combines Trolleybus and Busses lists if they fit 
        /// into the interval [a:b]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombinesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intervalStart = Convert.ToInt32(intervalA.Text);
            int intervalEnd = Convert.ToInt32(intervalB.Text);

            Combined = new List<Transport>();

            Interval(Trolleybus, Combined, intervalStart, intervalEnd);
            Interval(Buses, Combined, intervalStart, intervalEnd);

            PrintTransportCont(CFr, Combined, " ", "Bendras transporto " +
                               "marsrutu sarasas intervale " + "[" +
                               intervalStart.ToString() + ";" + intervalEnd.ToString()
                               + "]");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Message.Text = "Atlikti veiksmai: " + "pagal įvestą atstumo intervalą " +
                           "sudarytas bendras transporto maršrutų sąrašas";
            ArrangeToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Menu strip item removes routes which include a word given by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wordy = word.Text;
            ThrowingOut(Combined, wordy);
            PrintTransportCont(CFr, Combined, "Bendras transporto sarasas su ismestu" +
                               " marsrutu/ais, kuriame yra zodis: " + wordy, " ");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            PrintCSV(CFr2, Combined);
            Message.Text = "Atlikti veiksmai: " + "pašalinti maršrutai su nurodytu " +
                           "žodžiu ir sukurtas CSV failas";
            AddToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Menu strip item adds data from the Additional list to the combined list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combined = AddtionalPrint(Combined, Additional);
            PrintTransportCont(CFr, Combined, "Naujais marsrutais papildytas " +
                               "transporto masrutu sarasas", "");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Message.Text = "Atlikti veiksmai: " + "prideti papildomi maršrutai į bendrą" +
                           " surikiuotą transporto maršrutų sąrašą";
            RemoveToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Menu strip item that opens a message box which includes the task text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader tekstas = new StreamReader(CFu, Encoding.GetEncoding(1257));
            Message.Text = "Atlikti veiksmai: " + "atidaryta užduotis";
            MessageBox.Show(tekstas.ReadToEnd(), "Užduotis U2-14. Viešasis transportas.");
            tekstas.Close();
        }

        /// <summary>
        /// Menu strip item that rearranges the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combined = Rearrange(Combined);
            PrintTransportCont(CFr, Combined, "Bendras surikiuotas transporto marsrutu"
                               + " sarasas", "");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Message.Text = "Atlikti veiksmai: " + "surikiuotas bendras maršrutų sąrašas";
            AddToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Closing button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Menu strip item that opens a message box which includes the user guide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader text = new StreamReader(CFg, Encoding.GetEncoding(1257));
            Message.Text = "Atlikti veiksmai: " + "atidarytas naudojimosi vadovas";
            MessageBox.Show(text.ReadToEnd(), "Naudojimosi vadovas");
            text.Close();
        }

        /// <summary>
        /// Menu strip item that opens a message box which includes information about the 
        /// author and program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programos versija: 1.001\n" +
            "Programa sukurta: 2023 Kovas\n" +
            "Programos autorė: Evelina Sakalauskaitė",
            "Informacija apie programą");

        }

        //------------------Methods------------------//

        /// <summary>
        /// Method that reads data files
        /// </summary>
        /// <param name="fv">Data file</param>
        /// <param name="company">transport company name</param>
        /// <returns></returns>
        static List<Transport> ReadTransportCont(string fv, out string company)
        {

            List<Transport> TransportCont = new List<Transport>();
            using (StreamReader srautas = new StreamReader(fv, Encoding.GetEncoding(1257)))
            {
                string line;
                line = srautas.ReadLine();
                company = line;

                while ((line = srautas.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    int number = int.Parse(parts[0]);
                    string route = parts[1];
                    int distance = int.Parse(parts[2]);
                    int stops = int.Parse(parts[3]);
                    Transport transport = new Transport(number, route, distance, stops);
                    TransportCont.Add(transport);
                }
            }
            return TransportCont;
        }

        /// <summary>
        /// Method that prints data about transport routes
        /// </summary>
        /// <param name="fv">Data file</param>
        /// <param name="TransportCont">Data container</param>
        /// <param name="caption">caption</param>
        /// <param name="company">transport company namee</param>
        /// <param name="fm"></param>
        static void PrintTransportCont(string fv, List<Transport> TransportCont,
                                         string caption, string company,
                                         FileMode fm = FileMode.Append)
        {

            const string top =
            "-------------------------------------------------------------\r\n"
            + "Nr.              Marsrutas                Atstumas  Stoteles \r\n"
            + "-------------------------------------------------------------";

            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append),
            Encoding.GetEncoding(1257)))
            {
                if (TransportCont.Count == 0)
                {
                    fr.WriteLine(company);
                    fr.WriteLine("\n " + caption);
                    fr.WriteLine("Nera tokiu marsrutu, kurie atitiktu nurodyta intervala");
                }
                else
                {
                    fr.WriteLine(company);
                    fr.WriteLine("\n " + caption);
                    fr.WriteLine(top);
                    for (int i = 0; i < TransportCont.Count; i++)
                    {

                        fr.WriteLine("{0}", TransportCont[i].ToString());

                    }
                    fr.WriteLine("---------------------------------------------------" +
                                 "----------\n");
                }
            }
        }

        /// <summary>
        /// Special printing method for route distances
        /// </summary>
        /// <param name="fv">Data file</param>
        /// <param name="caption">Caption</param>
        /// <param name="distance">Route distance</param>
        static void SpecialPrinting(string fv, string caption, int distance)
        {
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append),
                   Encoding.GetEncoding(1257)))
            {
                fr.WriteLine("{0,-10} bendras marsrutu ilgis: {1,5}  km", caption,
                             distance);
                fr.WriteLine("\n ");
            }
        }

        /// <summary>
        /// Method that counts a containers combined route distance
        /// </summary>
        /// <param name="TransportContainer">Data container</param>
        /// <param name="sum">Distance sum</param>
        static int CombinedRouteDistance(List<Transport> TransportContainer)
        {
            int sum = 0;
            for (int i = 0; i < TransportContainer.Count; i++)
            {
                Transport temp = TransportContainer[i];
                sum += temp.Distance;
            }
            return sum;
        }

        /// <summary>
        /// Method combines data that fits into the given interval
        /// </summary>
        /// <param name="TransportContainer">Data container</param>
        /// <param name="New">New data container by the given interval</param>
        /// <param name="lengthA">Start of interval</param>
        /// <param name="lengthB">End of interval</param>
        static void Interval(List<Transport> TransportContainer, List<Transport> New,
                             int lengthA, int lengthB)
        {
            for (int i = 0; i < TransportContainer.Count; i++)
            {
                Transport temp = TransportContainer[i];
                if (lengthA <= temp.Distance && lengthB >= temp.Distance)
                    New.Add(TransportContainer[i]);
            }
        }

        /// <summary>
        /// Method that rearranges data by required parameters
        /// </summary>
        /// <param name="TransportContainer">Data container</param>
        /// <returns>Rearranged data container</returns>
        private List<Transport> Rearrange(List<Transport> TransportContainer)
        {
            int i = 0;
            bool bk = true;
            while (bk)
            {
                bk = false;
                for (int j = TransportContainer.Count - 1; j > i; j--)
                    if (TransportContainer[j] > TransportContainer[j - 1])
                    {
                        bk = true;
                        Transport transport = TransportContainer[j];
                        TransportContainer[j] = TransportContainer[j - 1];
                        TransportContainer[j - 1] = transport;
                    }
                i++;
            }
            return TransportContainer;
        }

        /// <summary>
        /// Method that removes routes with given word
        /// </summary>
        /// <param name="TransportContainer">Data container</param>
        /// <param name="word">Given word</param>
        static void ThrowingOut(List<Transport> TransportContainer, string word)
        {
            for (int i = 0; i < TransportContainer.Count; i++)
            {
                if (TransportContainer[i].Route.Contains(word))
                {
                    TransportContainer.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Method that adds a line of data
        /// </summary>
        /// <param name="New">Combined list</param>
        /// <param name="Trans">Additional list for insertion</param>
        /// <returns></returns>
        static List<Transport> Addition(List<Transport> New, Transport Trans)
        {
            for (int i = 0; i < New.Count; i++)
            {
                if (New[i].Stops <= Trans.Stops)
                {
                    New.Insert(i, Trans);
                    break;
                }
            }
            return New;
        }

        private void intervalA_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Additional list printing method
        /// </summary>
        /// <param name="New">combined list</param>
        /// <param name="Transp">Additional list for insertion</param>
        /// <returns></returns>
        static List<Transport> AddtionalPrint(List<Transport> New, List<Transport> Transp)
        {

            for (int i = 0; i < Transp.Count; i++)
            {
                New = Addition(New, Transp[i]);
            }
            return New;
        }

        /// <summary>
        /// Printing method for csv file
        /// </summary>
        /// <param name="fv">Result file</param>
        /// <param name="Transp">List</param>
        static void PrintCSV(string fv, List<Transport> Transp)
        {
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append),
                   Encoding.GetEncoding(1257)))
            {
                fr.WriteLine("Nr.;Marsrutas;Kelio ilgis;Stot sk.");
                if (Transp.Count != 0)
                {
                    for (int i = 0; i < Transp.Count; i++)
                    {
                        Transport transp = Transp[i];
                        fr.WriteLine("{0};{1};{2};{3}", transp.Number, transp.Route,
                                     transp.Distance, transp.Stops);
                    }
                    fr.WriteLine();
                }
            }
        }
    }
}
