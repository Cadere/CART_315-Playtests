﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
	public GameObject platform;
	public GameObject camera;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			GameObject clone = GameObject.Instantiate(platform, transform.position, platform.transform.rotation);

			clone.GetComponent<Rigidbody>().AddForce(camera.transform.forward*50,ForceMode.Impulse);
		}

	}
}
