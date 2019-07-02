using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    void Start()
    {
        cam.transform.Rotate(90.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.Rotate(90.0f, 0.0f, 0.0f);

    }
}
