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
    [SerializeField]
    Animator animadorInimigo;

    public float tempoHit;
    public float tempoSoco;

    //public float chanceCabeca;
    //public float chanceOmbroEsq;
    //public float chanceOmbroDir;
    //public float chanceAbdEsq;
    //public float chanceAbdDir;

    public void EnemyColorDamage() {
        this.spriteInimigo.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.5f);
        StartCoroutine(AwaitRoutineVermelho(this.tempoHit));
    }

    IEnumerator AwaitRoutineVermelho(float seconds) {
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

    public void socaDir()
    {
        Debug.Log("entrou");
        animadorInimigo.SetBool("socandoDir", true);
        //StartCoroutine(AwaitRoutineSoco(tempoSoco, "socandoDir"));

    }
    public void socaEsq()
    {
        Debug.Log("entrou");
        animadorInimigo.SetBool("socandoEsq", true);
        //StartCoroutine(AwaitRoutineSoco(tempoSoco, "socandoEsq"));

    }

    IEnumerator AwaitRoutineSoco(float seconds,string booleano)
    {
        yield return new WaitForSeconds(seconds);
        animadorInimigo.SetBool(booleano, false);
    }
}
