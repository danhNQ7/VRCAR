using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player");
        Debug.Log(other.name);
        if (other.tag == "obstacle")
        {
            Debug.Log("Trung cmnr");
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
