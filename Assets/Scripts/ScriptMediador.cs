using UnityEngine;
using System.Collections;

public class ScriptMediador : MonoBehaviour {
    [SerializeField]
    GameObject botao;
    [SerializeField]
    GameObject circulo;
    [SerializeField]
    AnimationClip animacao;

    float time = 0;
    float oldtime;
    public float intervalo;
    GameObject instanciado;
    GameObject oldInstanciado;

    //[SerializeField]
    // Use this for initialization
    void Start () {
        time = 0;
        oldtime = 0;
        oldInstanciado = null;
        //Instantiate(circulo);
    }
	
	// Update is called once per frame
	void Update () {
        if (time > oldtime + intervalo) //show de gambiarras
        {
            oldInstanciado = instanciado;
            instanciado = Instantiate(circulo);
            instanciado.GetComponent<Animation>().AddClip(animacao, "nome que eu quiser");
            oldtime = time;
            Destroy(oldInstanciado);
        }
        else
        {
            time = time + Time.deltaTime;
        }
    }

    public void apertarBotao()
    {
        Debug.Log("Ponto = " + (1-instanciado.transform.localScale.x));
        Destroy(instanciado); 
    }
}
