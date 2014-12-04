using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	
	public GameObject obj;
	public float spawnMin=1f;
	public float spawnMax=2f;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn()
	{
		
		Instantiate (obj, transform.position, Quaternion.identity);
		Invoke ("Spawn",3f);
		
	}
	
}
