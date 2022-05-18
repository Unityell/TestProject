using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_Reload : S_GlobalTrigger
{
    void Start()
    {
        if(CheckSignalUnits != null)
        {
            for (int i = 0; i < CheckSignalUnits.Length; i++)
            {
                CheckSignalUnits[i].MySignal += Check;
            }
        }
    }

    void Check(string Message, GameObject obj)
    {
        if(CheckSignal.ToString() == Message && IsEnabled)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            S_GameManager.Init = false;
        }
    }
}
