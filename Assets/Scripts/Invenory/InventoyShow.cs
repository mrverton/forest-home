using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoyShow : MonoBehaviour
{
    [SerializeField] Sprite locked;
    [SerializeField] Sprite opened;
    [SerializeField] List<Image> picture;
    [SerializeField] List<Text> count;
    [SerializeField] List<Slider> durability;
    [SerializeField] public int MaxCount = 20;
    
    public void fill()
    {
        int itemNumber = 0;
        locks();
        foreach (Settings a in Bag.instance.invetory)
        {
            picture[itemNumber].sprite = a.icon;
            count[itemNumber].text = a.count.ToString();
            durability[itemNumber].value = a.durability;
            itemNumber++;
        }

    }
    private void locks()
    {
        int x = 0;
        foreach(Image a in picture)
        {
            if (x < MaxCount)
            {
                a.sprite = opened;
            }
            else
            {
                a.sprite = locked;
            }
            x++;
        }
    }

    private void Start()
    {
        fill();
    }

    private void OnEnable()
    {
        fill();
    }
}
