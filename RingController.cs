using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingController : MonoBehaviour
{
    [SerializeField] Transform ball;
    
    void Update()
    {
        ScoreUpdate();
    }
    
    void ScoreUpdate()
    {
        if(transform.position.y + 10f >= ball.position.y)
        {
            Destroy(gameObject);
        }
    }
}
