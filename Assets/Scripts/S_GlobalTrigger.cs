using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GlobalTrigger : S_SIgnal
{
    public bool IsEnabled;
    public S_SIgnal[] CheckSignalUnits;
    public enum EnumCheck
    {
        Nothing,
        Death,
        Maximum,
        Enter,
        Exit
    }
    public EnumCheck CheckSignal;
}
