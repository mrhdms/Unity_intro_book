using UnityEngine;
using System.Collections;

public class BoxGenerator : MonoBehaviour {
	
	public float interval;
	public GameObject redBoxPrefab;
	public GameObject blueBoxPrefab;
	
	private bool nextIsRed;
	private float timer;

	// Use this for initialization
	void Start () {
		nextIsRed = true;
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if ( timer < 0.0f ) {
			GameObject prefab = nextIsRed ? redBoxPrefab : blueBoxPrefab;
			Instantiate( prefab, transform.position, transform.rotation );
			
			timer = interval;
			nextIsRed = !nextIsRed;
		}
	}
}
