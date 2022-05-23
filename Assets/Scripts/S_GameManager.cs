using UnityEngine;

public class S_GameManager : MonoBehaviour
{
    public static GameObject Player;
    public static bool Init;
    [SerializeField] GameObject Text;

    void Update()
    { 
        if(Input.GetMouseButtonDown(0))
        {
            if(!Init)
            {
                Init = true;
                Player.GetComponent<S_MoveComponent>().GoToPoint();
                Text.SetActive(false);
            }
        }
    }
}
