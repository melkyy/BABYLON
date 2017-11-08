using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DBConfig
{
    public class CONFIG
    {
        private string Archivo = Environment.CurrentDirectory + "\\db.conf";

        public void ReadCurrentConnectionString(ref string Conn)
        {
            try
            {
                if (!File.Exists(Archivo))
                    File.WriteAllText(Archivo, "");
                Conn = File.ReadAllText(Archivo);
            }
            catch (Exception ex)
            {
                
            }
        }
        public void WriteCurrentConnectionString(string Conn)
        {
            try
            {
                File.WriteAllText(Archivo, Conn);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
