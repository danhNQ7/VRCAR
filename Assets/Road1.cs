using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road1: MonoBehaviour {

    // Use this for initialization
    private List<GameObject> activityRoad;
    public GameObject road;
    private float lenT = 1.99f;
	void Start () {
        activityRoad = new List<GameObject>();
        InnitRoad(new Vector3(0, 0, 0));
        for (int i = 0;i < 9; i++)
        {
            InnitRoad(activityRoad[activityRoad.Count - 1].transform.position);
        }
	}
	void InnitRoad(Vector3 lastpoint = new Vector3())
    {
        GameObject go;
        go = Instantiate(road) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = lastpoint + Vector3.forward * lenT;
        activityRoad.Add(go);
    }
	// Update is called once per frame
	void Update () {
        if (activityRoad[0]== null && !ReferenceEquals(activityRoad[0],null))
        {
            InnitRoad(activityRoad[activityRoad.Count - 1].transform.position-new Vector3(0,0,0.1f));
            activityRoad.RemoveAt(0);
        }
	}
}
