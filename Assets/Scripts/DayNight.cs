using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    [SerializeField] Transform light;
    float x = 0;
    



    private void Start()
    {
        StartCoroutine(Day());
    }

    private IEnumerator Day()
    {
        yield return new WaitForSeconds(1);
        x = 0.75f;
        light.Rotate(x, 0, 0);
        //light.rotation = new Quaternion(x, -50, 0, 1);
        StartCoroutine(Day());
    }
    
}
