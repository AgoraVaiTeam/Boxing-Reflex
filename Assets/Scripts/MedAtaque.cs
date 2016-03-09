using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Enum;

public class MedAtaque : MonoBehaviour {
    [SerializeField]
    GameObject circuloAtaqueDireita;
    [SerializeField]
    GameObject circuloAtaqueEsquerda;
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    Slider playerHealthBar;
    [SerializeField]
    Slider inimigoHealthBar;

    float time = 0;
    float oldtime = 0;
    public float intervalo = 0;
    public float damage = 0;

    GameObject circInstanciado;
    GameObject oldCircInstanciado;

    // Use this for initialization
    void Update() {
        // show de gambiarras ou (instanciado == null)
        if (time > oldtime + intervalo) {
            oldCircInstanciado = circInstanciado;
            circInstanciado = CriaCirculo();
            Destroy(oldCircInstanciado);
            oldtime = time;
        } else {
            time = time + Time.deltaTime;
        }

        if ((circInstanciado != null) && 
            (circInstanciado.GetComponent<AbstractCirculo>().PegaTamanho() <= 0.0f)) {
            //Debug.Log("tomou dano");
            TomarDano(this.damage, playerHealthBar);
            Destroy(circInstanciado);
        }
    }

    private GameObject CriaCirculo() {
        var circleObject = ((Random.Range(0.0f, 1.0f) > 0.5f) ? circuloAtaqueDireita : circuloAtaqueEsquerda);
        var bodyPartPosition = this.enemy.GetComponent<EnemyScript>().EnemyBodyPartReturn().transform.position;

        return Instantiate(circleObject, bodyPartPosition, Quaternion.identity) as GameObject;
    }

    public void BotaoAtaque(string handString) {
        // se o circulo estiver instanciado
        if (circInstanciado != null) {
            // passa parâmetro para enumerador
            var hand = handString.Contains("Left") ? DirectionEnum.Left : DirectionEnum.Right;
            if (circInstanciado.GetComponent<AbstractCirculo>().tipo == hand) {
                // invoca função para dar dano no inimigo
                this.TomarDano(circInstanciado.GetComponent<AbstractCirculo>().PegaBaseDano(), inimigoHealthBar);
                if (hand == DirectionEnum.Left)
                    enemy.GetComponent<EnemyScript>().socaEsq();
                else
                    enemy.GetComponent<EnemyScript>().socaDir(); 
                // Chama a função para trocar a cor do inimigo quando ele tomar dano
                this.enemy.GetComponent<EnemyScript>().EnemyColorDamage();
            } else {
                // invoca função para dar dano no player
                this.TomarDano(circInstanciado.GetComponent<AbstractCirculo>().PegaBaseDano(), playerHealthBar);// dano no player de acordo com o que ele ia tirar
            }
            //Debug.Log(circInstanciado);
            //Debug.Log("mão = " + hand);
            //Debug.Log("circ = " + circInstanciado.GetComponent<AbstractCirculo>().tipo);
            Destroy(circInstanciado);
        }
    }

    void TomarDano(float dano, Slider barra) {
        barra.value += dano;
    }
}
