using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestItem : MonoBehaviour
{
    [SerializeField] int MaxSpawn = 3;
    [SerializeField] int Maxspawn = 48;
    [SerializeField] public List<Settings> items;

    private void Start()
    {
        int currentSpawn = 0;
        items = Bag.instance.returnRecources();
        foreach (Settings a in items)
        {   
           
           int randomRange = Random.Range(0,100);
          
           if(randomRange < a.risk && MaxSpawn > currentSpawn)
           {
               items.Add(a);
               currentSpawn++;
           }
        }
    }

}
