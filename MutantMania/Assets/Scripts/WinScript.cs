using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

    public GameObject cage;
    public Text winText;

    private void Start()
    {
        winText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winText.text = "YOU WIN";
        cage.SetActive(false);
        StartCoroutine("win");
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(7.5f);
        SceneManager.LoadScene("MenuFinal");
    }
}
