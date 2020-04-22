using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleArrowStick : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Arrow")
        {
            collision.collider.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
