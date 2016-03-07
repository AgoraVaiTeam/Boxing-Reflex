using UnityEngine;
using UnityEngine.UI;

public class Mediador : MonoBehaviour {
    [SerializeField]
    Slider playerHealthBar;
    [SerializeField]
    Slider inimigoHealthBar;
    [SerializeField]
    Text mostradorPontos;

    float pontosDoJogador;
    float pontoDoCirculo;

    bool rodando;

    void Start() {
        PlayerPrefs.SetFloat("pontos", 0);
    }

    void Update() {
        if (!lutando()) {
            if (playerHealthBar.value <= 100)
                Debug.Log("Venceu");
            else
                Debug.Log("perdeu");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        mostraPontos();
    }

    void mostraPontos() {
        mostradorPontos.GetComponent<Text>().text = PlayerPrefs.GetFloat("pontos") + " pontos";
    }
    bool lutando() {
        return !((playerHealthBar.value >= 100) || (inimigoHealthBar.value >= 100));
    }
}
