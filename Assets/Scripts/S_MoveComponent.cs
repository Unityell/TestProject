using UnityEngine;
using UnityEngine.AI;

public class S_MoveComponent : MonoBehaviour
{
    [HideInInspector] public Transform[] Positions;
    NavMeshAgent Agent;
    int Number;
    S_Player Player;
    bool Init;
    Animator Anim;
    public void Initialization(S_Player Master)
    {
        Anim = GetComponent<Animator>();
        Player = Master;
        Agent = GetComponent<NavMeshAgent>();
    }

    public void GoToPoint()
    {
        if(Number < Positions.Length)
        {
            Number++;
            Agent.SetDestination(Positions[Number].position);
        }
    }
    
    void FixedUpdate()
    {
        if(Vector3.Distance(Player.transform.position, Positions[Number].position) > 0.5f)
        {
            Anim.SetInteger("State", 1);
        }
        else
        {
            Anim.SetInteger("State", 0);
        }
    }
}
