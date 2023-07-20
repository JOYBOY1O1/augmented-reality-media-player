using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class functions : MonoBehaviour
{
    public GameObject videocube1;
    private VideoPlayer video1;
    public GameObject VirtualButton1;
    public GameObject buttoncolor;

    private VirtualButtonBehaviour VB_behaviour1;
 

    private void Start()
    {
        video1 = videocube1.GetComponent<VideoPlayer>();
        VB_behaviour1 = VirtualButton1.GetComponent<VirtualButtonBehaviour>();
        VB_behaviour1.RegisterOnButtonPressed(playvideo1);

    }

    public void playvideo1(VirtualButtonBehaviour vp)
    {
       
        if (!video1.isPlaying)
        {
            video1.Play();
            buttoncolor.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            video1.Pause();
            buttoncolor.GetComponent<Renderer>().material.color = Color.green;
        }
    }

}