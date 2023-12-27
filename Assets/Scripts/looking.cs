using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looking : MonoBehaviour
{
    Ray ray;
    public LayerMask layer;
    private void Update()
    {
        
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 10);

        
        RaycastHit raycast;
        if(Physics.Raycast(ray,out raycast,10,layer))
        {
            Debug.Log(raycast.transform.tag);
        }
    }

}
