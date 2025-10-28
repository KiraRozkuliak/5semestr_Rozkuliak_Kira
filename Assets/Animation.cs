using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("IsOpen", true);
    }
    private void  OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpen", false);
    }
}
