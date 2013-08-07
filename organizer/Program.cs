using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace organizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form mine,welcome;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(welcome =new Form2());
            Application.Run(mine=new Form1());
            
        }


        
    }
}
