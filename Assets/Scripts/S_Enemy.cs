using UnityEngine;

public class S_Enemy : S_SIgnal
{
    Animator Anim;
    Rigidbody RB;
    [SerializeField] int HealthPoints;
    [SerializeField] GameObject Health;
    [SerializeField] GameObject HealthBar;
    public override event Signal MySignal;
    float HealthPointProcent;
    void Start()
    {
        Anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody>();
        HealthPointProcent = 1/(float)HealthPoints;
    }

    void OnTriggerEnter(Collider Other)
    {
        if(Other.CompareTag("Bullet"))
        {
            if(HealthPoints > 0)
            {
                HealthPoints--;
                Health.transform.localScale = new Vector3(Health.transform.localScale.x - HealthPointProcent,Health.transform.localScale.y,Health.transform.localScale.z);
                Other.GetComponent<S_Bullet>().Death();
                if(HealthPoints <= 0)
                {
                    Destroy(RB);
                    MySignal?.Invoke("Death", gameObject);
                    Anim.enabled = false;
                    Destroy(HealthBar);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if(HealthPoints > 0)
        {
            transform.LookAt(S_GameManager.Player?.transform);
        }
    }
}
