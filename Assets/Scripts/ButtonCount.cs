using UnityEngine;
using System.Collections;

public class ButtonCount : MonoBehaviour {

	public GameObject gb;
	public int buttonNumber;

	public void Answer () {
		//Debug.Log (buttonNumber);
		Debug.Log (gb.GetComponent<TrainScript> ().number);
//		TrainScript num = GetComponent<TrainScript> ();
		if (buttonNumber == gb.GetComponent<TrainScript> ().number) {
			Debug.Log ("正解");
		} else {
			Debug.Log ("不正解");
		}
			
	
}
}

