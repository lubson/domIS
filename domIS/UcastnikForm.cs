﻿using DataLayer;
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

        public UcastnikForm(Ucastnik ucastnik)
        {
            InitializeComponent();
            Ucastnik = ucastnik;

        }

        private void UcastnikForm_Load(object sender, EventArgs e)
        {
            ucastnikBindingSource.DataSource = Ucastnik;
            dateTimePicker1.Value = new DateTime(1989, 3, 21);
            
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void save(object sender, EventArgs e)
        {
            Ucastnik.Created = new DateTime(2001, 11, 21);
            IUnitOfWork uow = new UnitOfWork();
            uow.Ucastnici.Add(Ucastnik);
            uow.Commit();
            Close();
        }
    }
}
