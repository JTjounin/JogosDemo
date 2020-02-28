using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCloud : MonoBehaviour {

	public GameObject Nuvem;
	public float callCloud;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Nuvem.gameObject.transform.position.x < callCloud)
		{
			CloudPassing();
		}

	}


	void CloudPassing()
	{
		Instantiate(Nuvem, transform.position, transform.rotation);
	}


}
