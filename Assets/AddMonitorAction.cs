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
	void Start() {
		button = this.gameObject;
	}
	// Update is called once per frame
	void Update() {

	}

	public void addAnotherText() {
		counter++;
		var clone = Instantiate(theText, new Vector3(186 + distance, 145, 0), Quaternion.identity) as GameObject;
		clone.gameObject.transform.SetParent(theParent.transform);
		distance++;
		Text text = clone.GetComponent<Text>();
		text.text = "hello there";
		Debug.Log(theParent.transform);
	}
}
