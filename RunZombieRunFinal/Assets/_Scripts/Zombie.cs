using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Animator animator;
    public float walkSpeed = 1f;
    public float rotateSpeed = 90f;
    public AudioSource audiosource;
    public AudioClip clip;
    public float volume = 0.5f;

    void Update()
    {

        float multiply = Input.GetKey(KeyCode.LeftShift) ? 2 : 1;
        float vertical = Input.GetAxis("Vertical") * multiply;
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(0, 0, walkSpeed * Time.deltaTime * vertical);
        transform.Rotate(0, rotateSpeed * Time.deltaTime * horizontal, 0);
        animator.SetFloat("Vertical", vertical);

        if(Input.GetKeyDown(KeyCode.E))
            animator.SetTrigger("Wave");
    }

    public void Step()
    {
        //Debug.Log("Pisou");
        audiosource.PlayOneShot(clip, volume);
    }
}
