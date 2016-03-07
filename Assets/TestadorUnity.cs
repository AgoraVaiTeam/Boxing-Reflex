using UnityEngine;
using System.Collections;

public class TestadorUnity : MonoBehaviour {
    [SerializeField]
    MedAtaque mediadorAtaque;

    void Update () {
#if UNITY_EDITOR
        if (Input.GetKeyDown("d"))
            mediadorAtaque.botaoAtaque("DIREITA");
        if (Input.GetKeyDown("a"))
            mediadorAtaque.botaoAtaque("ESQUERDA");
#endif
    }
}
