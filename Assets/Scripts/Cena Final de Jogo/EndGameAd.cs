﻿using UnityEngine;
using UnityEngine.Advertisements;

public class EndGameAd : MonoBehaviour {
    public void ShowAd() {
        if (Advertisement.IsReady()) {
            Advertisement.Show();
        }
    }
}