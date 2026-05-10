using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour
{
    List<string> letters = new List<string>()
    {
        "a","b","c","d","e","f","g","h","i"
    };

    void Start()
    {
        var a =  letters.GroupBy(x => x[0] == 'A');
        Dictionary<bool, List<string>> dict = a.ToDictionary(g => g.Key, g => g.ToList());
        /*var diccionario =
    enemigos
    .GroupBy(x => x.tipo)
    .ToDictionary(
        g => g.Key,
        g => g.ToList()
    );*/
    }
    //========================================================
    // FIRST
    //========================================================
    [Button]
    public void AplicandoFirst()
    {
        // Obtiene el PRIMER elemento de la colección

        string firstLetter = letters.First();

        Debug.Log(firstLetter);
    }

    //========================================================
    // LAST
    //========================================================
    [Button]
    public void AplicandoLast()
    {
        // Obtiene el ÚLTIMO elemento de la colección

        string lastLetter = letters.Last();

        Debug.Log(lastLetter);
    }

    //========================================================
    // FIRST OR DEFAULT
    //========================================================
    [Button]
    public void AplicandoFirstOrDefault()
    {
        // Busca el primer elemento que cumpla una condición
        // Si no existe devuelve null/default

        string result = letters.FirstOrDefault(x => x == "z");

        Debug.Log(result);
    }

    //========================================================
    // WHERE
    //========================================================
    [Button]
    public void AplicandoWhere()
    {
        // Filtra múltiples elementos según una condición

        var result = letters.Where(x => x.Contains("a"));

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // ANY
    //========================================================
    [Button]
    public void AplicandoAny()
    {
        // Verifica si EXISTE al menos un elemento

        bool exists = letters.Any(x => x == "d");

        Debug.Log(exists);
    }

    //========================================================
    // ALL
    //========================================================
    [Button]
    public void AplicandoAll()
    {
        // Verifica si TODOS cumplen una condición

        bool result = letters.All(x => x.Length == 1);

        Debug.Log(result);
    }

    //========================================================
    // CONTAINS
    //========================================================
    [Button]
    public void AplicandoContains()
    {
        // Verifica si un elemento existe dentro de la lista

        bool result = letters.Contains("f");

        Debug.Log(result);
    }

    //========================================================
    // COUNT
    //========================================================
    [Button]
    public void AplicandoCount()
    {
        // Cuenta cuántos elementos cumplen una condición

        int count = letters.Count(x => x != "a");

        Debug.Log(count);
    }

    //========================================================
    // ORDER BY
    //========================================================
    [Button]
    public void AplicandoOrderBy()
    {
        // Ordena ascendentemente

        var result = letters.OrderBy(x => x);

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // ORDER BY DESCENDING
    //========================================================
    [Button]
    public void AplicandoOrderByDescending()
    {
        // Ordena descendentemente

        var result = letters.OrderByDescending(x => x);

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // SELECT
    //========================================================
    [Button]
    public void AplicandoSelect()
    {
        // Transforma elementos de una colección

        var result = letters.Select(x => x.ToUpper());

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // DISTINCT
    //========================================================
    [Button]
    public void AplicandoDistinct()
    {
        // Elimina elementos repetidos

        List<string> repeated = new List<string>()
        {
            "a","a","b","b","c","d"
        };

        var result = repeated.Distinct();

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // TAKE
    //========================================================
    [Button]
    public void AplicandoTake()
    {
        // Obtiene una cantidad específica de elementos

        var result = letters.Take(3);

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // SKIP
    //========================================================
    [Button]
    public void AplicandoSkip()
    {
        // Salta cierta cantidad de elementos

        var result = letters.Skip(3);

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // REVERSE
    //========================================================
    [Button]
    public void AplicandoReverse()
    {
        // Invierte el orden de la colección

        var result = letters.AsEnumerable().Reverse();

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

    //========================================================
    // ELEMENT AT
    //========================================================
    [Button]
    public void AplicandoElementAt()
    {
        // Obtiene el elemento en una posición específica

        string result = letters.ElementAt(4);

        Debug.Log(result);
    }

    //========================================================
    // TO LIST
    //========================================================
    [Button]
    public void AplicandoToList()
    {
        // Convierte el resultado LINQ nuevamente en una List

        List<string> result =
            letters.Where(x => x != "a").ToList();

        Debug.Log(result.Count);
    }

    //========================================================
    // TO ARRAY
    //========================================================
    [Button]
    public void AplicandoToArray()
    {
        // Convierte la colección en un Array

        string[] result = letters.ToArray();

        Debug.Log(result.Length);
    }

    //========================================================
    // CHAINING
    //========================================================
    [Button]
    public void AplicandoEncadenamientoLINQ()
    {
        // Combina múltiples consultas LINQ

        var result =
            letters
            .Where(x => x != "a")
            .OrderByDescending(x => x)
            .Take(3)
            .Select(x => x.ToUpper());

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }

}
