using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domIS
{
    public partial class UcastnikForm : Form
    {
        public UcastnikForm(Ucastnik ucastnik)
        {
            InitializeComponent();
        }

        private void UcastnikForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
