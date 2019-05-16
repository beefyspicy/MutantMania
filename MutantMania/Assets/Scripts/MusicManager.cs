using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    public GameObject music;

    private void Start()
    {
        music = GameObject.Find("MusicM");
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (music == null)
        {
            music = this.gameObject;
            music.name = "MusicM";

            DontDestroyOnLoad(gameObject);
        }
        else if (this.gameObject.name != "MusicM")
        {
            Destroy(gameObject);
        }



        if (sceneName == "MenuFinal")
        {
            Destroy(gameObject);
        }
    }
}
