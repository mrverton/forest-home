using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class looking : MonoBehaviour
{
    Ray ray;
    [SerializeField] GameObject player, chest, inv;
    public LayerMask layer;
    bool openInv = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (openInv)
            {
                openInv = false;
                player.GetComponent<PlayerInput>().enabled = true;
                inv.SetActive(false);
                chest.SetActive(false);
            }
            else
            {
                openInv = true;
                player.GetComponent<PlayerInput>().enabled = false;
                inv.SetActive(true);
            }
        }
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 10);

        
        RaycastHit raycast;



        if(Physics.Raycast(ray,out raycast,10,layer))
        {   
           if(raycast.transform.tag=="Chest")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {


                    chest.SetActive(true);
                    inv.SetActive(true);
                    player.GetComponent<PlayerInput>().enabled = false;
                    openInv = true;
                }
            }
        }
       
    }

}
