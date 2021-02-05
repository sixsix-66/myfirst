using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	public ConstantForce bullet;
	private float pressedTime;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
        {
			pressedTime += Time.deltaTime;
        }
		if(Input.GetButtonUp("Fire1"))
        {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit))
            {
				ConstantForce cf = Instantiate<ConstantForce>(bullet, ray.origin,
					Quaternion.LookRotation(hit .point-ray.origin));
				cf.relativeForce = new Vector3(0, 0, pressedTime * 20);
            }
			pressedTime = 0f;
        }
	}
}
