using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class userNearAvoidance : MonoBehaviour
{
    public float clearence_ = 10f;
    public float clearVelocity_ = 100f;
    private GameObject player_;
    // Start is called before the first frame update
    void Start()
    {
        player_ = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player_.transform.position, transform.position) < clearence_) {
            float velocity = Math.Max(0,clearVelocity_ - Vector3.Distance(player_.transform.position, transform.position));
            GetComponent<Rigidbody>().AddForce((transform.position - player_.transform.position) * velocity);
        }
    }
}
