using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public string itemName; // Capitalized field name to adhere to naming conventions

    [Range(1, 9999)]
    public double sellingPrice; // Made public to ensure serialization

    [Range(1, 9999)]
    public double buyingPrice; // Made public to ensure serialization
}

