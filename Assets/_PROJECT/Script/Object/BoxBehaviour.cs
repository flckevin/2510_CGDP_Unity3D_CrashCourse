using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    public int boxHealth = 3;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            BoxBehaviourCheck();
        }
    }

    private void BoxBehaviourCheck()
    {
        boxHealth--;
        
        if(boxHealth < 2 )
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if(boxHealth < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
