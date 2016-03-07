using UnityEngine;
using System.Collections;

public class CirculoDir : MonoBehaviour,ICirculo {
    float descendo;
    string tipo;
	// Use this for initialization
	void Start () {
        tipo = "DIREITA";
        float speed = Random.Range(0.5f, 3.0f);
        GetComponent<Animation>()["AnimCirculo"].speed = speed;
    }
	
	public float pegaTamanho() {
        return transform.localScale.x;
	}
    public string pegaTipo()
    {
        return tipo;
    }

    public float pegaBaseDano()
    {
        return (1 - transform.localScale.x);
    }
}
