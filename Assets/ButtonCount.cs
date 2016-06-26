using UnityEngine;
using System.Collections;

public class ButtonCount : MonoBehaviour {


	public int buttonNumber;

	public void Answer () {
		Debug.Log (buttonNumber);
		TrainScript number = GetComponent<TrainScript> ();
		if (buttonNumber == number){
			GUI.Label(new Rect(20, 20, 100, 50), "正解");
			
	}
}
}

