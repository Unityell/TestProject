using UnityEngine;

public class S_CameraMaster : MonoBehaviour
{
    [HideInInspector] public GameObject Target;
    [SerializeField] GameObject CameraMaster;
    [SerializeField] float CameraSpeed;
    bool Init;

    public void Initialization(GameObject NewTarget)
    {
        Target = NewTarget;
        Init = true;
    }

    void Interpolation(GameObject Obj,  Vector3 Position, float Speed)
    {
        Obj.transform.position = Vector3.Lerp(Obj.transform.position, Position, Time.deltaTime * CameraSpeed);
    }

    void LateUpdate()
    {
        if(Init)
        {
            Interpolation(CameraMaster, Target.transform.position, CameraSpeed);
            CameraMaster.transform.localEulerAngles = Vector3.Lerp(CameraMaster.transform.localEulerAngles, new Vector3(CameraMaster.transform.localEulerAngles.x, Target.transform.localEulerAngles.y, CameraMaster.transform.localEulerAngles.z), Time.deltaTime * CameraSpeed);
        }
    }
}
