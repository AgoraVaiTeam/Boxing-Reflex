using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoEsq : AbstractCirculo
{

    // Use this for initialization
    void Awake()
    {
        this.tipo = DirectionEnum.Left;
    }
}
