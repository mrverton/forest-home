using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    [SerializeField] GameObject Inventory;
    bool openInv = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (openInv)
            {
                openInv = false;
                Inventory.SetActive(false);
            }
            else
            {
                openInv = true;
                Inventory.SetActive(true);
            }
        }

    }
}
