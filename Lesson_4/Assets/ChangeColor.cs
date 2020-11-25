using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Light colorfullLight;
    public float value;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        value = 0;
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        value -= Time.deltaTime * speed;
        if (value < 0)
        {
            //Debug.Log("UPDATE COLOR");
            colorfullLight.color = new Color(Random.value, Random.value, Random.value, 1000);
            value = 2;
        }

    }

    //IEnumerator ExecuteAfterTime()
    //{

    //    //yield return new WaitForSeconds(0.2f);
    //    ////сделать нужное
    //    //colorfullLight.color = new Color(Random.value, Random.value, Random.value, 1000);
    //    //Debug.Log(colorfullLight.color);
    //}
}
