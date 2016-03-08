using UnityEngine;
using Assets.Scripts.Enum;

abstract public class AbstractCirculo : MonoBehaviour {
    [SerializeField]
    GameObject Circulo_G;

    public float MultiBaseDano;
    public float MaxVelocity;
    public float MinVelocity;

    public DirectionEnum tipo { get; protected set; }

    void Start() {
        float speed = Random.Range(0.5f, 3.0f);
        Circulo_G.GetComponent<Animation>()["AnimCirculo"].speed = speed;
    }

    public float PegaTamanho() {
        return Circulo_G.transform.localScale.x;
    }

    public float PegaBaseDano() {
        if (this.Circulo_G.transform.localScale.x <= 0.1f)
            return 1 * this.MultiBaseDano * 2;
        return (1 - Circulo_G.transform.localScale.x) * this.MultiBaseDano;
    }
}
