using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMaker : MonoBehaviour
{
    public GameObject line;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            Physics.Raycast(ray, out hit);
            print(hit.point);
            Instantiate(line, hit.point, Quaternion.identity);
        }
    }
}
