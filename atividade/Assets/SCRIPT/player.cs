using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f; // Velocidade do jogador
    public float jumpForce = 10f; // For�a do pulo

    private Rigidbody rb;

    void Start()
    {
        // Obt�m a refer�ncia do componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Movimento vertical usando as teclas "W" e "S"
        float moveVertical = Input.GetAxis("Vertical");

        // Movimento horizontal usando as teclas "A" e "D"
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Cria um vetor de movimento baseado nas teclas de entrada
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplica o movimento ao Rigidbody
        rb.AddForce(movement * speed);

        // Verifica se a tecla de espa�o (espa�o) est� sendo pressionada e se o jogador est� no ch�o (por exemplo, uma superf�cie plana)
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            // Aplica uma for�a vertical para simular o pulo
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


