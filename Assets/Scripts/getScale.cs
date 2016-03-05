using UnityEngine;
using System.Collections;

public class getScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //GetComponent<Animation>().
            //GetComponent<AnimationClip>().frameRate = Random.Range(20.0f, 45.0f);
        GetComponent<Animation>().Play();


    }
	
	// Update is called once per frame
	void Update () {
        //sDebug.Log("Tamanho = " + transform.localScale);
	}
}
