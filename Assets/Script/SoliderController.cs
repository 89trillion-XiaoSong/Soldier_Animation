using UnityEngine;

public class SoliderController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    
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
            anim.SetTrigger("Run");
        }
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Win");
        }
    }
}
