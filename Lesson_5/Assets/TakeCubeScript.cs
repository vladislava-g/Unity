using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCubeScript : MonoBehaviour
{
    public int price;
    public LevelController lvlController;
    // Start is called before the first frame update
    void Start()
    {
        lvlController.GetCube();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter(Collider player)
    //{
    //    //gameObject.GetComponent<MeshRenderer>().enabled = false;
    //    //lvlController.SetScore(price);
    //    //Debug.Log("score is " + lvlController.score);
    //    //lvlController.DestroyCube();
    //    //Destroy(gameObject);

    //    //Debug.Log("CUBE TRIGGER " + player.gameObject.GetComponent<Fire>());
    //    if (player.gameObject.GetComponent<Bullet>())
    //    {
    //        lvlController.SetScore(price);
    //        lvlController.DestroyCube();
    //        Destroy(gameObject);
    //    }
    //}
}
