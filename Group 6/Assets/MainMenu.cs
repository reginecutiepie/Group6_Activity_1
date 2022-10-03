using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    public GameObject videoPlayerGO;
    public VideoClip vc1;

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc1;
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
    }
}
