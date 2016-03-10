using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
    [SerializeField]
    GameObject VictoryText;
    [SerializeField]
    GameObject LoseText;
    // Use this for initialization
    void Start () {
        int randomAdNumber = Random.Range(1, 10);

        var endGameAd = new EndGameAd();

        if (randomAdNumber > 5)
            endGameAd.ShowAd();

        if (PlayerPrefs.GetInt("Win") == 1)
            VictoryText.SetActive(true);
        else
            LoseText.SetActive(true);
    }
	
	// Update is called once per frame
	public void BackBeginning() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu Inicial");
    }
}
