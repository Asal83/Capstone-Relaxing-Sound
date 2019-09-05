using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoSongsMenueScene()
    {
        SceneManager.LoadScene("SongsMenu");
    }

    //public void GotoSleepingScene()
    //{
    //    SceneManager.LoadScene("SleepingScene");
    //}
    
    

    
}
