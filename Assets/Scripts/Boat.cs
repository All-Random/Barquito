using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D Hit)
	{
		//print(Hit.name);
		gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2(0f,(gameObject.GetComponent<Rigidbody2D>().velocity.y*-3)+2.5f));
	}
}
