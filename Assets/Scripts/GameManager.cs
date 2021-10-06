using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    GameObject LocalPlayer = null;
    // Start is called before the first frame update
    void Start()
    {
       LocalPlayer = Instantiate<GameObject>(Player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
