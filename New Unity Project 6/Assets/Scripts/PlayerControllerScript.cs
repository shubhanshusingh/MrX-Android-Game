using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {
	public static int index=0;
	Animator animator;
	bool jump;
	// =null;
	// Use this for initialization
	void Start () {

		animator=GetComponent<Animator> ();
		jump = false;
		//animator.SetBool ("IsJumping", false);
	}
	
	// Update is called once per frame
    
	void Update () 
	{
//				if (Input.GetKey (KeyCode.Space)) 
//				{
//
//						animator.SetBool ("IsJumping", true);
//						jump = true;
//				}
//				else
//				{
//						animator.SetBool ("IsJumping", false);
//						jump = false;
//						//animator.SetBool ("IsJumping", false);
//				}
//				int i = 0;
//				while (i < Input.touchCount) {
//						if (Input.GetTouch (i).phase == TouchPhase.Ended)
//						{
//								animator.SetBool ("IsJumping", true);
//								jump=false;
//
//						}
//						else
//						{    
//								animator.SetBool ("IsJumping", false);
//								jump = false;
//						}
//
//						++i;}
	}
	void OnGUI()
	{
		//GUI.Box(new Rect(10,10,100,50),"Score:");

	}
	void FixedUpdate()
	{
				
	}
	void LateUpdate()
	{//
		Vector3 PlayerJumpVector = transform.localScale;
		Debug.Log (PlayerJumpVector.ToString ()+ "intial vector");
		int i = 0;
		if (Input.GetKey ("space")) {
			animator.SetBool ("IsJumping", true);
				PlayerJumpVector.y = PlayerJumpVector.y + 0.5f;
				transform.localPosition = transform.localPosition + PlayerJumpVector;
			PlayerJumpVector = PlayerJumpVector + Vector3.up;
			transform.Translate(PlayerJumpVector);
			Debug.Log (PlayerJumpVector.ToString ()+ "after jump vector");
		}

		while (i < Input.touchCount) {
			if (Input.GetTouch (i).phase == TouchPhase.Began)
			{
				animator.SetBool ("IsJumping", true);
				PlayerJumpVector = PlayerJumpVector + Vector3.up;
				transform.Translate(PlayerJumpVector);
				Debug.Log (PlayerJumpVector.ToString ()+ "after jump vector");
				PlayerJumpVector.y = PlayerJumpVector.y + 0.5f;
					transform.localPosition = transform.localPosition + PlayerJumpVector;
			}
			
			++i;}
		
		
		
	}
}
