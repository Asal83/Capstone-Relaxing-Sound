using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
   public void changeToFocusScene(int FocusScenceSong)
    {
        Application.LoadLevel(FocusScenceSong);
    }
}
