using UnityEngine;
using System.Collections;
using System;

public class EnemyScript : MonoBehaviour {
    [SerializeField]
    GameObject cabeca;
    [SerializeField]
    GameObject ombroEsq;
    [SerializeField]
    GameObject ombroDir;
    [SerializeField]
    GameObject abdEsq;
    [SerializeField]
    GameObject abdDir;
    [SerializeField]
    GameObject spriteInimigo;

    public float tempoHit;

    //public float chanceCabeca;
    //public float chanceOmbroEsq;
    //public float chanceOmbroDir;
    //public float chanceAbdEsq;
    //public float chanceAbdDir;

    public void EnemyColorDamage() {
        this.spriteInimigo.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.5f);
        StartCoroutine(AwaitRoutine(this.tempoHit));
    }

    IEnumerator AwaitRoutine(float seconds) {
        yield return new WaitForSeconds(seconds);
        this.spriteInimigo.GetComponent<SpriteRenderer>().color = Color.white;
    }

    public GameObject EnemyBodyPartReturn() {
        // Converte um número aletório para inteiro
        int randomNumber = Convert.ToInt32(UnityEngine.Random.Range(1, 5));

        // Retorna um GameObject baseado no número gerado aleatoriamente
        switch (randomNumber) {
            case 1:
                return this.cabeca;
            case 2:
                return this.ombroEsq;
            case 3:
                return this.ombroDir;
            case 4:
                return this.abdEsq;
            case 5:
                return this.abdDir;
            default:
                return this.cabeca;
        }
    }
}
