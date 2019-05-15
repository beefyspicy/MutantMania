using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            TransitionAnim.tran = true;
            StartCoroutine("loadForest");
            //SceneManager.LoadScene("ForestMap");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button8))
        {
            TransitionAnim.tran = true;
            StartCoroutine("loadTown");
            //SceneManager.LoadScene("TownMap");
        }
    }

    IEnumerator loadForest()
    {
        MenuMusicFade.musicFade = true;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("ForestMap");
    }

    IEnumerator loadTown()
    {
        MenuMusicFade.musicFade = true;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("TownMap");
    }
}
