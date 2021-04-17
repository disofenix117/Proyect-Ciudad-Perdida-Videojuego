using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAnimaciones : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if( Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0)
        {
            animator.SetBool("caminar", true);
            
        }
        else
        {
               animator.SetBool("caminar", false);

        }
        if(Input.GetKey("e"))
        {
            animator.SetTrigger("recoger");
        }
        
        

    }

    public void Empujar(bool act)
{
    if(act==true)
    {
     animator.SetBool("empujar", true);
    }
    else
    {
        animator.SetBool("empujar", false);
    }

}

}
