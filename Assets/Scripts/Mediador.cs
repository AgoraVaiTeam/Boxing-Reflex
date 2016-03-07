using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mediador : MonoBehaviour {
    [SerializeField]
    GameObject botao;
    [SerializeField]
    GameObject circulo;
    //[SerializeField]
    //GameObject circulo_10percent;
    [SerializeField]
    AnimationClip animacao;
    [SerializeField]
    Slider playerHealthBar;
    [SerializeField]
    Text mostradorPontos;
    [SerializeField]
    GameObject mediadorAtaque;

    float time = 0;
    float oldtime;
    public float intervalo;

    GameObject instanciado;
    GameObject oldInstanciado;

    float pontosDoJogador;
    float pontoDoCirculo;

    bool rodando;

    void Start () {
        time = 0;
        oldtime = 0;
        PlayerPrefs.SetFloat("pontos", 0);
    }

	void Update () {
        if (!lutando())
        {
            Debug.Log("Perdeu");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
            mediadorAtaque.SetActive(true);
        mostraPontos();
    }

    void mostraPontos()
    {
        mostradorPontos.GetComponent<Text>().text = PlayerPrefs.GetFloat("pontos") + " pontos";
    }

    bool lutando()
    {
        //if (time > oldtime + intervalo) //show de gambiarras ou (instanciado == null)
        //{
        //    oldInstanciado = instanciado;
        //    instanciado = Instantiate(circulo);
        //    Destroy(oldInstanciado);
        //    oldtime = time;
        //}
        //else
        //    time = time + Time.deltaTime;


        //if ((instanciado != null) && (instanciado.transform.localScale.x == 0.0f))
        //{
        //    tomarDano(10.0f);
        //    Destroy(instanciado);
        //}


        return ((playerHealthBar.value!=100) ? true : false);
    }

    public void apertarBotao()
    {
        if (instanciado != null)
        {
            float tamanhoCirculo = instanciado.GetComponent<ScriptCirculo>().pegaTamanho();
            if (0.05f < tamanhoCirculo)
                Debug.Log("Ponto = " + (pontoDoCirculo = (1 - tamanhoCirculo) * 100));
            else if (instanciado != null)
            {
                Debug.Log("Ponto = " + 100);
                tamanhoCirculo = 300;
            }
            pontoDoCirculo = (int) pontoDoCirculo;
            PlayerPrefs.SetFloat("pontos", PlayerPrefs.GetFloat("pontos") + pontoDoCirculo);
            Destroy(instanciado);
        }
    }

    void tomarDano(float dano)
    {
        playerHealthBar.value += dano;
    }
}
