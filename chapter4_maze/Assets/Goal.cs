using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	
	private int ballCount;
	private int counter;
	private bool cleared;
	
	public GUIStyle labelStyle;
	
	// Use this for initialization
	void Start () {
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
		cleared = false;
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Ball") {
			counter++;
			if (cleared == false && counter == ballCount) {
				cleared = true;
				StartCoroutine("clear");
			}
		}
	}
	
	IEnumerator clear() {
		yield return new WaitForSeconds(2.0f);
		Application.LoadLevel("title");
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Ball") {
			counter--;
		}
	}
	
	void OnGUI () {
		if (cleared == true) {
			int sw = Screen.width;
			int sh = Screen.height;
			GUI.Label(new Rect(sw / 6, sh / 3, sw * 2 / 3, sh / 3), "CLEARED!!", labelStyle);
		}
	}
}
