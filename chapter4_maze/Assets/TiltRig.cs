using UnityEngine;
using System.Collections;

public class TiltRig : MonoBehaviour {
	
	private Vector3 accel;

	// Use this for initialization
	void Start () {
		accel = new Vector3(0, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		accel = (accel + Input.acceleration) * 0.5f;
		Vector3 gravity = new Vector3(accel.x, accel.z, accel.y);
		transform.rotation = Quaternion.FromToRotation(-Vector3.up, gravity);
	}
}
