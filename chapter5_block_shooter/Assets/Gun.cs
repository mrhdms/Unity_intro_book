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
			
			Vector3 screenPoint = Input.mousePosition;
			screenPoint.z = 10.0f;
			
			Vector3 worldPoint = camera.ScreenToWorldPoint(screenPoint);
			Vector3 direction = (worldPoint - transform.position).normalized;
			bullet.rigidbody.velocity = direction * initialVelocity;
		}
	}
}
