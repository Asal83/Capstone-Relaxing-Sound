using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeepsleepingScence : MonoBehaviour
{
    

    // Update is called once per frame
   public void changeScene1(int  button1changeScene)

    {
        Application.LoadLevel(button1changeScene);
    }
}
