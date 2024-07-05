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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace retoxikalo
{
    public partial class mainForm : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 10;

        private ItalLapForm italForm = new ItalLapForm();



        public mainForm()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ItallapMenuItem.Enabled = false;
            SaveMenuItem.Enabled = false;

            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a képek létrehozásakor", "Hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 1; i <= kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".jpg");
                kepek.Add(kep);
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);
                    AdatBevitel(olvasoCsatorna);
                    ItallapMenuItem.Enabled = true;
                    SaveMenuItem.Enabled = true;
                    italForm.ArlapotIr(italok);
                    italForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
                finally
                {
                    if (olvasoCsatorna != null)
                    {
                        olvasoCsatorna.Close();
                    }
                }
            }
        }

        private void AdatBevitel(StreamReader olvasoCsatorna)
        {
            string sor = olvasoCsatorna.ReadLine();
            string[] adatok;
            while (sor != null)
            {
                adatok = sor.Split(';');
                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = olvasoCsatorna.ReadLine();
            }
        }

        private void ItallapMenuItem_Click(object sender, EventArgs e)
        {
            italForm.ArlapotIr(italok);
            italForm.ShowDialog();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter iroCsatorna = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    iroCsatorna = new StreamWriter(fajlNev);
                    FajlbaIr(iroCsatorna);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "Hiba");
                }
                finally
                {
                    if (iroCsatorna != null)
                    {
                        iroCsatorna.Close();
                    }
                }
            }
        }

        private void FajlbaIr(StreamWriter iroCsatorna)
        {
            foreach (Ital item in italok)
            {
                iroCsatorna.WriteLine(item.Konyvelesbe());
            }
        }

        private void GaleriaMenuItem_Click(object sender, EventArgs e)
        {
            GaleriaForm galeriaForm = new GaleriaForm();
            galeriaForm.Atad(kepek);
            galeriaForm.ShowDialog();
        }

        private void SugoMenuItem_Click(object sender, EventArgs e)
        {
            SugoForm sugoForm = new SugoForm();
            sugoForm.ShowDialog();
        }

        private void NevjegyMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Szalai Bálint", "információ");
        }

        private void KilepesMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

    class Ital
    {
        public string ItalNev { get; set; }
        public int EgysegAr { get; set; }
        public int Mennyiseg { get; private set; }
        public int OsszMennyiseg { get; private set; }
        public string Bevetel { get; private set; }

        public Ital(string italNev, int egyegAr)
        {
            ItalNev = italNev;
            EgysegAr = egyegAr;
        }

        public void Rendel(int db)
        {
            Mennyiseg += db;
        }

        public int Fizetendo()
        {
            return Mennyiseg * EgysegAr;
        }

        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * EgysegAr;
            Mennyiseg = 0;
        }

        public string Arlistaba()
        {
            return ItalNev + " (" + EgysegAr + " Ft)";
        }

        public string Konyvelesbe()
        {
            return ItalNev + ";" + OsszMennyiseg + ";" + Bevetel;
        }

        public override string ToString()
        {
            return Mennyiseg.ToString().PadLeft(4) + " " + ItalNev.PadRight(35) +
                Fizetendo().ToString().PadLeft(10) + " Ft";
        }
    }
}
