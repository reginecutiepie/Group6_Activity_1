using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class gameoverscene : MonoBehaviour
{

    public GameObject videoPlayerGO;
    public VideoClip loservid;

    public void backTofightinggame()
    {
        SceneManager.LoadScene(1);
    }

    public void backTomenu()
    {
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
