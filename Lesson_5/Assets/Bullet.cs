using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<TakeCubeScript>())
        {
            //GetComponent<LevelController>().SetScore(price);
            //GetComponent<LevelController>().DestroyCube();
            //Destroy(collider.gameObject);

            collider.GetComponent<TakeCubeScript>().lvlController.SetScore(collider.GetComponent<TakeCubeScript>().price);
            collider.GetComponent<TakeCubeScript>().lvlController.DestroyCube();
            Destroy(collider.gameObject);
        }
    }
}
