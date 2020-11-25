using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject prefabBullet;
    public GameObject clonePosition;
    public GameObject gun;
    public float Force;
    private int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(prefabBullet);
            clone.transform.position = clonePosition.transform.position;
            clone.GetComponent<Rigidbody>().AddForce(gun.transform.forward * Force, ForceMode.Impulse);

            gun.GetComponent<AudioSource>().Play();
        }

        if (Input.GetKey(KeyCode.W))
        { gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        { gameObject.transform.Rotate(Vector3.up * 0.001f); }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        { gameObject.transform.Rotate(Vector3.down * 0.001f); }
        if (Input.GetKey(KeyCode.D))
        { gameObject.transform.Rotate(Vector3.up * 1); }
        if (Input.GetKey(KeyCode.A))
        { gameObject.transform.Rotate(Vector3.down * 1); }
        if (Input.GetKey(KeyCode.S))
        { gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime; }
    }
}
