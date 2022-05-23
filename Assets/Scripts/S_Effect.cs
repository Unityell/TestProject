using UnityEngine;

public class S_Effect : MonoBehaviour
{   
    void Start()
    {
        Invoke(nameof(Death),0.3f);
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
