using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    [SerializeField] GameObject splashPrefab;
    [SerializeField] float jumpForce;
    Rigidbody rb;
    GameManagerController gameManagerController;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManagerController = GameObject.FindObjectOfType<GameManagerController>();
    }
    /*Oyun objesinin zemin ile etkileşimi gerçekleştiği zaman zeminde oluşacak olan izin oluşturan, ExpPlatform objesi ile etkileşimi gerçekleştiği zaman oyunun baştan başlatıldığı, LastRing ile etkileşime girdiği zaman oyunun durduğu ve ekranda yazının çıktığı işlemleri gerçekleştiren metot.*/
    void OnCollisionEnter(Collision temas)
    {
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.23f, 0f), transform.rotation);
        splash.transform.SetParent(temas.gameObject.transform);
        rb.AddForce(Vector3.up * jumpForce);

        if(temas.gameObject.tag == "ExpPlatform")
        {
            gameManagerController.RestartGame();
        }
        else if(temas.gameObject.tag == "LastRing")
        {
            gameManagerController.LastRingText();
            Time.timeScale = 0;
        }
    }
}
