using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTest : MonoBehaviour
{
    public Button startBtn;
    // Start is called before the first frame update
    void Start()
    {
        startBtn = GameObject.Find("btnPlay").GetComponent<Button>();
        startBtn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        Debug.Log("You've clicked the button");
    }
}
