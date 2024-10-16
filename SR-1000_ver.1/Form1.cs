using Keyence.AutoID.SDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SR_1000_ver._1
{

    public partial class Keyence_SR_1000 : Form
    {
        private readonly ReaderAccessor scaner = new ReaderAccessor();

        private readonly List<string> listDMCdata = new List<string>();

        public readonly List<string> listDMC;        

        private List<XmlDMC> xmlDMCs;
               
        public DateTime dt { get; set; }
        public string lastDMC { get; set; }
        public DataForm data { get; set; }              

        bool trigOK = false;
        bool scanerConnectOK = false;

        readonly Thread thread;
        Color connect { get; set; }

        public Keyence_SR_1000()
        {
            InitializeComponent();

            ScannerConnectIP();

            listDMC = new List<string>();

            xmlDMCs = new List<XmlDMC>();

            data = new DataForm(xmlDMCs, lastDMC, dt, listDMC, listDMCdata, labelDMC, labelDMC1, labelDMC2, labelDMC3,
                labelDMC4, labelDMC5, labelDMC6, labelDMC7, labelDMC8) ;

            
            thread = new Thread(new ThreadStart(WorkThreadFunction));

            thread.Start();

            connect = Color.Red;
        }

        // Vytvoreni spojeni se scanerem
        private void ScannerConnectIP()
        {
            scaner.IpAddress = "192.168.0.25";
            scaner.Connect();

            liveviewForm.IpAddress = scaner.IpAddress;

            liveviewForm.BeginReceive();
        }

        // Overeni spojeni se scanerem
        private void ScannerConnect()
        {
            if (scaner.Connect() == true)
            {
                trigOK = true;
            }
            
            if (scaner.Connect() == false)
            {
                trigOK = false;
            }
        }

        // Zapis DMC a datumu po trigru
        private void Received(string receiveData)
        {
            // Pro txt soubor
            dt = DateTime.Now;
            
            lastDMC = receiveData;
            listDMC.Insert(0, lastDMC);
            listDMCdata.Insert(0, dt + "\t" + lastDMC);

            PrintDMC();

            // Pro xml soubor
            XmlDMC xmlDMC = new XmlDMC
            {
                DMC = lastDMC,
                Datum = dt,
            };
            // Pridani DMC do kolekce
            xmlDMCs.Insert(0,xmlDMC);
        }

        // Zapis DMC kodu do labelu
        private void PrintDMC()
        {
            labelDMC.Text = lastDMC;

            try
            {
                labelDMC1.Text = listDMC[0];
                labelDMC2.Text = listDMC[1];
                labelDMC3.Text = listDMC[2];
                labelDMC4.Text = listDMC[3];
                labelDMC5.Text = listDMC[4];
                labelDMC6.Text = listDMC[5];
                labelDMC7.Text = listDMC[6];
                labelDMC8.Text = listDMC[7];
            }
            catch { }
        }

        // Aktivace vlakna pro hlidani pripojeni ke scaneru
        private void WorkThreadFunction()
        {
            while (true)
            {
                ScannerConnect();

                if (scanerConnectOK == true && trigOK == false)
                {
                    labelConnect.Text = "Disconnect";
                    connect = Color.Red;

                    scanerConnectOK = false;
                }

                if (scanerConnectOK == false && trigOK == true)
                {
                    labelConnect.Text = "Connect";
                    connect = Color.Green;
                    
                    scanerConnectOK = true;
                }

                {
                    this.Invoke((MethodInvoker)delegate { labelConnect.ForeColor = connect; });
                }
            }
        }

        // Trignuti scanerem a nacteni DMC kodu
        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            ScannerConnect();

            if (trigOK == true)
            {
                Received(scaner.ExecCommand("LON"));
            }

            if (!trigOK)
            {
                MessageBox.Show("No connect with SR-1000", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        // Vyvolani dalsiho formulare se yobrayenim DMC dat
        private void buttonReadAllData_Click(object sender, EventArgs e)
        {

            foreach (var item in listDMCdata)
            {
                data.richTextBoxData.AppendText(item);
            }

            data.ShowDialog();
        }

        // Ukonceni formulare
        private void buttonExit_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        // Vymayani dat z labelu a listu
        private void buttonDmcDelete_Click(object sender, EventArgs e)
        {
            listDMC.Clear();
            labelDMC1.Text = string.Empty;
            labelDMC2.Text = string.Empty;
            labelDMC3.Text = string.Empty;
            labelDMC4.Text = string.Empty;
            labelDMC5.Text = string.Empty;
            labelDMC6.Text = string.Empty;
            labelDMC7.Text = string.Empty;
            labelDMC8.Text = string.Empty;
        }
    }
}
