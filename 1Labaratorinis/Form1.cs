using _1Labaratorinis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Labaratorinis
{

    public partial class Form1 : Form
    {
        const string CFd1 = "Data1.txt";
        const string CFd2 = "Data2.txt";
        const string CFr = "Results.txt";
        const string CFG = "UserGuide.txt";

        private List<Transport> Trolleybus;
        private List<Transport> Busses;
        private List<Transport> Combined;

        string company1, company2;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(CFr))
                File.Delete(CFr);
            FindDistance.Enabled = false;
            Combine.Enabled = false;
            Arrange.Enabled = false;
            Removal.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action of the "Input" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_Click(object sender, EventArgs e)
        {
            Trolleybus = ReadTransportContainer(CFd1, out company1);
            PrintingTransportCont(CFr, Trolleybus, "Trolleybus routes", company1);
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Busses = ReadTransportContainer(CFd2, out company2);
            PrintingTransportCont(CFr, Busses, "Bus routes", company2);
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            FindDistance.Enabled=true;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Actions of the "Find Distance" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            int sum1 = 0;
            int sum2 = 0;
            CombinedRouteDistance(Trolleybus, out sum1);
            CombinedRouteDistance(Busses, out sum2);
            DistanceRes.Text = "Trolley bus route distance is " + sum1 + " km\n" +
                               "Bus route distance is " + sum2+ " km";
            Combine.Enabled=true;
        }

        /// <summary>
        /// Actions of the "Combine" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Combine_Click(object sender, EventArgs e)
        {
            int lengthA = Convert.ToInt32(enterA.Text);
            int lengthB = Convert.ToInt32(enterB.Text);
            Combined = new List<Transport>();
            Interval(Trolleybus, Combined, lengthA, lengthB);
            Interval(Busses, Combined,lengthA, lengthB);
            PrintingTransportCont(CFr, Combined, "New list", "Combined list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Arrange.Enabled = true;
        }

        /// <summary>
        /// Actions of the "Rearrange" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Arrange_Click(object sender, EventArgs e)
        {
            Combined = Rearrange(Combined);
            PrintingTransportCont(CFr, Combined, "Rearranged List", "Combined list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
            Removal.Enabled = true;
        }

        /// <summary>
        /// Actions of the "Removal" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Removal_Click(object sender, EventArgs e)
        {
            string word=Word.Text;
            ThrowingOut(Combined, word);
            PrintingTransportCont(CFr, Combined, "List with removed route",
                                  "Combined list");
            results.LoadFile(CFr, RichTextBoxStreamType.PlainText);
        }
        private void Word_TextChanged(object sender, EventArgs e)
        {

        }        
        private void results_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Actions of the "User Guide" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guide_Click(object sender, EventArgs e)
        {
            string taskFile = File.ReadAllText(CFG);
            results.Text = taskFile;
            DistanceRes.Text = "Get acquainted with the task and user guide";
            MessageBox.Show("Program version: 1.001\n" +
            "Program creation date: 2023 February\n" +
            "Program author: Evelina Sakalauskaitė",
            "Information about the program");
        }

        /// <summary>
        ///  Actions of the "Close" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

         //Methods

        /// <summary>
        /// Data reading
        /// </summary>
        /// <param name="fv">Data file</param>
        /// <param name="company">Data file company name</param>
        /// <returns>Transport container</returns>
        static List<Transport> ReadTransportContainer (string fv, out string company)
        {
            List<Transport> TransportContainer = new List<Transport>();
            using (StreamReader strem = new StreamReader(fv, Encoding.GetEncoding(1257)))
            {
                string line;
                line = strem.ReadLine();
                company = line;
                while((line=strem.ReadLine())!= null)
                {
                    string[] parts = line.Split(';');
                    int number = int.Parse(parts[0]);
                    string route = parts[1];
                    int distance = int.Parse(parts[2]);
                    int stops=int.Parse(parts[3]);
                    Transport transport = new Transport(number, route, distance, stops);
                    TransportContainer.Add(transport);
                }
            }
            return TransportContainer;
        }

        /// <summary>
        /// Prints transport container contents
        /// </summary>
        /// <param name="fv">Data file</param>
        /// <param name="TransportContainer">Data container</param>
        /// <param name="caption">caption</param>
        /// <param name="company">Data file company name</param>
        static void PrintingTransportCont(string fv, List<Transport> TransportContainer, 
                                          string caption, string company)
        {
            const string top =
            "-------------------------------------------------------------\r\n"
            + "Nr.                Route                  Distance    Stops \r\n"
            + "-------------------------------------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append), 
                Encoding.GetEncoding(1257)))
            {
                if (TransportContainer.Count == 0) fr.WriteLine("A list is missing");
                else
                {
                    fr.WriteLine(company);
                    fr.WriteLine("\n " + caption);
                    fr.WriteLine(top);
                    for (int i = 0; i < TransportContainer.Count; i++)
                    {

                        fr.WriteLine("{0}", TransportContainer[i].ToString());

                    }
                    fr.WriteLine("---------------------------------------------------" +
                                 "----------\n");
                }
            }
        }

        /// <summary>
        /// Method that counts a containers combined route distance
        /// </summary>
        /// <param name="TransportContainer">Data container</param>
        /// <param name="sum">Distance sum</param>
        static void CombinedRouteDistance(List<Transport> TransportContainer, out int sum)
        {
            sum = 0;
            for (int i = 0; i < TransportContainer.Count; i++)
            {
                Transport temp=TransportContainer[i];
                sum += temp.Distance;
            }
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
            for(int i = 0; i < TransportContainer.Count; i++)
            {
                Transport temp = TransportContainer[i];
                if(lengthA<=temp.Distance&& lengthB >= temp.Distance)
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
            while(bk)
            {
                bk = false;
                for (int j=TransportContainer.Count - 1; j > i; j--)
                    if(TransportContainer[j] > TransportContainer[j - 1])
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
        static void ThrowingOut (List<Transport> TransportContainer, string word)
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
    }
}
