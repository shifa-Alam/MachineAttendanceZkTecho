using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioMetrixCore;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DeviceManipulator manipulator = new DeviceManipulator();
        public ZkemClient objZkeeper;
        private bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void RaiseDeviceEvent(object sender, string actionType)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = tbxDeviceIP.Text.Trim();
            int portNumber = 4370;

            objZkeeper = new ZkemClient(RaiseDeviceEvent);
            IsDeviceConnected = objZkeeper.Connect_Net(ipAddress, portNumber);
            if (IsDeviceConnected)
            {
                string deviceInfo = manipulator.FetchDeviceInfo(objZkeeper, int.Parse("1"));
                deviceInfoTextBox.Text = deviceInfo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxDeviceIP_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
