using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterController : MonoBehaviour
{
    public float speedMultiplier = 1f;
    private Transform transform_;
    private uint points_ = 0;
    public string controlHorizontal_ = "Horizontal";
    public string controlVertical_ = "Vertical";
    public string controlRotation_ = "Rotation";
    // Start is called before the first frame update
    void Start()
    {
        transform_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis(controlHorizontal_) * speedMultiplier;
        float verticalMove = Input.GetAxis(controlVertical_) * speedMultiplier;
        float rotationalMove = Input.GetAxis(controlRotation_) * speedMultiplier;
        transform_.Translate(new Vector3(horizontalMove, 0f, verticalMove));
        transform_.Rotate(new Vector3(0f, rotationalMove, 0f));
    }

    public void addPoints(uint points) {
        points_ += points;
        Debug.Log("Current Points: "+points_);
    }
}
