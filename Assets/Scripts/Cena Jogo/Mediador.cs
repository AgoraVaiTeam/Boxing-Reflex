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
    [SerializeField]
    Animation fadeAnimation;
    [SerializeField]
    AudioSource fadeSound;

    float pontosDoJogador;
    float pontoDoCirculo;

    bool paused;

    bool rodando;

    bool acabou = false;
    void Start()
    {
		Time.timeScale = 1;
 
        paused = false;
        PlayerPrefs.SetFloat("pontos", 0);
    }

    void Update()
    {
        if (!Lutando())
        {
            if (playerHealthBar.value == playerHealthBar.maxValue) {
                PlayerPrefs.SetInt("Win", 0);
                //Debug.Log("perdeu");
            }
            else {
                //Debug.Log("Venceu");
                PlayerPrefs.SetInt("Win", 1);
            }
            if (!acabou) {
                fadeAnimation.Play();
                acabou = true;
            }
            //fadeSound.Play();
            GetComponent<AudioSource>().Pause();
            //UnityEngine.SceneManagement.SceneManager.LoadScene("Final do Jogo");
        }
        //mostraPontos();
    }

    //void mostraPontos() {
    //    mostradorPontos.GetComponent<Text>().text = string.Format("{0} pontos", PlayerPrefs.GetFloat("pontos"));
    //}
    bool Lutando()
    {
        return !((playerHealthBar.value >= playerHealthBar.maxValue) || (inimigoHealthBar.value >= inimigoHealthBar.maxValue));
    }


    //-------------------------------------------- Botões pause e afins-------------   
    public void PauseButton()
    {
        paused = !paused;
        canvasGame.SetActive(!paused);
        canvasPause.SetActive(paused);
        Time.timeScale = paused ? 0 : 1; //para o tempo do jogo quando o jogo está pausado
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
