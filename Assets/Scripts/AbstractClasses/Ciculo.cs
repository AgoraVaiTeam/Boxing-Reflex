using UnityEngine;
using System.Collections;
using Assets.Scripts.Enum;

abstract public class Circulo : MonoBehaviour{
    [SerializeField]
    GameObject Circulo_G;

    //public DirectionEnum tipo { get;  set; }
    public string tipo { get; set; }

    void Start()
    {
        float speed = Random.Range(0.5f, 3.0f);
        Circulo_G.GetComponent<Animation>()["AnimCirculo"].speed = speed;
    }

    public float pegaTamanho()
    {
        return Circulo_G.transform.localScale.x;
    }

    public float pegaBaseDano()
    {
        return (1 - Circulo_G.transform.localScale.x) * 10;
    }
}
