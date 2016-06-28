﻿using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainScript : MonoBehaviour
{
	
	public GameObject[] Train;
	public int number;
	public Text messagetext;
	public int traincount;

	void Start ()
	{
		traincount = 5;
		number = Random.Range (0, Train.Length);
		Instantiate (Train [number], transform.position, transform.rotation);


		/*
	public static T Random<T>( params T[] values )
	{
		return values[ UnityEngine.Random.Range( 0, values.Length ) ];
	}
*/
	


	}


	public void button (int num)
	{
		 
		if (number == num) {
			Debug.Log ("正解");
			messagetext.text="正解";



		} else {
			Debug.Log ("不正解");
			messagetext.text="不正解";
		}
		traincount--;
		if (traincount == 0) {
			SceneManager.LoadScene("finish");
			
		}
	}
	public void train()
	{
		number = Random.Range (0, Train.Length);
		Instantiate (Train [number], transform.position, transform.rotation);

	}


}
