using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treePlay : MonoBehaviour
{
    [SerializeField] GameObject tree;
    
    
    public int health = 15;


    public void damage(int d)
    {
        switch (gameObject.tag)
        {
            case "tree":
                Bag.instance.AddItem("wood", 1);
                break;
            case "rock":
                Bag.instance.AddItem("rocks", 1);
                break;
        }
        
        health -= d;
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

    
}
