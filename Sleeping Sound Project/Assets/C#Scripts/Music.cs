using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Music : MonoBehaviour
{
    public AudioSource sound;
   
    public void StopSong(float playTime)
    {
        Invoke("stopAudio", playTime);
    }
    public void StopSong2(float PlayTime2)
    {
        Invoke("stopAudio", PlayTime2);
    }
    public void StopSong3(float PlayTime3)
    {
        Invoke("stopAudio", PlayTime3);
    }
    public  void stopAudio()
    {
        sound.Stop();
    }
    
        
        
       
    
}
