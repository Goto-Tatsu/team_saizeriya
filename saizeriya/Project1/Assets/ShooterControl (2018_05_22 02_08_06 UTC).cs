using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterControl : MonoBehaviour {

	public GameObject bullet;
	public float Rapid;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			Instantiate (bullet, transform.position, transform.rotation);
			yield return new WaitForSeconds(Rapid);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
