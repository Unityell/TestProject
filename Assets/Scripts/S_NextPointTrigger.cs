using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_NextPointTrigger : S_GlobalTrigger
{
    public override event Signal MySignal;
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

    void Check(string Message, GameObject Obj)
    {
        if(CheckSignal.ToString() == Message && IsEnabled)
        {
            S_GameManager.Player?.GetComponent<S_MoveComponent>().GoToPoint();
        }
    }
}
