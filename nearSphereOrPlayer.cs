using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearSphereOrPlayer : MonoBehaviour
{
    private GameObject player_;
    private GameObject[] spheres_;
    public float sizeMultiplier_ = 0.1f;
    public float distanceForActivation_ = 5f;
    public float maxSize_ = 5f;
    public float minSize_ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        player_ = GameObject.FindGameObjectsWithTag("Player")[0];
        spheres_ = GameObject.FindGameObjectsWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        float scaling = 0f;
        if (Vector3.Distance(player_.transform.position, transform.position) < distanceForActivation_) {
            scaling += (1 / Vector3.Distance(player_.transform.position, transform.position));
        }

        foreach (GameObject sphere in spheres_) {
            if (Vector3.Distance(sphere.transform.position, transform.position) < distanceForActivation_) {
                scaling -= (1 / Vector3.Distance(sphere.transform.position, transform.position));
            }
        }
        
        float newScale = transform.localScale[0] + sizeMultiplier_*scaling;
        if(newScale <= maxSize_ && newScale >= minSize_) {
            transform.localScale = new Vector3(newScale,newScale,newScale);
        }
    }
}
