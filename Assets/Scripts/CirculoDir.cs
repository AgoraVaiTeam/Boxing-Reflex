using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoDir : MonoBehaviour, ICirculo {
    public DirectionEnum tipo { get; private set; }

    // Use this for initialization
    void Start() {
        tipo = DirectionEnum.Right;
        float speed = Random.Range(0.5f, 3.0f);
        GetComponent<Animation>()["AnimCirculo"].speed = speed;
    }

    public float pegaTamanho() {
        return transform.localScale.x;
    }

    public float pegaBaseDano() {
        return (1 - transform.localScale.x);
    }
}
