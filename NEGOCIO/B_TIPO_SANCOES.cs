using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
    public class B_TIPO_SANCOES
    {
        public static string Inserir(int idTIPO_SANCOES, string nomeTIPO_SANCOES, int ID_MULTA)
        {
            D_TIPO_SANCOES Obj = new D_TIPO_SANCOES();
            Obj.IdTIPO_SANCOES = idTIPO_SANCOES;
            Obj.NomeTIPO_SANCOES = nomeTIPO_SANCOES;
            Obj.ID_MULTA = ID_MULTA;
            return Obj.Inserir(Obj);
        }

        // Método Editar
        public static string Editar(int idTIPO_SANCOES, string nomeTIPO_SANCOES, int ID_MULTA)
        {
            D_TIPO_SANCOES Obj = new D_TIPO_SANCOES();
            Obj.IdTIPO_SANCOES = idTIPO_SANCOES;
            Obj.NomeTIPO_SANCOES = nomeTIPO_SANCOES;
            Obj.ID_MULTA = ID_MULTA;
            return Obj.Editar(Obj);
        }

        // Método Eliminar

        public static string Eliminar(int idTIPO_SANCOES)
        {

            D_TIPO_SANCOES Obj = new D_TIPO_SANCOES();
            Obj.IdTIPO_SANCOES = idTIPO_SANCOES;
            return Obj.Eliminar(Obj);
        }

        // Método Mostrar

        public static DataTable Mostrar()
        {
            return new D_TIPO_SANCOES().Mostrar();
        }

        // Método Buscar Categoria

        public static DataTable BuscarTIPO_SANCOES(string textobuscar)
        {
            D_TIPO_SANCOES Obj = new D_TIPO_SANCOES();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}
