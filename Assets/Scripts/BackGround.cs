using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : SomeThing {

	// Use this for initialization
	void Start () {
		
	}
	new void Destroy()
    {
        if (this.transform.position.z <= Variables.minZ)
        {
            Vector3 pos = this.transform.position;
            pos.z = Variables.maxBGZ;
            this.transform.position = pos;
        }
    }
	// Update is called once per frame
	void Update () {
        Update_frame();
        Destroy();
	}
}
