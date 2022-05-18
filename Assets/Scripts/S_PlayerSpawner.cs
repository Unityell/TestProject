using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PlayerSpawner : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] S_WayPointSystem WayPointSystem;
    [SerializeField] int SelectPointNumberForPlayerStart;
    void Start()
    {
        if(Player != null)
        {
            var NewPlayer = Instantiate(Player,WayPointSystem.Points[SelectPointNumberForPlayerStart].position, transform.rotation);
            S_GameManager.Player = NewPlayer;
            NewPlayer.GetComponent<S_MoveComponent>().Positions = WayPointSystem.Points;
            NewPlayer.GetComponent<S_Player>().Initialization();
            Destroy(gameObject);
        }
    }
}
