using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoDir : MonoBehaviour, ICirculo {
    [SerializeField]
    GameObject Circulo_G;

    public DirectionEnum tipo { get; private set; }

    // Use this for initialization
    void Start() {
        tipo = DirectionEnum.Right;
        float speed = Random.Range(0.5f, 3.0f);
        Circulo_G.GetComponent<Animation>()["AnimCirculo"].speed = speed;
    }

    public float pegaTamanho() {
        return Circulo_G.transform.localScale.x;
    }

    public float pegaBaseDano() {
        return (1 - Circulo_G.transform.localScale.x) * 10;
    }
}
