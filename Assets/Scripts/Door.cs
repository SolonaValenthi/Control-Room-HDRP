using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator _animator;
    BoxCollider[] _physicsCollider;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _physicsCollider = GetComponents<BoxCollider>();

        if (_animator == null)
        {
            Debug.LogError("Failed to cache door animator on " + this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("Open", true);
            _physicsCollider[0].enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("Open", false);
            _physicsCollider[0].enabled = true;
        }
    }
}
