using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureSound : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeToNatureSoundScene(int NatureScenceSong)
    {
        Application.LoadLevel(NatureScenceSong);
    }
}
