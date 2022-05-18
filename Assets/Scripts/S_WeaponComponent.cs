using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_WeaponComponent : MonoBehaviour
{
    Camera Cam;
    RaycastHit hit;
    Ray ray;
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform ShootPoint;
    S_Player Master;
    int Reserv;

    void Start()
    {
        Cam = Camera.main;
        Master = GetComponentInParent<S_Player>();
    }

    void CreateBullet(Vector3 Position)
    {
        var NewBullet = Instantiate(Bullet, ShootPoint.position + Vector3.up, Quaternion.identity);
        NewBullet.GetComponent<S_Bullet>().Inititalization(Position);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Reserv > 0)
            {
                ray = Cam.ScreenPointToRay(Input.mousePosition);

                Physics.Raycast(ray, out hit);

                CreateBullet(hit.point);
            }
            else
            {
                Reserv++;   
            }
        }
    }
}
