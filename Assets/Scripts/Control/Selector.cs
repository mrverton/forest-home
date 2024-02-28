using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{   
    public int SelectorWeapon = 1;

    public static Selector instance;
    public List<GameObject> bag;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        ChangeWeapon();


    }
    public void ChangeWeapon()
    {
        switch (SelectorWeapon)
        {
            case 1:
                bag[0].SetActive(false);
                break;
            case 2:
                bag[0].SetActive(true);
                break;
                 
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectorWeapon++;
            if(SelectorWeapon == 3)
            {
                SelectorWeapon = 1;
                
            }
            ChangeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SelectorWeapon--;

            if (SelectorWeapon == 0)
            {   

                SelectorWeapon = 2;

            }
            ChangeWeapon();
        }
    }
}
