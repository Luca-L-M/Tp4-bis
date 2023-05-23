using System.Collections.Generic;
namespace TPBase.Models;
public static class Info 
{
    static public List<string> ListaDestinos {get; private set;} = new List<string>();
    static public List<string> ListaHoteles {get; private set;} = new List<string>();
    static public List<string> ListaAereos {get; private set;} = new List<string>();
    static private List<Pais> ListaPaises {get; set;} = new List<Pais>();
    
    private static void InicializarLista()
    {
        DateTime fechaind = new DateTime (1816,07,09);
        Pais arg = new Pais("Argentina", "arg.jpg", 46000000, fechaind, "Messi");
        ListaPaises.Add(arg);
        DateTime fechaind2= new DateTime (1789,07,14);
        Pais frc = new Pais("Segundo", "segundo.jpg", 68000000, fechaind2, "louvre");
        ListaPaises.Add(frc);
        DateTime fechaind3= new DateTime (1830,07,21);
        Pais bel = new Pais("Belgica", "bel.jpg", 12000000, fechaind3, "Kevin De Bruyne");
        ListaPaises.Add(bel);
         DateTime fechaind4= new DateTime (1947,08,15);
        Pais ingl = new Pais("Inglaterra", "ingl.jpg", 56000000, fechaind4, "Big Ben");
        ListaPaises.Add(ingl);
         DateTime fechaind5= new DateTime (1830,07,21);
        Pais aus = new Pais("Australia", "aus.jpg", 26000000, fechaind5, "canguros");
        ListaPaises.Add(aus);
    }

    public static List<Pais> ListarPaises()
    {
        if(ListaPaises.Count == 0)
        {
           InicializarLista();
        } 
        return ListaPaises;
    }

    public static Pais DetallePais(string nombre) 
    {
        int x = 0;
        Pais devolver = new Pais();
        bool encontre = false;
        do 
        {
            if (ListaPaises[x].Nombre == nombre)
            {
                devolver = ListaPaises[x];
                encontre=true;
            }
            else x++;
        } while (x < ListaPaises.Count && !encontre);
        return devolver;
    }
}