using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MedAtaque : MonoBehaviour {
    [SerializeField]
    GameObject circuloAtaqueDireita;
    [SerializeField]
    GameObject circuloAtaqueEsquerda;
    [SerializeField]
    Slider playerHealthBar;
    [SerializeField]
    Slider inimigoHealthBar;

    float time = 0;
    float oldtime = 0;
    public float intervalo = 0;

    GameObject circInstanciado;
    GameObject oldCircInstanciado;
    

    // Use this for initialization
    void Update () {

        if (time > oldtime + intervalo) //show de gambiarras ou (instanciado == null)
        {
            Debug.Log("start");
            oldCircInstanciado = circInstanciado;
            circInstanciado = criaCirculo();
            Destroy(oldCircInstanciado);
            oldtime = time;
        }
        else
        {
            time = time + Time.deltaTime;
            Debug.Log("else");
        }


        if ((circInstanciado != null) && (circInstanciado.transform.localScale.x == 0.0f))
        {
            tomarDano(10.0f,playerHealthBar);
            Destroy(circInstanciado);
        }

        //if (circInstanciado == null)
        //    gameObject.SetActive(false);

    }

    private GameObject criaCirculo()
    {
        return Instantiate(((Random.Range(0.0f, 1.0f) > 0.5f) ? circuloAtaqueDireita : circuloAtaqueEsquerda));
    }

    public void botaoAtaque(string mao)
    {
        if (circInstanciado.GetComponent<ICirculo>().pegaTipo() == mao) //mão certa, dano no inimigo
        {
            tomarDano(circInstanciado.GetComponent<ICirculo>().pegaBaseDano(), inimigoHealthBar);
        }
        else // mão errada, dano no player
        {
            tomarDano(circInstanciado.GetComponent<ICirculo>().pegaBaseDano(), playerHealthBar);// dano no player de acordo com o que ele ia tirar
        }
    }

    void tomarDano(float dano,Slider barra)
    {
        barra.value += dano;
    }
}
