using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour//DOESNT WORK YET
{
    public Transform target;
    public Vector3 offset;
    public float sensitivity = 10; // чувствительность мышки
    public float limit = 1; // ограничение вращения по Y
    public float zoom = 0.25f; // чувствительность при увеличении, колесиком мышки
    public float zoomMax = 10; // макс. увеличение
    public float zoomMin = 3; // мин. увеличение
    private float X, Y, Z;
    public GameObject carCamera;
    // Start is called before the first frame update
    void Start()
    {
        //limit = Mathf.Abs(limit);
        //if (limit > 90) limit = 10;
        //offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) / 2);
        //transform.position = target.position + offset;
        carCamera = (GameObject)this.gameObject;
        X = carCamera.transform.position.x;
        Y = carCamera.transform.position.y;
        Z = carCamera.transform.position.z;
    }
    //car.transform.position += car.transform.forward* speed * Time.deltaTime;
    // Update is called once per frame
    void Update()
    {
        X = carCamera.transform.position.x;
        Y = carCamera.transform.position.y;
        Z = carCamera.transform.position.z;
        if (Input.GetKeyDown(KeyCode.C))
        {
            //transform.localEulerAngles = new Vector3(transform.position.x, transform.position.y, transform.position.z * (-1));
            //transform.position = transform.localRotation * offset + target.position;
            carCamera.transform.position = new Vector3(X, Y, Z);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            carCamera.transform.position = new Vector3(X, Y, Z);
        }
        //if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
        //else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;

        //offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

        //X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        //Y += Input.GetAxis("Mouse Y") * sensitivity;
        //Y = Mathf.Clamp(Y, -limit, limit);
        //transform.localEulerAngles = new Vector3(-Y, X, 0);
        //transform.position = transform.localRotation * offset + target.position;
    }
}
