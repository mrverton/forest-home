using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controll : MonoBehaviour
{
    [SerializeField] GameObject Inventory;
    bool openInv = false;
    [SerializeField] GameObject Player;

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
                Player.GetComponent<PlayerInput>().enabled = true;
                Inventory.SetActive(false);
            }
            else
            {
                openInv = true;
                Player.GetComponent<PlayerInput>().enabled = false;
                Inventory.SetActive(true);
            }
        }

    }
}
