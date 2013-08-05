using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public GameObject bulletPrefub;
	public float initialVelocity; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject bullet = (GameObject)Instantiate(bulletPrefub, transform.position, transform.rotation);
			Vector3 direction = transform.forward;
			bullet.rigidbody.velocity = direction * initialVelocity;
		}
	}
}
