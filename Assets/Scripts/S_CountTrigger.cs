using UnityEngine;

public class S_CountTrigger : S_GlobalTrigger
{
    public override event Signal MySignal;
    [SerializeField] int TheRightNumberOfSignals;
    int Number;
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
            Number++;
            if(Number >= TheRightNumberOfSignals)
            {
                MySignal?.Invoke("Maximum", gameObject);
            }
        }
    }
}
