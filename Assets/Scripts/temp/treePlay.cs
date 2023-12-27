using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treePlay : MonoBehaviour
{
    [SerializeField] GameObject tree;
    [SerializeField] GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("parent");
        var Obj = Instantiate(tree, transform);
        Obj.transform.parent = parent.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
