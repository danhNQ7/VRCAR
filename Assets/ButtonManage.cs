using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonManage : MonoBehaviour {
    public Slider slider;
    public float time = 3f;
    public float deltatime = 0f;
    private bool gazeAt = false;
    // Use this for initialization
    void Start () {
		
	}
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
    void Update()
    {
        if (gazeAt)
        {
            deltatime += Time.deltaTime;
            slider.value = deltatime / time;
            if (deltatime >= time) 
            {
                Debug.Log(this.name);
                if (this.name == "Start") { 
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}
                else if (this.name == "Exit")
                {
                    Debug.Log("quit");
                    Application.Quit();
                }
            }

        }
    }
}
