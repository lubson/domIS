using DataLayer;
using Model;
using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace domIS
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ucastnikForm = new UcastnikForm(new Ucastnik());
            ucastnikForm.Show();
            
        }
    }
}
