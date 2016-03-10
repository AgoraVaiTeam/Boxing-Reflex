using UnityEngine;
using UnityEngine.UI;

public class Mediador : MonoBehaviour
{
    [SerializeField]
    Slider playerHealthBar;
    [SerializeField]
    Slider inimigoHealthBar;
    [SerializeField]
    Text mostradorPontos;
    [SerializeField]
    GameObject canvasGame;
    [SerializeField]
    GameObject canvasPause;

    float pontosDoJogador;
    float pontoDoCirculo;

    bool paused;

    bool rodando;

    void Start()
    {
        paused = false;
        PlayerPrefs.SetFloat("pontos", 0);
    }

    void Update()
    {
        if (!Lutando())
        {
            if (playerHealthBar.value <= 100)
                Debug.Log("Venceu");
            else
                Debug.Log("perdeu");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        //mostraPontos();
    }

    //void mostraPontos() {
    //    mostradorPontos.GetComponent<Text>().text = string.Format("{0} pontos", PlayerPrefs.GetFloat("pontos"));
    //}
    bool Lutando()
    {
        return !((playerHealthBar.value >= 100) || (inimigoHealthBar.value >= 100));
    }


    //-------------------------------------------- Botões pause e afins-------------   
    public void PauseButton()
    {
        canvasGame.SetActive(!paused);
        canvasPause.SetActive(paused);
        paused = !paused;
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BeginningButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu Inicial");
    }
}
