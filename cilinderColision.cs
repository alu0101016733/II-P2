using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilinderColision : MonoBehaviour
{
    public float scaling_ = 1.1f;
    public string type_ = "None";
    private Transform transform_;
    // Start is called before the first frame update
    void Start()
    {
        transform_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            transform.localScale += new Vector3(scaling_,scaling_,scaling_);
            GameObject nc = GameObject.FindGameObjectsWithTag("NewCharacter")[0];
            nc.GetComponent<NewCharacterController>().addPoints(3);

        }
        Debug.Log("OnTriggerEnter in cilinder collision");
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player" && Input.GetKey("space") && type_ == "A") {
            Debug.Log("OnTriggerStay in cilinder collision: I am OUT");
            this.GetComponent<Rigidbody>().AddExplosionForce(250f, transform_.position, 0.5f, 300f, ForceMode.Force);
        }
    }
}
