using UnityEngine;

public class S_AreaTrigger : S_SIgnal
{
    [SerializeField] bool IsEnabled;
    public override event Signal MySignal;

    void OnTriggerEnter(Collider Other)
    {
        if(Other.CompareTag("Player") && IsEnabled)
        {
            MySignal?.Invoke("Enter", Other.gameObject);
        }
    }
    void OnTriggerExit(Collider Other)
    {
        if(Other.CompareTag("Player") && IsEnabled)
        MySignal?.Invoke("Exit", Other.gameObject);
    }
}
