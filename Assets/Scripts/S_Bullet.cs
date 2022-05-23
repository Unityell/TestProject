using UnityEngine;

public class S_Bullet : MonoBehaviour
{
    [SerializeField] float BulletSpeed;
    [SerializeField] float DestroyDistantion;
    [SerializeField] GameObject Effect;
    Vector3 Target;
    Vector3 StartPos;
    bool Init;
    public void Inititalization(Vector3 NewTarget)
    {
        transform.LookAt(NewTarget, transform.up);
        StartPos = transform.position;
        Init = true;
        Target = NewTarget;
    }

    void FixedUpdate()
    {
        if(Init)
        {
            transform.position += transform.forward * BulletSpeed * Time.deltaTime;
            if(Vector3.Distance(StartPos,transform.position) > DestroyDistantion)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Death()
    {
        Instantiate(Effect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider Other)
    {
        if(Other.CompareTag("Ground"))
        {
            Death();
        }
    }
}
