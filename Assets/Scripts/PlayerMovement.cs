using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<GameObject>().transform.position = Input.GetAxis("horizontal");
        }
    }
}
