using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {
    public Transform Player;
    public GameObject Target;
    public float Speed = 4;
    public float rotationSpeed;
    public float MaxDistance = 6;
    public float MinDistance = 3;
    public GameObject projectile;

    private Rigidbody rb;
    //public float reload = 5f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        
        Vector2 movement = new Vector3(Random.Range(-5.0f * Time.deltaTime, 5.0f * Time.deltaTime), Random.Range(-5.0f * Time.deltaTime, 5.0f * Time.deltaTime), 0);
        rb.velocity = movement * Speed;

        if (Vector2.Distance(transform.position,Player.position) >= MinDistance)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;

            if(Vector2.Distance(transform.position,Player.position) <= MaxDistance)
            {

            }
        }
	}
}
