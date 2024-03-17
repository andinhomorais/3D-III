using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f; // Velocidade do jogador
    public float jumpForce = 10f; // Força do pulo

    private Rigidbody rb;

    void Start()
    {
        // Obtém a referência do componente Rigidbody
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

        // Verifica se a tecla de espaço (espaço) está sendo pressionada e se o jogador está no chão (por exemplo, uma superfície plana)
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            // Aplica uma força vertical para simular o pulo
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


