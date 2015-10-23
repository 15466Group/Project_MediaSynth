using UnityEngine;
using System.Collections;
using System;

public class PlanetRotations : MonoBehaviour {

	private Quaternion rot;
	private float smooth;

	// Use this for initialization
	void Start () {
		rot = Quaternion.identity;
		smooth = 200.0f;
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform orbiting in transform) {
			orbiting.RotateAround(orbiting.position, orbiting.up, smooth * Time.deltaTime);
		}
	}
}
