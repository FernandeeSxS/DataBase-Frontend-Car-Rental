using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace AluguerAutomoveis
{

    using System;
    using System.Windows.Forms;

    namespace AluguerAutomoveis
    {
        static class Program
        {
            // Ponto de entrada principal do aplicativo
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMenu());  // Inicializa o Form1 como a janela principal
            }
        }
    }


}
