using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptMediador : MonoBehaviour {
    [SerializeField]
    GameObject botao;
    [SerializeField]
    GameObject circulo;
    [SerializeField]
    AnimationClip animacao;
    [SerializeField]
    Slider playerHealthBar;

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
        //while (rodando = lutando());
        rodando = lutando();
        if (!rodando)
        {
            Debug.Log("Perdeu");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    bool lutando()
    {
        if (time > oldtime + intervalo) //show de gambiarras
        {
            oldInstanciado = instanciado;
            instanciado = Instantiate(circulo);
            Destroy(oldInstanciado);
            oldtime = time;
        }
        else
        {
            time = time + Time.deltaTime;
        }

        if ((instanciado != null) && (instanciado.transform.localScale.x == 0.0f))
        {
            tomarDano(10.0f);
            Destroy(instanciado);
        }
        return ((playerHealthBar.value!=100) ? true : false);
    }

    public void apertarBotao()
    {
        if ((instanciado != null) && (0.05f < (instanciado.transform.localScale.x)))
            Debug.Log("Ponto = " + ( pontoDoCirculo = (1-instanciado.transform.localScale.x)*100));
        else if (instanciado != null)
            Debug.Log("Ponto = " + 100);

        pontoDoCirculo = (int) pontoDoCirculo;

        PlayerPrefs.SetFloat("pontos", PlayerPrefs.GetFloat("pontos") + pontoDoCirculo);

        Destroy(instanciado); 
    }

    void tomarDano(float dano)
    {
        playerHealthBar.value += dano;
    }
}
