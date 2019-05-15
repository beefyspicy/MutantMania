using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tranbugtest : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            //TransitionAnim.tran = true;
            StartCoroutine("loadGame");
            //SceneManager.LoadScene("ForestMap");
        }
    }

    IEnumerator loadGame()
    {
        //MenuMusicFade.musicFade = true;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("menuFinal");
    }
}
