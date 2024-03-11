using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{   
    
    public static Bag instance;
    [SerializeField] public List<Settings> recources;
    [SerializeField] public List<Settings> invetory;
    [SerializeField] public int MaxCount;

    void Awake()
    {
        instance = this;

    }
    public void AddItem(string name,int count)
    {
        bool checking = false;
        foreach(Settings a in invetory)
        {
            if (a.name == name)
            {
                a.count += count;
                checking = true;
            }
        }
        if (checking == false)
        {
            createItem(name, count);
        }
    }
    
   void createItem(string name,int count)
    {
        Settings save = new Settings();
        foreach(Settings a in recources)
        {
            if (a.name == name)
            {
                save = a;
                save.count = count;
                 
            }
        }
        invetory.Add(save);
    }

    public List<Settings> returnRecources()
    {
        return recources;
    }
}
