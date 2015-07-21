using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject following;
	public int radius;
	public float rotation;
	public float sensitivity;
	// Use this for initialization
	void Start () {
		rotation = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		rotation += Input.GetAxis ("Mouse X") * sensitivity;
		Vector3 offset = new Vector3(Mathf.Sin(rotation)*radius,-20,Mathf.Cos(rotation)*radius);
		transform.position = following.transform.position - offset;

		transform.LookAt (following.transform.position);
	}
}
