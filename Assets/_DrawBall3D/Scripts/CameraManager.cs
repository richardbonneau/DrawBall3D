using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraManager : MonoBehaviour
{
    public GameObject behindPos;
    public GameObject sidePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 90, 0);
        transform.position = behindPos.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            print("Got A");
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position = sidePos.transform.position;
        }
    }
}
