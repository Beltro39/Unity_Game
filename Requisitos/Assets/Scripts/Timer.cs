using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    //public Image image;
    public float time;
    private float currentTime;
    private float currentTime1;
    private float currentTime2;

    void Start(){
        currentTime= time;

    }

    void Update(){
        if(currentTime>0){
            currentTime -= Time.deltaTime;
            currentTime1= (int)currentTime/60;
            currentTime2= (int)currentTime%60;

            txt.text= ""+ currentTime1+":"+ currentTime2;
        }
    }
}
