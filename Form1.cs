using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integrityControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choseMethod.SelectedIndex == 0)
                result.Text = ParityBits.Check(entryMassenge.Text);

            else if (choseMethod.SelectedIndex == 1)
                result.Text = IMEI.Check(entryMassenge.Text);

            else if (choseMethod.SelectedIndex == 2)
                result.Text = CRC.Check(entryMassenge.Text);
        }
    }
}
