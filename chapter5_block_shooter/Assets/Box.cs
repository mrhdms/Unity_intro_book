using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	
	public GameObject explosionPrefab;
	
	private bool damaged;
	private float killTimer;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!damaged) return;
		killTimer -= Time.deltaTime;
		if (killTimer <= 0.0f) {
			Instantiate(explosionPrefab, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
	
	void ApplyDamage() {
		if ( !damaged ) {
			damaged = true;
			killTimer = 0.4f;
			rigidbody.AddForce(Vector3.up * 15.0f, ForceMode.Impulse);
		}
	}
}
