using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movimento : MonoBehaviour
{
    public float velocidade = 5f;
    void Update()
    {
        float moverX = Input.GetAxis("Horizontal");
        float moverY = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(moverX, moverY, 0f) * velocidade * Time.deltaTime;

        transform.position += movimento;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Porta"))
        {
            Debug.Log("Aqui o player deve se teletransportar para outro lugar...");
        }
    }
}
