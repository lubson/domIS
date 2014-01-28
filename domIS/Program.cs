using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataLayer;


namespace domIS
{
    public static class Program
    {
  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //TODO If generating through migrations works, remove this:
            //Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Run());
        }
    }
}

