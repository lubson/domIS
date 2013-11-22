using DataLayer;
using Model;
using System;
using System.Windows.Forms;


namespace domIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ucastnik = new Ucastnik { 
                Jmeno = "Lubomír",
                Prijmeni = "Hruban",
                Narozen = DateTime.Now,
                Created = DateTime.Now
            };

            var db = new TestContext();
            db.Ucastnici.Add(ucastnik);
            db.SaveChanges();
        }
    }
}
