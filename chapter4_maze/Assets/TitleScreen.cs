using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	
	public GUIStyle labelStyle;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel("meiro");
		}
	}
	
	void OnGUI () {
		int sw = Screen.width;
		int sh = Screen.height;
		GUI.Label(new Rect(0, sh / 4, sw, sh / 4), "BALL MAZE", labelStyle);
		GUI.Label(new Rect(0, sh / 2, sw, sh / 4), "Hit Space Key", labelStyle);
	}
}
