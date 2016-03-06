using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptRecorde : MonoBehaviour {
    [SerializeField]
    GameObject recorde;
	// Use this for initialization
	void Update () {
        if ((UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Inicial") && (PlayerPrefs.GetFloat("pontosMax") < PlayerPrefs.GetFloat("pontos"))) {
            recorde.SetActive(true);
            recorde.GetComponent<Text>().text = "Você bateu seu recorde anterior de " + PlayerPrefs.GetFloat("pontosMax") + " pontos!";
            PlayerPrefs.SetFloat("pontosMax", PlayerPrefs.GetFloat("pontos"));
        }
        GetComponent<Text>().text = "Você fez " + PlayerPrefs.GetFloat("pontos") + " Pontos";
	}
	
}
