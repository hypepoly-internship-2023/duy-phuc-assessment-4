using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float min, max;
    void Start()
    {
        
    }

    float xMouse;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            xMouse += Input.GetAxis("Mouse X");
            xMouse = Mathf.Clamp(xMouse, min, max);
            transform.eulerAngles = new Vector3(0f, xMouse, 0f);
        }
    }
}
