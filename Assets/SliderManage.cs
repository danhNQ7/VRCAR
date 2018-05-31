using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderManage : MonoBehaviour {

    // Use this for initialization
    public float  time = 3f;
    public float deltatime = 0f;
    private Slider slider;
    private bool gazeAt = false;
	void Start () {
        slider = this.GetComponent<Slider>();
	}
	
	// Update is called once per frame
    public void PointerEnter()
    {
        Debug.Log("input");
        gazeAt = true;
    }
    public void PointerExit()
    {
        Debug.Log("EXit");
        gazeAt = false;
        slider.value = 0;
        deltatime = 0;
    }
	void Update () {
		if (gazeAt)
        {
            deltatime += Time.deltaTime;
            slider.value = deltatime / time;
            if (deltatime >= time)
            {
                Debug.Log("Chuyen canh");
            }

        }
	}
}
