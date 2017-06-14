using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHourCharacterController : MonoBehaviour {

	private Rigidbody myRigidBody;
	public float speed;
	public float jumpSpeed;

	public bool isGrounded;
	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody>();
		isGrounded = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Apply a force in the direction of the key press!!!
		if(Input.GetKey(KeyCode.D))
		myRigidBody.AddForce(Vector3.right * speed,ForceMode.VelocityChange);
		
		if(Input.GetKey(KeyCode.A))
		myRigidBody.AddForce(Vector3.left * speed,ForceMode.VelocityChange);

		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			isGrounded = false;
			myRigidBody.AddForce(Vector3.up * jumpSpeed,ForceMode.VelocityChange);
		}
	}

}
