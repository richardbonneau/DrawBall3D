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

    // // Update is called once per frame


    void Update()
    {


        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Vector3 point = ray.GetPoint(1000);


        if (Input.GetMouseButton(0))
        {
            Physics.Raycast(ray, out hit, 10000);
            if (hit.collider.gameObject.tag == "SidePlane") Instantiate(line, hit.point, transform.rotation);


        }
    }
}
