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

private void OnControllerColliderHit(ControllerColliderHit hit)
{
    Rigidbody body=hit.collider.attachedRigidbody;
    if(body==null||body.isKinematic)

    {
            return;

    }
    if(hit.moveDirection.y<-0.3)
    {
        return;

    }
    else
    {
    //ca.Empujar(true);
        Vector3 pushDir =new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);
        body.velocity=pushDir*pushpower;

    }
    
     //ca.Empujar(false);
}


}
