using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SR_1000_ver._1
{
    public partial class DataForm : Form

    {
        private readonly List<string> listDMC;
        private readonly List<string> listDMCdata;

        private List<XmlDMC> xmlDMCs;

        private readonly Label labelDMC, labelDMC1, labelDMC2, labelDMC3, labelDMC4,
            labelDMC5, labelDMC6, labelDMC7, labelDMC8;

        public DateTime dt { get; set; }

        public string lastDMC { get; set; }


        public DataForm(List<XmlDMC> xmlDMCs, string lastDMC, DateTime dt, List<string> listDMC, List<string> listDMCdata, Label labelDMC, Label labelDMC1, Label labelDMC2,
                        Label labelDMC3, Label labelDMC4, Label labelDMC5, Label labelDMC6, Label labelDMC7, Label labelDMC8)
        {
            InitializeComponent();

            this.xmlDMCs = xmlDMCs;

            this.dt = dt;
            this.lastDMC = lastDMC;
            this.listDMC = listDMC;
            this.listDMCdata = listDMCdata;
            this.labelDMC = labelDMC;
            this.labelDMC1 = labelDMC1;
            this.labelDMC2 = labelDMC2;
            this.labelDMC3 = labelDMC3;
            this.labelDMC4 = labelDMC4;
            this.labelDMC5 = labelDMC5;
            this.labelDMC6 = labelDMC6;
            this.labelDMC7 = labelDMC7;
            this.labelDMC8 = labelDMC8;

        }

        // Zapis DMC dat do souboru txt
        private void WriterDMC()
        {
            TextWriter writer = new StreamWriter(@"DMCdata.txt");
            writer.Write(richTextBoxData.Text);
            writer.Close();
        }

        // Vymazani vsech DMC dat z listu a labelu
        private void DeleteAllData()
        {
            listDMC.Clear();
            listDMCdata.Clear();
            labelDMC.Text = string.Empty;
            labelDMC1.Text = string.Empty;
            labelDMC2.Text = string.Empty;
            labelDMC3.Text = string.Empty;
            labelDMC4.Text = string.Empty;
            labelDMC5.Text = string.Empty;
            labelDMC6.Text = string.Empty;
            labelDMC7.Text = string.Empty;
            labelDMC8.Text = string.Empty;

            richTextBoxData.Clear();

            listBoxDMC.DataSource = null;
        }

        // Ulozeni DMC dat do souboru txt nebo xml
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            if (radioButtonTXT.Checked == true)
            {
                WriterDMC();
            }

            if (radioButtonXML.Checked == true)
            {
                Serializuj();
            }
        }

        // Vycteni dat ze souboru txt nebo xml
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTXT.Checked == true)
                {
                    richTextBoxData.Text = File.ReadAllText(@"DMCdata.txt");

                    listDMCdata.Add(richTextBoxData.Text);
                }

                if (radioButtonXML.Checked == true)
                {
                    Deserializuj();
                    listBoxDMC.DataSource = null;
                    listBoxDMC.DataSource = xmlDMCs;
                }
            }
            catch
            {
                WriterDMC();
            }
        }

        private void buttonAllDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure - Delete DATA!?", "DELETE ALL DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                DeleteAllData();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            richTextBoxData.Clear();
            this.Close();
        }

        private void Serializuj()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(xmlDMCs.GetType());

                using (StreamWriter sw = new StreamWriter("XmlDMC.xml"))
                {
                    serializer.Serialize(sw, xmlDMCs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deserializuj()
        {
            try
            {
                if (File.Exists("XmlDMC.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(xmlDMCs.GetType());
                    using (StreamReader sr = new StreamReader("XmlDMC.xml"))
                    {
                        xmlDMCs = (List<XmlDMC>)serializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("Soubor nebyl nalezen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    [Serializable()]
    public class XmlDMC
    {
        [XmlAttribute("DMC")]
        public string DMC { get; set; }

        [XmlAttribute("Datum")]
        public DateTime Datum { get; set; }

        public override string ToString()
        {
            return "DMC: " + DMC +
                " Datum: " + Datum;
        }
    }
}

