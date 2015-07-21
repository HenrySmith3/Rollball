using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		bool jump = Input.GetKeyDown ("space");
		
		Vector3 movement = new Vector3 (moveHorizontal, jump ? 20:0, moveVertical);
		
		rb.AddForce (movement * speed);
	}
}