using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform ballTransform;
    [SerializeField] float smoothSpeed;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    void Update()
    {
        CameraTracking();
    }

    /*Kendisine gönderilen oyun objesinin transformuna göre takip eden kamera takip metodu.*/
    void CameraTracking()
    {
        Vector3 newCameraPos = Vector3.Lerp(transform.position, ballTransform.position + offset, smoothSpeed * Time.deltaTime);
        transform.position = newCameraPos;
    }
}
