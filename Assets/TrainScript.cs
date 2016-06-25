using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class TrainScript : MonoBehaviour {
	
	public GameObject[] Train;

	void Start(){
	Instantiate(Train[Random.Range(0,Train.Length)],transform.position,transform.rotation);
	/*
	public static T Random<T>( params T[] values )
	{
		return values[ UnityEngine.Random.Range( 0, values.Length ) ];
	}
*/
	
}

}
