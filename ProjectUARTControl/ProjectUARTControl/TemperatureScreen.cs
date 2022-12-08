using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUARTControl
{
    public partial class TemperatureScreen : Form
    {
        private SerialPortManager manager;

        public TemperatureScreen()
        {
            InitializeComponent();

            manager = new SerialPortManager(txtReadValues, lblSystem);
            updateComponents();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboPorts.ResetText();
            comboPorts.DataSource = manager.GetAvailablePorts();
            updateComponents();
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (manager.Connected())
            {
                manager.CloseConnection();
            }
            else
            {
                manager.OpenConnection(comboPorts.SelectedItem.ToString());
            }
            updateComponents();
        }
        

        private void updateComponents()
        {
            if (comboPorts.Items.Count < 1)
            {
                btnConnect.Enabled = false;
            }
            else
            {
                btnConnect.Enabled = true;
            }

            if (manager.Connected())
            {
                btnConnect.Text = "Отключиться";
            }
            else
            {
                btnConnect.Text = "Подключиться";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReadValues.Clear();
        }
        
    }
}
