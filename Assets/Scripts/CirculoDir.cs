using UnityEngine;
using Assets.Scripts.Enum;

public class CirculoDir : AbstractCirculo
{

    // Use this for initialization
    void Awake()
    {
        this.tipo = DirectionEnum.Right;
    }
}
