using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float walkSpeed = 1f;
    public float runSpeed = 3f;
    public float rotateSpeed = 120f;
    public AudioSource stepSound;
    public Animator animator;

    public void Step()
    {
        stepSound.pitch = Random.Range(0.8f, 1.2f);
        stepSound.Play();
    }

    private void Update()
    {
        int direction = 0;
        if(Input.GetKey(KeyCode.W))
            direction = 1;
        if(Input.GetKey(KeyCode.S))
            direction = -1;

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        animator.SetInteger("MoveDirection", direction);
        animator.SetBool("isRunning", isRunning);

        // Estrutura do IF
        // valor = condição ? valorVerdadeiro : valorFalso;
        float speed = isRunning ? runSpeed : walkSpeed;
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(0, 0, speed * Time.deltaTime * vertical);
        transform.Rotate(0, rotateSpeed * Time.deltaTime * horizontal, 0);
    }
}
