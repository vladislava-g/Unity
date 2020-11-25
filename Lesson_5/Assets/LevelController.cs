using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int cubeCount;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetCube()
    {
        cubeCount++;
        Debug.Log("cube count: " + cubeCount);
    }
    public void DestroyCube()
    {
        cubeCount--;
        if (cubeCount == 0)
        {
            Debug.Log("You have finished the game! Your Score: " + score);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    public void SetScore(int count)
    {
        score += count;
    }
}
