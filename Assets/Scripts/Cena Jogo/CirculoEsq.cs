using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoEsq : AbstractCirculo
{
    [SerializeField]
    GameObject Circulo_P;
    // Use this for initialization
    void Start() {
        Circulo_P.GetComponent<Animation>()["CircPeqEsq"].speed = speed;
        this.tipo = DirectionEnum.Left;
    }


}
