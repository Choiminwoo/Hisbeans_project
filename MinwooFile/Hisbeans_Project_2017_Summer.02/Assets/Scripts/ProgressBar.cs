using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour {

    private bool gazedAt = false;
    private float gazedTime = 2.0f;
    private float timer = 0.0f;
    private Slider slider = null;

    public Slider slide;
    
	void Start ()
    {

        slider = GetComponent<Slider>();
        slider.value = 0;
        //slide = GameObject.Find("Popup_Slider").GetComponent<Slider>();
    }
	
	
	void Update ()
    {
        
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if(slider.value >= 1.0f)
            {
                
               
                SceneManager.LoadScene(1);
                timer = 0.0f;

            }
        }
        else
        {
            timer = 0.0f;
        }
       
            slider.value = timer / gazedTime;
      }

    public void PointerEnter()
    {
        gazedAt = true; 
        //Debug.Log("Hello");

    }

    public void PointerExit()
    {
        gazedAt = false;
        //Debug.Log("Bye");
    }
}

   