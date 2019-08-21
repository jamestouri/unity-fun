using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddMonitorAction : MonoBehaviour {
	private int counter = 0;
	private int distance = 0;
	public GameObject theText;
	public GameObject theParent;
	private GameObject button;
	private int x;
	private int y;
	private int z;
	void Start() {
		button = this.gameObject;
	}
	// Update is called once per frame
	void Update() {

	}

	public void addAnotherText() {
		counter++;
		var clone = Instantiate(theText, new Vector3(186, 145, 0),
		  Quaternion.identity, theParent.transform) as GameObject;

		distance = distance + 100;
		clone.transform.Translate(distance, 145, 0);
		Text text = clone.GetComponent<Text>();
		text.text = "hello there";
		Debug.Log(theParent.transform);
	}
}
