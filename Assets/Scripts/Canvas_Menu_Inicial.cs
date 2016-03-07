using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Canvas_Menu_Inicial : MonoBehaviour {
    [SerializeField]
    GameObject textoRecorde;
    [SerializeField]
    GameObject textoPontuacao;



    public void Start()
    {
        if (PlayerPrefs.GetFloat("Recorde") < PlayerPrefs.GetFloat("pontos"))
        {
            PlayerPrefs.SetFloat("Recorde", PlayerPrefs.GetFloat("pontos"));
            textoRecorde.SetActive(true);
        }
        textoPontuacao.GetComponent<Text>().text = "você fez "+ PlayerPrefs.GetFloat("pontos") + " pontos";
    }


	// Use this for initialization
    public void carregaFase()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
