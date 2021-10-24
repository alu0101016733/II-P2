using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterController : MonoBehaviour
{
    public float speedMultiplier = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * speedMultiplier;
        float verticalMove = Input.GetAxis("Vertical") * speedMultiplier;
        float rotationalMove = Input.GetAxis("Rotation") * speedMultiplier;
        transform.Translate(new Vector3(horizontalMove, 0f, verticalMove));
        transform.Rotate(new Vector3(0f, rotationalMove, 0f));
    }
}
