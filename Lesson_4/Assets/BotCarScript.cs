using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCarScript : MonoBehaviour
{
    float speed = 0.3f;
    int sizeX, sizeY, sizeZ = 1;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("botcar " + gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * speed * -1 );
        //gameObject.transform.position += new Vector3(0, Input.GetAxis("Vertical") * speed * -1, 0 );
    }
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("COLLISION");
    }
    void OnTriggerEnter(Collider player)
    {
        //Debug.Log("TRIGGER " + player.gameObject.GetComponent<CarScript>().car);
        //Destroy(gameObject);

        //gameObject.SetActive(false);
        if (player.gameObject.GetComponent<CarScript>())
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.GetComponent<CarScript>())
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
