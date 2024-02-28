using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] Animator player;
    [SerializeField] StarterAssetsInputs input;
    [SerializeField] FirstPersonController controller;

    private void FixedUpdate()
    {
        float speed =Mathf.Abs(input.move.x)+ Mathf.Abs(input.move.y);
        player.SetFloat("Speed", speed);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switch (Selector.instance.SelectorWeapon)
            {
                case 1:
                    player.SetTrigger("Punch");
                    break;
                case 2:
                    player.SetTrigger("Attack");
                    break;
            }
            

        }
        if (input.jump)
        {
            player.SetTrigger("Jump");
        }
    }

    private void Start()
    {
        
    }
}
