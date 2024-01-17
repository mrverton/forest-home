using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] Animator player;
    [SerializeField] StarterAssetsInputs input;
    private void FixedUpdate()
    {
        float speed =Mathf.Abs(input.move.x)+ Mathf.Abs(input.move.y);
        player.SetFloat("Speed", speed);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            player.SetTrigger("Attack");
        }
    }

    private void Start()
    {
        
    }
}
