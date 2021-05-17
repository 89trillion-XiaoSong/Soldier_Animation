using UnityEngine;

public class SolidierAnim : MonoBehaviour
{
    [SerializeField] private Animation soldierAnim;
    
    void Start()
    {
        soldierAnim.Play("Idle");
    }
    
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.I)))
        {
            soldierAnim.Play("Idle");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            soldierAnim.Play("Attack");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            soldierAnim.Play("Run");
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            soldierAnim.Play("Win");
        }
    }
}
