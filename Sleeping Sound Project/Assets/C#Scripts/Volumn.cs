using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volumn : MonoBehaviour
{
    private AudioSource song;
    private float musicVol = 1f;
    // Start is called before the first frame update
    void Start()
    {
        song = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        song.volume = musicVol;
        
    }
    public void setVolumn(float vol)
    {
        musicVol=vol;
    }
}
