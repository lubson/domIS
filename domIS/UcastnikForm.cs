using DataLayer;
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
        public Ucastnik Ucastnik { get; set; }
        public IList<CNarodnost> CNarodnosti { get; set; }
        public IUnitOfWork UOW {get; set; }
        

        public UcastnikForm(Ucastnik ucastnik)
        {
            InitializeComponent();

            UOW = new UnitOfWork();
            
            Ucastnik = ucastnik;
            CNarodnosti = UOW.CNarodnosti.GetAll().ToList();
        }

        private void UcastnikForm_Load(object sender, EventArgs e)
        {
            ucastnikBindingSource.DataSource = Ucastnik;

            //comb
            
            comboBox1.DataSource = CNarodnosti;
            comboBox1.DisplayMember = "ComboName";

            dateTimePicker1.Value = new DateTime(1989, 3, 21);
            
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void save(object sender, EventArgs e)
        {
            UOW.Ucastnici.Add(Ucastnik);
            UOW.Commit();
            Close();
        }

    }
}
