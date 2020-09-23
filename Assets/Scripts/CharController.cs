using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 8f;
    float shiftSpeed = 16f;
    float currentSpeed = 0;

    Vector3 forward, right;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = moveSpeed;
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfRunning();

        if (Input.anyKey)
        {
            Move();
        }
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * currentSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * currentSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    void CheckIfRunning()
    {
        if (Input.GetKeyDown("left shift"))
        {
            currentSpeed = shiftSpeed;
        }
        if (Input.GetKeyUp("left shift"))
        {
            currentSpeed = moveSpeed;
        }
    }
}
