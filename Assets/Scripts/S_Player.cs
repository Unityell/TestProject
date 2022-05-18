using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Player : MonoBehaviour
{
    [HideInInspector] public S_MoveComponent MoveComponent;
    bool Init;

    public void Initialization()
    {
        Camera.main.GetComponent<S_CameraMaster>().Initialization(gameObject);
        if(GetComponent<S_MoveComponent>())
        {
            MoveComponent = GetComponent<S_MoveComponent>();
            MoveComponent.Initialization(this);
        }
    }
}
