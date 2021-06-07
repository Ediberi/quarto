using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
    public class B_TIPO_LEI_CODIGO
    {
        public static string Inserir(int idTIPO_LEI_CODIGO, string nomeTIPO_LEI_CODIGO)
        {
            D_TIPO_LEI_CODIGO Obj = new D_TIPO_LEI_CODIGO();
            Obj.IdTIPO_LEI_CODIGO = idTIPO_LEI_CODIGO;
            Obj.NomeTIPO_LEI_CODIGO = nomeTIPO_LEI_CODIGO;
            return Obj.Inserir(Obj);
        }

        // Método Editar
        public static string Editar(int idTIPO_LEI_CODIGO, string nomeTIPO_LEI_CODIGO)
        {
            D_TIPO_LEI_CODIGO Obj = new D_TIPO_LEI_CODIGO();
            Obj.IdTIPO_LEI_CODIGO = idTIPO_LEI_CODIGO;
            Obj.NomeTIPO_LEI_CODIGO = nomeTIPO_LEI_CODIGO;
            return Obj.Editar(Obj);
        }

        // Método Eliminar

        public static string Eliminar(int idTIPO_LEI_CODIGO)
        {

            D_TIPO_LEI_CODIGO Obj = new D_TIPO_LEI_CODIGO();
            Obj.IdTIPO_LEI_CODIGO = idTIPO_LEI_CODIGO;
            return Obj.Eliminar(Obj);
        }

        // Método Mostrar

        public static DataTable Mostrar()
        {
            return new D_TIPO_LEI_CODIGO().Mostrar();
        }

        // Método Buscar Categoria

        public static DataTable BuscarMULTA(string textobuscar)
        {
            D_TIPO_LEI_CODIGO Obj = new D_TIPO_LEI_CODIGO();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}

