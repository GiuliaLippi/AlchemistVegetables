using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe")]
public class Recipe : ScriptableObject
{
    [SerializeField]
    private Item[] ingredients = new Item[5]; // Serialized array of ingredients

    [SerializeField]
    private Item result; // Serialized field for the result

    // Getters and setters for accessing and modifying the fields
    public Item[] Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    public Item Result
    {
        get { return result; }
        set { result = value; }
    }
}