using UnityEngine;
using System.Collections.Generic;

public class Pentagram : MonoBehaviour
{
    // Lista di tutte le ricette possibili nel gioco
    public List<Recipe> recipes = new List<Recipe>();

    // Array che mantiene i 5 ingredienti
    public Item[] ingredients = new Item[5];

    public Item result;
    // metodo craft per craftare oggetti
    public Item Craft()
    {
        // controllo se esiste una ricetta qualsiasi che utilizza gli ingredienti che ho messo nel Pentagramma
        foreach (Recipe recipe in recipes)
        {
            if (CheckIngredients(recipe))
            {
                // faccio vedere il risultato della ricetta se ne trovo
                this.result = recipe.result;
                return recipe.result; //ritorno il risultato 
            }
        }

        // Nessuna ricetta valida, lo stampo nel log e ritorno null
        Debug.LogWarning("Nessuna ricetta valida trovata.");
        return null;
    }

    // Metodo per controllare che gli ingredienti di una ricetta corrispondano a quelli inseriti nel Pentagramma
    private bool CheckIngredients(Recipe recipe)
    {
        //logica da implementare
    }

}