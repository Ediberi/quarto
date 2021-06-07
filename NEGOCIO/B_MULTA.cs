using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
    public class B_MULTA
    {
        public static string Inserir(int idMULTA, string nomeMulta)
        {
            D_MULTA Obj = new D_MULTA();
            Obj.Id_MULTA = idMULTA;
            Obj.NomeMULTA = nomeMulta;
            return Obj.Inserir(Obj);
        }

        // Método Editar
        public static string Editar(int idMULTA, string nomeMulta)
        {
            D_MULTA Obj = new D_MULTA();
            Obj.Id_MULTA = idMULTA;
            Obj.NomeMULTA = nomeMulta;
            return Obj.Editar(Obj);
        }

        // Método Eliminar

        public static string Eliminar(int idMULTA)
        {

            D_MULTA Obj = new D_MULTA();
            Obj.Id_MULTA = idMULTA;
            return Obj.Eliminar(Obj);
        }

        // Método Mostrar

        public static DataTable Mostrar()
        {
            return new D_MULTA().Mostrar();
        }

        // Método Buscar Categoria

        public static DataTable BuscarMULTA(string textobuscar)
        {
            D_MULTA Obj = new D_MULTA();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}
 