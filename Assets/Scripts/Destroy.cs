using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public float destroy = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroy -= Time.deltaTime;
		if (destroy <= 0)
        {
            Object.Destroy(gameObject);
        }
	}
}
