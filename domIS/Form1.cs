using DataLayer;
using Model;
using System;
using System.Diagnostics;
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
            var uos = new UnitOfWork();
                
                    
                    var ucastnikRe = new UcastnikRepository(uos);
                    var ucastn = new Ucastnik
                    {
                        Jmeno = "Lubomir",
                        Prijmeni = "Hruban",
                        Narozen = DateTime.Now,
                        Created = DateTime.Now
                    };
                    ucastnikRe.InsertOrUpdate(ucastn);
                    uos.Commit();

            var uow = new UnitOfWork();
            var ucastnikRepository = new UcastnikRepository(uow);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 300; i++)
            {
                var ucastnik = new Ucastnik
                {
                    Jmeno = "Lubomir",
                    Prijmeni = "Hruban",
                    Narozen = DateTime.Now,
                    Created = DateTime.Now
                };
                ucastnikRepository.InsertOrUpdate(ucastnik);
                uow.Commit();  
            }
            stopWatch.Stop();
            Console.Out.WriteLine("---------------" + stopWatch.ElapsedMilliseconds + "---------------");
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < 300; i++)
            {
                using(var uo = new UnitOfWork())
                {
                    
                    var ucastnikRep = new UcastnikRepository(uo);
                    var ucastnik = new Ucastnik
                    {
                        Jmeno = "Lubomir",
                        Prijmeni = "Hruban",
                        Narozen = DateTime.Now,
                        Created = DateTime.Now
                    };
                    ucastnikRep.InsertOrUpdate(ucastnik);
                    uo.Commit();
                }
            }
            stopWatch.Stop();
            Console.Out.WriteLine("---------------" + stopWatch.ElapsedMilliseconds + "---------------");
            
        }
    }
}
