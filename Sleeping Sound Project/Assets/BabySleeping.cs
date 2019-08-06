using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabySleeping : MonoBehaviour
{
    public void changeToMenueSongs(int BabySleepingSong)
    {
        Application.LoadLevel(BabySleepingSong);
    }
}
