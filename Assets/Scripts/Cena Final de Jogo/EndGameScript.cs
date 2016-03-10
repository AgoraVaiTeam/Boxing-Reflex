using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
    [SerializeField]
    GameObject VictoryText;
    [SerializeField]
    GameObject LoseText;
    // Use this for initialization
    void Start () {
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
