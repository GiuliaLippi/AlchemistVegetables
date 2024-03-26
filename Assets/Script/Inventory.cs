using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public struct InvetorySlot
{
   
    public Item item;
    [Range(1, 64)]
    public int quantity;
}
public class Inventory : MonoBehaviour

    {
        public int limit;
        public static Inventory Instance;
        public List<InvetorySlot> Items = new List<InvetorySlot>(); //Lista     

        private void Awake() //funzione che mi permette 
        {
            Instance = this; // valore di Instance             
        }

        public void Add(Item Item)
        {
            InvetorySlot slot = new InvetorySlot();
            Debug.Log("sfa");
            
            //aggiungi logica per creare lo slot se l'item non è nell'inventario oppure fare +1 all'oggetto
    }

        public void Remove(Item Item)
        {
            //aggiungi logica per rimuovere l'item interamente oppure fare -1
        }
    

}
