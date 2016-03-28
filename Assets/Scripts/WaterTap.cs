using UnityEngine;
using System.Collections;

public class WaterTap : MonoBehaviour {

	public GameObject waterParticle;

	private int count = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnWater", 0, 0.01f);
	}

	public void SpawnWater() {
		GameObject w = Instantiate (waterParticle);
		w.transform.parent = transform;
		float x = Random.Range (-300, 300) / 100f;
		w.transform.position = w.transform.position + new Vector3(x, 0, 0);
		count++;
		if (count > 2000) {
			CancelInvoke ();
		}
	}
}
