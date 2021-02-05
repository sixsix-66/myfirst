using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour {

	// Use this for initialization
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Bullet")
            return;
        Destroy(collision.gameObject);
    }
    private void OnTriggerStay(Collider Other)
    {
        if (Other.tag != "Bullet")
            return;
        if(Other.attachedRigidbody)
        {
            Other.attachedRigidbody.AddForce(Vector3.up * 20);
        }
    }
}
