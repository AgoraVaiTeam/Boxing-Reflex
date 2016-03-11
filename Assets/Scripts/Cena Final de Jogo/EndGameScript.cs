using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
    [SerializeField]
    GameObject VictoryText;
    [SerializeField]
    GameObject LoseText;
    [SerializeField]
    GameObject EndGameAd;
    [SerializeField]
    GameObject Easter;

    // Use this for initialization
    void Start() {
        int randomAdNumber = Random.Range(1, 10);
        float randomEasterNumber = Random.Range(0.0f, 100.0f);

        if (randomEasterNumber > 99.9) {
            Easter.SetActive(true);
            return;
        }
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
