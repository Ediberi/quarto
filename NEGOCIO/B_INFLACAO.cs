using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
     public class B_INFLACAO
    {
        // método inserir

        public static string Inserir( int idinflacao, string nomeInflacao)
        {
            D_INFLACAO Obj = new D_INFLACAO();
            Obj.IdInflacao = idinflacao;
            Obj.NomeInflacao = nomeInflacao;

            return Obj.Inserir(Obj);
        }

        // Método Editar
        public static string Editar(int idinflacao, string nomeInflacao)
        {
            D_INFLACAO Obj = new D_INFLACAO();
            Obj.IdInflacao = idinflacao;
            Obj.NomeInflacao = nomeInflacao;
       


            return Obj.Editar(Obj);
        }

        // Método Eliminar

        public static string Eliminar(int idINFLACAO)
        {

            D_INFLACAO Obj = new D_INFLACAO();
            Obj.IdInflacao = idINFLACAO;
            return Obj.Eliminar(Obj);
        }

        // Método Mostrar

        public static DataTable Mostrar()
        {
            return new D_INFLACAO().Mostrar();
        }

        // Método Buscar Categoria

        public static DataTable BuscarInflacao(string textobuscar)
        {
            D_INFLACAO Obj = new D_INFLACAO();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}
