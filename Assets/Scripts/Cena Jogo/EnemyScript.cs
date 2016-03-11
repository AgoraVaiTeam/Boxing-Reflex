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
    Animator animatorInimigo;
    [SerializeField]
    Animator animatorHands;

    public float tempoSoco;

    //public float chanceCabeca;
    //public float chanceOmbroEsq;
    //public float chanceOmbroDir;
    //public float chanceAbdEsq;
    //public float chanceAbdDir;

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

    public void InimigoBatendo() {
        animatorInimigo.SetBool("Batendo", true);
        StartCoroutine(AwaitRoutineSoco(tempoSoco, "Batendo", animatorInimigo));
    }

    public void InimigoApanhando() {
        animatorInimigo.SetBool("Apanhando", true);
        StartCoroutine(AwaitRoutineSoco(tempoSoco, "Apanhando", animatorInimigo));
    }

    public void socaDir() {
        animatorHands.SetBool("socandoDir", true);
        StartCoroutine(AwaitRoutineSoco(tempoSoco, "socandoDir", animatorHands));

    }
    public void socaEsq() {
        animatorHands.SetBool("socandoEsq", true);
        StartCoroutine(AwaitRoutineSoco(tempoSoco, "socandoEsq", animatorHands));

    }

    IEnumerator AwaitRoutineSoco(float seconds, string booleanName, Animator animator) {
        yield return new WaitForSeconds(seconds);
        animator.SetBool(booleanName, false);
    }
}
