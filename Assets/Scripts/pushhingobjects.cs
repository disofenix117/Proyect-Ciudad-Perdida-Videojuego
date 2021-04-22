using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushhingobjects : MonoBehaviour
{
    // Start is called before the first frame update
      Animator animator;
      controlAnimaciones ca;
 void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public float pushpower=2.0f;
    private float targetmass;
   bool push=false;

private void OnControllerColliderHit(ControllerColliderHit hit)
{
    Rigidbody body=hit.collider.attachedRigidbody;
    if(body==null||body.isKinematic)
    {
        push=false;
            return;

    }
    if(hit.moveDirection.y<-0.3)
    {
        push=false;
        return;

    }
    else
    {
         push=true;
        targetmass=body.mass;
        Vector3 pushDir =new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);
        body.velocity=pushDir*pushpower/targetmass;


    }
       

    
     //ca.Empujar(false);
}
  void Update()
    {

        if(push==true)
        {
            animator.SetBool("empujar", true);
        }
        else
        {
            animator.SetBool("empujar", false);

        }
        
        
    }

}
