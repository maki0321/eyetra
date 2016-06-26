using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class TrainScript : MonoBehaviour {
	
	public GameObject[] Train;


	void Start(){
		//int number = Train [Random.Range (0, Train.Length)];
	Instantiate(/*number*/Train[Random.Range(0,Train.Length)],transform.position,transform.rotation);
		int number = Train.Length;

	/*
	public static T Random<T>( params T[] values )
	{
		return values[ UnityEngine.Random.Range( 0, values.Length ) ];
	}
*/
	
}

}
