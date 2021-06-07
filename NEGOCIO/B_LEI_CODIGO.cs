using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
    public class B_LEI_CODIGO
    {
         // método inserir

            public static string Inserir(int idLei_Codigo,string nomeLei_Codigo, int Id_ARTIGO, int IdSancoes,int IdTiPo_Lei_Codigo)
            {
                D_LEI_CODIGO Obj = new D_LEI_CODIGO();
                Obj.Id_LEI_CODIGO= idLei_Codigo;
                Obj.NomeLei_codigo = nomeLei_Codigo;
                Obj.IdARTIGO = Id_ARTIGO;
                Obj.IdSancoes = IdSancoes;
                Obj.Id_TIPO_LEI_CODIGO = IdTiPo_Lei_Codigo;
                return Obj.Inserir(Obj);
            }

            // Método Editar
            public static string Editar(int idLei_Codigo, string nomeLei_Codigo, int IdArtigo, int IdSancoes, int IdTiPo_Lei_Codigo)
            {
                D_LEI_CODIGO Obj = new D_LEI_CODIGO();
            Obj.Id_LEI_CODIGO = idLei_Codigo;
            Obj.NomeLei_codigo = nomeLei_Codigo;
            Obj.IdARTIGO = IdArtigo;
            Obj.IdSancoes = IdSancoes;
            Obj.Id_TIPO_LEI_CODIGO = IdTiPo_Lei_Codigo;


            return Obj.Editar(Obj);
            }

            // Método Eliminar

            public static string Eliminar(int IdLei_codigo)
            {

                D_LEI_CODIGO Obj = new D_LEI_CODIGO();
                Obj.Id_LEI_CODIGO = IdLei_codigo;
                return Obj.Eliminar(Obj);
            }

            // Método Mostrar

            public static DataTable Mostrar()
            {
                return new D_LEI_CODIGO().Mostrar();
            }

            // Método Buscar Categoria

            public static DataTable BuscarLEI_CODIGO(string textobuscar)
            {
            D_LEI_CODIGO Obj = new D_LEI_CODIGO();
                Obj.TextoBuscar = textobuscar;
                return Obj.BuscarCliente(Obj);
            }
        }
    }
