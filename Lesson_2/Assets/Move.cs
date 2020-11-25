using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Move : MonoBehaviour
//{
//    public GameObject player;
//    public int speed = 5;
//    public AnimationClip anima;
//    Animation an;
//    // Start is called before the first frame update
//    void Start()
//    {
//        an = GetComponent<Animation>();
//        player = (GameObject)this.gameObject;
//        an.AddClip(anima, "cubeAnimTest");
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(Input.GetKey(KeyCode.W))
//        {
//            player.transform.position += player.transform.forward * speed * Time.deltaTime;
//            an.CrossFade("cubeAnimTest");
//        }
//    }
//}
public class Move : MonoBehaviour
{
    public GameObject player;
    public int speedRotation = 3;
    public int speed = 5;
    public AnimationClip anima;
    public int jumpSpeed = 50;
    public Animation animat;

    void Start()
    {
        animat = GetComponent<Animation>();
        player = (GameObject)this.gameObject;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))//тупо вперед
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))//вперед и вправо
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
            player.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))//тупо назад
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))//тупоповорот влево
        {
            player.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))//тупо поворот вправо
        {
            player.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))//прыжок
        {
            player.transform.position += player.transform.up * jumpSpeed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))//прыжок
        {
            player.transform.position -= player.transform.up * jumpSpeed * Time.deltaTime;
        }
    }
}
