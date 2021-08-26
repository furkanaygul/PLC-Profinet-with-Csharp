using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
namespace S7NetD2
{
    public partial class Form1 : Form
    {
        private Plc plc = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            CbCpu.DataSource = Enum.GetNames(typeof(CpuType));// comboboxa cpu tiplerini atadik
            CbCpu.SelectedIndex = 5;//default s7-1200 secildi
            btnDisconnect.Enabled = false;
            btnMotorRun.Enabled = false;
            groupBox2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (plc != null)
            {
                plc.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CpuType cpuType = (CpuType)Enum.Parse(typeof(CpuType), CbCpu.Text);
            string adress = txtIp.Text;
            short rack = short.Parse(txtRack.Text);
            short slot = short.Parse(txtSlot.Text);
            //plc = new Plc(cpuType, adress, rack, slot);
            plc = new Plc(cpuType, adress, rack, slot);
            try
            {
                plc.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                groupBox1.Enabled = false;
                btnMotorRun.Enabled = true;

                groupBox2.Enabled = true;
                //BOOL
                plc.Write("DB1.DBX0.0", false);
                //BOOL
                plc.Write("DB1.DBX0.1", true);
                //INT 16 bit integer
                plc.Write("DB1.DBW2.0", (Int16)536);
                //Real degeri 
                plc.Write("DB1.DBD4.0", (float)32.14);
                //Dint yani 32bit normal int
                plc.Write("DB1.DBD8.0", -134);
                //WORD
                plc.Write("DB1.DBD12.0", (uint)67);
                //WORD
                plc.Write("DB1.DBW16.0", (ushort)87);




                bool db1Bool1 = (bool)plc.Read("DB1.DBX0.0");
                Console.WriteLine("DB1.DBX0.0 " + db1Bool1);
                bool db1Bool2 = (bool)plc.Read("DB1.DBX0.1");
                Console.WriteLine("DB1.DBX0.1 " + db1Bool2);
                var db1INT = (ushort)plc.Read("DB1.DBW2.0");
                Console.WriteLine("DB1.DBW2.0 " + db1INT);
                var db1REAL = ((uint)plc.Read("DB1.DBD4.0")).ConvertToFloat();
                Console.WriteLine("DB1.DBD4.0 " + db1REAL);
                var db1DINT = ((uint)plc.Read("DB1.DBD8.0")).ConvertToInt();
                Console.WriteLine("DB1.DBD8.0 " + db1DINT);
                var db1DWord = ((uint)plc.Read("DB1.DBD12.0")).ToString("X8");
                Console.WriteLine("DB1.DBD12.0 " + db1DWord);
                var db1Word = ((ushort)plc.Read("DB1.DBW16.0")).ToString("X4");
                Console.WriteLine("DB1.DBD16.0 " + db1Word);
                var db1Time = (uint)plc.Read("DB1.DBD18.0");
                Console.WriteLine("DB1.DBD18.0" + db1Time);

                ////NEGATIF
                //plc.Write("DB2.DBX0.0", true);//bool
                //plc.Write("DB2.DBX0.1", false);//bool
                //short value = -340;
                //plc.Write("DB2.DBW2.0", value.ConvertToUshort());//int
                //float valuee = 3.1245f;
                //plc.Write("DB2.DBD4.0", valuee);//real
                //ushort val = 10000;
                //plc.Write("DB2.DBW16", val);


                //bool db2Bool1 = (bool)plc.Read("DB2.DBX0.0");
                //Console.WriteLine("DB2.DBX0.0 " + db1Bool1);
                //bool db2Bool2 = (bool)plc.Read("DB2.DBX0.1");
                //Console.WriteLine("DB2.DBX0.1 " + db1Bool2);
                //short db2INT = ((ushort)plc.Read("DB2.DBW2")).ConvertToShort();
                //Console.WriteLine("DB2.DBW2.0 " + db1INT);
                //var db2REAL = ((uint)plc.Read("DB2.DBD4.0")).ConvertToFloat();
                //Console.WriteLine("DB2.DBD4.0 " + db1REAL);
                //var db2DINT = (uint)plc.Read("DB2.DBD8.0");
                //Console.WriteLine("DB2.DBD8.0 " + db1DINT);
                //var db2DWord = ((uint)plc.Read("DB2.DBD12.0"));
                //Console.WriteLine("DB2.DBD12.0 " + db1DWord);
                //ushort db2Word = ((ushort)plc.Read("DB2.DBW16"));
                //Console.WriteLine("DB2.DBD16.0 " + db1Word);

            }
            catch (Exception)
            {
                MessageBox.Show(this, "PLC ile baglanti kurulamadi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc.IsConnected)
                {
                    plc.Write("DB1.DBX24.0", true);
                    plc.Write("DB1.DBX24.1", false);
                    if ((bool)plc.Read("Q0.0"))
                    {
                        btnMotorRun.Enabled = false;
                        btnMotorClose.Enabled = true;
                        pictureBox1.Image = Properties.Resources.engine;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc.IsConnected)
                {
                    plc.Close();
                    btnDisconnect.Enabled = false;
                    btnConnect.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc.IsConnected)
                {
                    plc.Write("DB1.DBX24.0", false);
                    plc.Write("DB1.DBX24.1", true);
                    btnMotorRun.Enabled = true;
                    btnMotorClose.Enabled = false;
                    pictureBox1.Image = Properties.Resources.Untitled;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }
    }
}
