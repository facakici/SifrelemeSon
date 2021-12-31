using SPN_16_Sifreleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        /// 

        public static Form1 oForm1 { get; set; }
        public static Form2 oForm2 { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            oForm1 = new Form1();
            Application.Run(oForm1);
        }
    }
}
