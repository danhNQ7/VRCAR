using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road :SomeThing {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    new bool Destroy()
    {
        if (this.transform.position.z <= Variables.minZ)
        {
            Vector3 temp = this.transform.position;
            temp.z = Variables.maxZ;
            this.transform.position = temp;
        }
        return false;
    }
    void Update () {
        base.Update_frame();
        Destroy();
	}
}
