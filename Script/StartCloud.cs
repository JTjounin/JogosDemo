using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCloud : MonoBehaviour {

	public GameObject Nuvem;
	public float callCloud;
	public float repeatingCloud;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CloudPassing", callCloud,repeatingCloud);
	}
	
	// Update is called once per frame
	void Update () {

		

	}


	void CloudPassing()
	{
		Instantiate(Nuvem, transform.position, transform.rotation);
	}


}
