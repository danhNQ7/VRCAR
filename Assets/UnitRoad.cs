using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitRoad : MonoBehaviour {
    private float speed = 2;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (this.transform.position.z <= -7.96)
        {
            Destroy(gameObject);
        }
	}
    
}
