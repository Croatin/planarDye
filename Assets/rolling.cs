using UnityEngine;
using System.Collections;

public class rolling : MonoBehaviour {
	
	public float rollS, rollU;
	public Rigidbody rb;
	public int directionSide, directionUp;
	public Vector3 wayToRollS = new Vector3(0,0,0);
	public Vector3 wayToRollU = new Vector3(0,0,0);
	// Use this for initialization
	void Start () 
	{
		directionSide = Random.Range(0, 2);
		directionUp = Random.Range(0, 2);
		rb = GetComponent<Rigidbody>();
		rollS = Random.Range(100.0f, 10000.0f);
		rollU = Random.Range(100.0f, 10000.0f);

		if(directionSide == 1)
			wayToRollS += Vector3.left;
		else
			wayToRollS += Vector3.right;

		if(directionUp == 1)
			wayToRollU += Vector3.up;
		else 
			wayToRollU += Vector3.down;

//		rb.AddTorque(wayToRoll * roll);
		rb.AddTorque(wayToRollS * rollS);
		rb.AddTorque(wayToRollU * rollU);
//		transform.Rotate(wayToRoll * roll);
//		Debug.Log ("Way to roll: " + wayToRoll);
//		Debug.Log ("roll: " + roll);
//		Debug.Log ("Torque: " + roll * wayToRoll);
	}

// Update is called once per frame
	void Update () {
		
	}
}

/*
 * public Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
 */