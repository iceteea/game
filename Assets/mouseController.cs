using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseController : MonoBehaviour
{
    private Animator animator;
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));

        cameraTransform.Rotate(Vector3.right *  - Input.GetAxis("Mouse Y"));

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("attack");
        }
    }
}
