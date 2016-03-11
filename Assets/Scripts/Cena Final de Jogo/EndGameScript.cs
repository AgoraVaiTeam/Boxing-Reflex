﻿using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
    [SerializeField]
    GameObject VictoryText;
    [SerializeField]
    GameObject LoseText;
    [SerializeField]
    GameObject EndGameAd;

    // Use this for initialization
    void Start() {
        int randomAdNumber = Random.Range(1, 10);

        if (PlayerPrefs.GetInt("Win") == 1)
            VictoryText.SetActive(true);
        else {
            if (randomAdNumber > 5)
                EndGameAd.GetComponent<EndGameAd>().ShowAd();
            LoseText.SetActive(true);
        }
    }

    // Update is called once per frame
    public void BackBeginning() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu Inicial");
    }
}
