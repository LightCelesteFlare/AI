using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvadeAction : MonoBehaviour {

    private Transform target = null;


    public int maxRange;
    public int minRange;
    private Vector3 targetTran;
    // Use this for initialization


    void Update()
    {
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") target = other.transform;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") target = null;
    }
}
