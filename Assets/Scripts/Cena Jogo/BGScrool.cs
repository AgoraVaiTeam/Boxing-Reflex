using UnityEngine;
using System.Collections;

public class BGScrool : MonoBehaviour {
    public float speed;

    public float tempoPause;
    public float tempoAnde;


    bool paused;
    //public float stepping;
	// Use this for initialization
	void Start () {
        StartCoroutine(andando(this.tempoAnde));
    }
	
	// Update is called once per frame
	void Update () {
        if (!paused)
            GetComponent<Renderer>().material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0.0f);
	}

    IEnumerator pausado(float seconds)
    {
        paused = false;
        yield return new WaitForSeconds(seconds);
        StartCoroutine(andando(this.tempoAnde));
    }

    IEnumerator andando(float seconds)
    {
        paused = true;
        yield return new WaitForSeconds(seconds);
        StartCoroutine(pausado(this.tempoPause));
    }
}
