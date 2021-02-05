using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour {


	// Use this for initialization
	private void OnJointBreak(float BreakForce)
    {
		Debug.Log("You destory " + name + "with a force" + BreakForce);
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
