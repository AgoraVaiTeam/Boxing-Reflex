using UnityEngine;
using System.Collections;

public class ScriptCirculo : MonoBehaviour {
    float descendo;
	// Use this for initialization
	void Start () {
        GetComponent<Animation>()["AnimCirculo"].speed = Random.Range(0.5f,3.0f);
    }
	
	public float pegaTamanho() {
        return transform.localScale.x;
	}
}
