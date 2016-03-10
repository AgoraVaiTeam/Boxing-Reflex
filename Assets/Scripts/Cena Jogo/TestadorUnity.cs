using UnityEngine;

public class TestadorUnity : MonoBehaviour
{
    [SerializeField]
    MedAtaque mediadorAtaque;

    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown("x"))
            mediadorAtaque.BotaoAtaque("Right");
        if (Input.GetKeyDown("z"))
            mediadorAtaque.BotaoAtaque("Left");
#endif
    }
}
