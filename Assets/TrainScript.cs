using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class TrainScript : MonoBehaviour {
	public GameObject[] prefabs;




	public static T Random<T>( params T[] values )
	{
		return values[ UnityEngine.Random.Range( 0, values.Length ) ];
	}
	
}

