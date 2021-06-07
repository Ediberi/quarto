using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
   public class B_SANCOES
    {
        public static string Inserir(int idSANCOES, string nomeSANCOES, int ID_TIPO_LEI_CODIGO, int ID_TIPO_SANCOES)
        {
            D_SANCOES Obj = new D_SANCOES();
            Obj.IdSANCOES = idSANCOES;
            Obj.NomeSANCOES = nomeSANCOES;
            Obj.ID_TIPO_LEI_CODIGO = ID_TIPO_LEI_CODIGO;
            Obj.ID_TIPO_SANCOES = ID_TIPO_SANCOES;

            return Obj.Inserir(Obj);
        }

        // Método Editar
        public static string Editar(int idSANCOES, string nomeSANCOES, int IDTIPO_LEI_CODIGO, int ID_TIPO_SANCOES)
        {
            D_SANCOES Obj = new D_SANCOES();
            Obj.IdSANCOES = idSANCOES;
            Obj.NomeSANCOES = nomeSANCOES;
            Obj.ID_TIPO_LEI_CODIGO = IDTIPO_LEI_CODIGO;
            Obj.ID_TIPO_SANCOES = ID_TIPO_SANCOES;
            return Obj.Editar(Obj);
        }

        // Método Eliminar

        public static string Eliminar(int idSANCOES)
        {

            D_SANCOES Obj = new D_SANCOES();
            Obj.IdSANCOES = idSANCOES;
            return Obj.Eliminar(Obj);
        }

        // Método Mostrar

        public static DataTable Mostrar()
        {
            return new D_MULTA().Mostrar();
        }

        // Método Buscar Categoria

        public static DataTable BuscarSANCOES(string textobuscar)
        {
            D_SANCOES Obj = new D_SANCOES();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}
