using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace Managment_System_Ptoject
{
    static class Program
    {
        public static Company myCompany = new Company("Eyal Company");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            if (File.Exists("myListFile")) //check if the file exists
            {
                Stream stream = File.Open("myListFile", FileMode.Open); //open the file
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();//create a BinaryFormatter that provide methods to convert object into a binary representation and recreate objects from a binary data.(serialization and deserialization of objects from file)
                myCompany._myCompanyList = (BindingList<Worker>)binaryFormatter.Deserialize(stream);//Deserialize - passing the 'stream' as input, read the binary data from it and reconstructs the original object hierarchy, the deserialize return 'object' type that cast to the list type.
                myCompany.counter = myCompany._myCompanyList.Count;
                stream.Close();
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new uplodingScreen()); //run the specific 


        }
    }
}
