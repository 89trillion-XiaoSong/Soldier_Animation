using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderController : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private bool isRun;
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.I)))
        {
            anim.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Attack");
        }
        if (Input.GetKey(KeyCode.R))
        {
            isRun = true;
            anim.SetBool("Run",isRun);
        }
        else
        {
            isRun = false;
            anim.SetBool("Run",false);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Win");
        }
    }
}
