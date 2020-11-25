using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    Vector3 vector;
    public GameObject car;
    public int speed;
    void Awake()//starts first 
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        car = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z - speed);
            car.transform.position += car.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            car.transform.Rotate(Vector3.up * 0.001f);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            car.transform.Rotate(Vector3.down * 0.001f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            car.transform.Rotate(Vector3.up * 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            car.transform.Rotate(Vector3.down * 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z + speed);
            car.transform.position -= car.transform.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            car.transform.Rotate(Vector3.right * 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            car.transform.Rotate(Vector3.left * 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            car.transform.Rotate(Vector3.up * 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            car.transform.Rotate(Vector3.down * 1);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            car.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            car.GetComponent<AudioSource>().Stop();
        }
    }
}
