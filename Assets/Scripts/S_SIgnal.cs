using UnityEngine;

public class S_SIgnal : MonoBehaviour
{
    public delegate void Signal(string Message, GameObject Object);
    public virtual event Signal MySignal;
}
