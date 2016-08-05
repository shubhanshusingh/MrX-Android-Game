using UnityEngine;
using System.Collections;

public class ZombieRunningScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
	void FixedUpdate()
	{
		//Vector3 zombieTransform = transform.localPosition;
		//zombieTransform = zombieTransform - Vector3.left;
		//transform.Translate (zombieTransform);
		//transform.position += Vector3.left * Time.deltaTime;
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (-3f, 0);
	}}
