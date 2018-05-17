using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {
    public float speed;
    private bool flag = true;
    private int a = 0;
    static Vector3 pointstart;
    public GameObject road;
	// Use this for initialization
	void Start () {
        pointstart = road.transform.position + new Vector3(5f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        //if (flag)
        //{
        //    Vector3 trans = Vector3.back + Vector3.left;
        //    if (a++ % 5 == 0) flag = false;
        //    this.transform.Translate(trans * Time.deltaTime * speed);
        //}
        //else
        //{
        //    if (a++ % 5 == 0) flag = true;
        //    Vector3 trans = Vector3.back + Vector3.right;
        //    this.transform.Translate(trans * Time.deltaTime * speed);
        //}
        this.transform.Translate(Vector3.back* Time.deltaTime * speed);
        if(this.transform.position.z == -1)
        {
            GameObject _object = Instantiate(road) as GameObject;
            _object.transform.position = pointstart;
        }
    }
}
