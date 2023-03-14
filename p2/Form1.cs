using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        const string CFd = "Studentai.txt"; // duomenų failo varda
        const string CFr = "Rezultatai.txt"; // rezultatų failo vardas
        const string CFvs = "VertinimoSistema.txt"; // vertinimo sistema
        const string CFu = "Uzduotis.txt"; // užduoties failo vardas
        const string CFn = "Nurodymai.txt";

        private List<Studentas> StudentuTestas;
        private List<Pazymys> Pazymiai;
        public Form1()
        {
            InitializeComponent();
            //StudentuTestas = SkaitytiStudList(CFd);
            //SpausdintiStudList(CFr,
            //StudentuTestas, "Studentų sąrašas (testo rezultatai)");
            //Pazymiai = SkaitytiVertinimoSistemaList(CFvs);
            //label1.Text = "Studentų skaičius: " + Kiekis(StudentuTestas, 5).ToString();
            //label1.Text = "Studento indeksas: " + StudentoIndeksas(StudentuTestas,"Petraitis Petras").ToString();
            //MessageBox.Show(Kiekis(StudentuTestas, 5).ToString(), "Studentu skaicius:");
            //MessageBox.Show(StudentoIndeksas(StudentuTestas, "Petraitis Petras").ToString(),"Studento indeksas:");

            spausdintiToolStripMenuItem.Enabled = false;
            studentuSkaiciusToolStripMenuItem.Enabled = false;
            studentoIvertinimaiToolStripMenuItem.Enabled = false;
            vidurkiuSkaiciavimasToolStripMenuItem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static List<Studentas> SkaitytiStudList(string fv)
        {
            List<Studentas> StudTestas = new List<Studentas>();
            using (StreamReader srautas = new StreamReader(fv, Encoding.GetEncoding(1257)))
            {
                string eilute;
                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    string pavVrd = eilDalis[0];
                    int pazym = int.Parse(eilDalis[1]);
             
                    Studentas studentas = new Studentas(pavVrd, pazym);
                    StudTestas.Add(studentas);
                }
            }
            return StudTestas;

        }
        static void SpausdintiStudList(string fv, List<Studentas> StudTestas, string antraste)
        {
            const string virsus = "-----------------------------------\r\n"
            + " Nr.  Pavardė ir vardas    Pažymys \r\n"
            + "-----------------------------------";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append),
            Encoding.GetEncoding(1257)))
            {
                fr.WriteLine("\n " + antraste);
                fr.WriteLine(virsus);
                for (int i = 0; i < StudTestas.Count; i++)
                {
                    Studentas stud = StudTestas[i];
                    fr.WriteLine("{0, 3} {1}", i + 1, stud);
                }
                fr.WriteLine("-----------------------------------\n");
            }
        }
        static List<Pazymys> SkaitytiVertinimoSistemaList(string fv)
        {//skaito is vertinimosistema txt
            List<Pazymys> VertSistema = new List<Pazymys>();
            using (StreamReader srautas = new StreamReader(fv, Encoding.GetEncoding(1257)))
            {
                string eilute; // visa duomenų failo eilutė
                while ((eilute = srautas.ReadLine()) != null)
                {
                    string[] eilDalis = eilute.Split(';');
                    int pazym = int.Parse(eilDalis[0]);
                    string pazReiksme = eilDalis[1];
                    Pazymys pazymys = new Pazymys(pazym, pazReiksme);
                    VertSistema.Add(pazymys);
                }
            }
            return VertSistema;
        }
        static int Kiekis(List<Studentas> StudTestas, int pazymys)
        {
            int kiek = 0;
            for (int i = 0; i < StudTestas.Count; i++)
            {
                Studentas stud = StudTestas[i];
                if (stud.Pazym == pazymys)
                    kiek++;
            }
            return kiek;
        }
        static int StudentoIndeksas(List<Studentas> StudTestas, string pavVrd)
        {
            for (int i = 0; i < StudTestas.Count; i++)
            {
                if (StudTestas[i].PavVrd == pavVrd)
                    return i;
            }
            return -1;
        }

        private void duomenys_TextChanged(object sender, EventArgs e)
        {

        }

        private void pavardeVrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vertinimai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rezultatas_Click(object sender, EventArgs e)
        {

        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uzduotisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duomenys.LoadFile(CFu, RichTextBoxStreamType.PlainText);
        }

        private void nurodymaiVartotojuiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duomenys.LoadFile(CFn, RichTextBoxStreamType.PlainText);

        }

        private void ivestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pazymiai = SkaitytiVertinimoSistemaList(CFvs);
            // Komponento vertinimai užpildymas pažymiais
            foreach (Pazymys paz in Pazymiai)
                vertinimai.Items.Add(paz.ToString());
            vertinimai.SelectedIndex = 0;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Pasirinkite duomenų failą";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fv = openFileDialog1.FileName;
                duomenys.LoadFile(fv, RichTextBoxStreamType.PlainText);
                StudentuTestas = SkaitytiStudList(fv);
            }
            // Meniu punktų nustatymai
            ivestiToolStripMenuItem.Enabled = false;
            spausdintiToolStripMenuItem.Enabled = true;
            studentuSkaiciusToolStripMenuItem.Enabled = true;
            studentoIvertinimaiToolStripMenuItem.Enabled = true;
            vidurkiuSkaiciavimasToolStripMenuItem.Enabled = true;
        }

        private void spausdintiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SaveFileDialog komponento savybių nustatymas
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Pasirinkite rezultatų failą";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                string fv = saveFileDialog1.FileName;
                // Jeigu reikia rezultatų failas išvalomas
                if (File.Exists(fv))
                    File.Delete(fv);
                SpausdintiStudList(fv, StudentuTestas,
                "Studentų sąrašas (testo rezultatai)");
                //
                // Komponento dataGridView1 užpildymas duomenimis
                rezultatai.ColumnCount = 4;
                rezultatai.Columns[0].Name = "Nr.";
                rezultatai.Columns[0].Width = 40;
                rezultatai.Columns[1].Name = "Pavarde ir vardas";
                rezultatai.Columns[1].Width = 280;
                rezultatai.Columns[2].Name = "Pazymys";
                rezultatai.Columns[2].Width = 80;
                rezultatai.Columns[3].Name = "Lytis";
                rezultatai.Columns[3].Width = 150;
                for (int i = 0; i < StudentuTestas.Count; i++)
                {
                    Studentas studentas = StudentuTestas[i];
                    rezultatai.Rows.Add(i + 1, studentas.PavVrd, studentas.Pazym);
                }

            }
        }

        private void studentuSkaiciusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ivertis = vertinimai.SelectedItem.ToString().TrimStart();
            string[] eilDalis = ivertis.Split(' ');
            int pazymys = Int32.Parse(eilDalis[0]);
            int kiekis = Kiekis(StudentuTestas, pazymys);
            if (kiekis > 0)
                rezultatas.Text = "Studentu skaicius: " + kiekis.ToString();
            else
                rezultatas.Text = "Tokie studentu nera.";

        }

        private void studentoIvertinimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pavVrd = pavardeVrd.Text;
            int index = StudentoIndeksas(StudentuTestas, pavVrd);
            if (index > -1)
            {
                Studentas stud = StudentuTestas[index];
                int pazymys = stud.Pazym;
                pavardeVrd.Text = pavardeVrd.Text + " -> pažymys: " + pazymys.ToString();
            }
            else
                pavardeVrd.Text = pavardeVrd.Text + " -> tokio studento (-ės) nėra.";

        }

        private void vidurkiuSkaiciavimasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
           
            

                MessageBox.Show( "Vaikinų " +
                "pažymių vidurkis");
            

        }
        /*private double Vidurkis()
        {

        }*/

        private void meriginuVid_CheckedChanged(object sender, EventArgs e, string lytis)
        {


        }

        private void vaikinuVid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}