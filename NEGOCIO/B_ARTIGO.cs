using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACESSODADOS;
using System.Data;

namespace NEGOCIO
{
    public class B_ARTIGO
    {
    // método inserir

    public static string Inserir(string nomeARTIGO, int idinflacao)
    {
        D_ARTIGO Obj = new D_ARTIGO();
        Obj.NomeArtigo = nomeARTIGO;
        Obj.id_inflacao = idinflacao;
        
        return Obj.Inserir(Obj);
    }

    // Método Editar
    public static string Editar(int idARTIGO, string nomeARTIGO, int idinflacao)
    {
        D_ARTIGO Obj = new D_ARTIGO();
        Obj.IdArtigo = idARTIGO;
        Obj.NomeArtigo = nomeARTIGO;
        Obj.id_inflacao = idinflacao;


        return Obj.Editar(Obj);
    }

    // Método Eliminar

    public static string Eliminar(int idARTIGO)
    {

        D_ARTIGO Obj = new D_ARTIGO();
        Obj.IdArtigo = idARTIGO;
        return Obj.Eliminar(Obj);
    }

    // Método Mostrar

    public static DataTable Mostrar()
    {
        return new D_ARTIGO().Mostrar();
    }

    // Método Buscar Categoria

    public static DataTable BuscarARTIGO(string textobuscar)
    {
            D_ARTIGO Obj = new D_ARTIGO();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarArtigo(Obj);
    }
}
}
