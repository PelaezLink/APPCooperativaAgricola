using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.BusinessLogic.Services;
using TarongISW.Persistence;

namespace TarongISW.GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TarongISWApp(service));
        }
    }
}
