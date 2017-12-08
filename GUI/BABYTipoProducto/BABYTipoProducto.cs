using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using LOGIC;
using GUI;
namespace GUI.BABYTipoProducto
{
    public class BABYTipoProducto
    {
        public void frmINS()
        {
            frmBABYTipoProductoINS Forma = new frmBABYTipoProductoINS();
            Forma.ShowDialog();
        }

        public void frmMDF()
        {
            frmBABYTipoProductoMDF Forma = new frmBABYTipoProductoMDF();
            Forma.ShowDialog();
        }
    }
}
