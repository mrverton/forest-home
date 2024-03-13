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
                bag[1].SetActive(false);
                break;
            case 2:
                bag[0].SetActive(true);
                bag[1].SetActive(false);
                break;
            case 3:
                bag[1].SetActive(true);
                bag[0].SetActive(false);
                break;
                 
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectorWeapon++;
            if(SelectorWeapon == 4)
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

                SelectorWeapon = 3;


            }
            ChangeWeapon();
        }
    }
}
