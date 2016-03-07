using UnityEngine;
using System.Collections;

public class ScriptCirculo : MonoBehaviour, ICirculo
{
    float descendo;
    string tipo;
	// Use this for initialization
	void Start () {
        tipo = "nada ainda";
        float speed = Random.Range(0.5f, 3.0f);
        GetComponent<Animation>()["AnimCirculo"].speed = speed;
        GetComponent<Animation>()["Círculo_Pequeno"].speed = speed;
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
        return transform.localScale.x;
    }
}
