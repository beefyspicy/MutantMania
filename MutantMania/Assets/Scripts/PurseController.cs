using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurseController : MonoBehaviour
{

    public GameObject smallPurse;
    public GameObject mediumPurse;
    public GameObject largePurse;
	
	void Update ()
    {
        if (CoinPickup.coins <= 15)
        {
            smallPurse.SetActive(true);
            mediumPurse.SetActive(false);
            largePurse.SetActive(false);
        }
        if (CoinPickup.coins > 15 && CoinPickup.coins < 50)
        {
            mediumPurse.SetActive(true);
            smallPurse.SetActive(false);
            largePurse.SetActive(false);
        }
        if (CoinPickup.coins >= 50)
        {
            largePurse.SetActive(true);
            smallPurse.SetActive(false);
            mediumPurse.SetActive(false);
        }
    }
}
