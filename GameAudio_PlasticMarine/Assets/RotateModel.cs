using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModel : MonoBehaviour
{
    public Transform modelTransform;
    private bool isRotate;
    private Vector3 startPoint;
    private Vector3 startAngel;
    private float rotateScale = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0) && !isRotate)
       {
        isRotate = true;
        startPoint = Input.mousePosition;
        startAngel = modelTransform.eulerAngles;
       }
       if(Input.GetMouseButtonUp(0))
       {
        isRotate = false;
       }
       if(isRotate)
       {
        var currentPoint = Input.mousePosition;
        var x = startPoint.x - currentPoint.x;// 这个角度相反（相机原因）

        modelTransform.eulerAngles = startAngel + new Vector3(0, x * rotateScale, 0);
       }
    }
}
