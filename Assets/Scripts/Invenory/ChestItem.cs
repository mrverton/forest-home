using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChestItem : MonoBehaviour
{
    [SerializeField] int MaxSpawn = 3;
    [SerializeField] int Maxspawn = 48;
    [SerializeField] public List<Settings> chestItems;
    [SerializeField] List<Image> image;
    [SerializeField] List<Slider> durabillity;
    [SerializeField] List<Text> count;
    

    public void Spawn()
    {
        int currentSpawn = 0;
        List<Settings>items = Bag.instance.returnRecources();
        foreach (Settings a in items)
        {   
           
           int randomRange = Random.Range(0,100);
          
           if(randomRange < a.risk && MaxSpawn > currentSpawn)
           {
               chestItems.Add(a);
               currentSpawn++;
           }
        }
        Show();
    }

    void Show()
    {
        for (int i = 0; i < chestItems.Count; i++)
        {
            image[i].sprite = chestItems[i].icon;
            durabillity[i].value = chestItems[i].durability;
            count[i].text = chestItems[i].count.ToString();
        }
    }
}
