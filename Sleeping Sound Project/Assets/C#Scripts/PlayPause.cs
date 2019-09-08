using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour
{
    public Text MyText;
    bool status = true;
    public VideoPlayer VideoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        status = true;
    }
    public void PlayAndPause()
    {
        status = !status;
        if (status == true)
        {
            MyText.text = "Play";
            VideoPlayer.Play();
        }
        else
        {
            MyText.text = "Pause";
            VideoPlayer.Pause();
        }
    }



        








    
   
    void Update()
    {
        
    }
}
