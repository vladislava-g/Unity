using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotsController : MonoBehaviour
{
    
    #region paths
    public GameObject[] path1;
    public GameObject[] path2;
    public GameObject[] path3;
    public GameObject[] path4;
    public GameObject[] path5;
    public GameObject[] path6;
    #endregion
    private List<GameObject[]> allPaths;
    public List<RedBot> bots;
    #region for timer
    private float timeFlag;
    private float pause;
    #endregion
    RedBot newBot;
    public GameObject startQuad;
    int i_Path = 0;
    int i_Bots = 0;

    void Awake()
    {
        pause = 2;
        allPaths = new List<GameObject[]> { path1, path2, path3, path4, path5, path6 };
        bots[0].pathParts = allPaths[0];
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!bots[0]) bots.Remove(bots[0]);
        
        if(timeFlag + pause <= Time.time)
        {
            timeFlag = Time.time;
            newBot = Instantiate(bots[0], startQuad.transform.position, Quaternion.identity);
            bots.Add(newBot);
            newBot.pathParts = allPaths[++i_Path];
            if (i_Path == 5) i_Path = -1;
        }
        

        
    }
}
