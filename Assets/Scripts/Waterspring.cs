using UnityEngine;
using System.Collections;

public class Waterspring : MonoBehaviour {

	public float height, position, velocity, targetHeight;
	public void Update()
	{
		const float k = 0.025f; // adjust this value to your liking
		float x = height - targetHeight;
		float acceleration = -k * x;

		position += velocity;
		velocity += acceleration;
	}
}
