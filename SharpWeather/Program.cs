/*
 * Created by SharpDevelop.
 * User: edenfield-john
 * Date: 02/25/2016
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;


namespace Sharp_Weather
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }

        static string ReadAPI(string file)
        {
            file = string.Format(@"C:\API\{0}", file);
            string value2 = File.ReadAllText(file);
            return value2;
        }
    }
}
