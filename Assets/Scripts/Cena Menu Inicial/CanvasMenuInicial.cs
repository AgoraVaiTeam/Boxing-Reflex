using UnityEngine;
using UnityEngine.UI;

public class CanvasMenuInicial : MonoBehaviour {
    [SerializeField]
    GameObject textoRecorde;
    [SerializeField]
    GameObject textoPontuacao;



    public void Start() {
        if (PlayerPrefs.GetFloat("Recorde") < PlayerPrefs.GetFloat("pontos")) {
            PlayerPrefs.SetFloat("Recorde", PlayerPrefs.GetFloat("pontos"));
            textoRecorde.SetActive(true);
        }
        textoPontuacao.GetComponent<Text>().text = string.Format("Você fez {0} pontos", PlayerPrefs.GetFloat("pontos"));
    }

    // Use this for initialization
    public void CarregaFase() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
