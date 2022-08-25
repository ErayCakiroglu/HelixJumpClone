using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    float moveX;
    void Update()
    {
        CylinderRotate();
    }

    /*Silindir oyun objesini mouse ile döndürmeye yarayan metot.*/
    void CylinderRotate()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveX * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
