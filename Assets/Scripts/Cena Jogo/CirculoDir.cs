using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoDir : AbstractCirculo
{
    [SerializeField]
    GameObject Circulo_P;
    // Use this for initialization
    void Start()
    {
        Circulo_P.GetComponent<Animation>()["CircPeqDir"].speed = speed;
        this.tipo = DirectionEnum.Right;
    }
}
