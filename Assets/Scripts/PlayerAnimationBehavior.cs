using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehavior : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    private PlayerMovementBehaviour _movementBehavior;

    // Start is called before the first frame update
    void Start()
    {
        _movementBehavior = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Speed", _movementBehavior.Velocity.magnitude);
        _animator.SetBool("InAir", _movementBehavior.IsGrounded);
    }

    public void SetWinTrigger()
    {
        _animator.SetTrigger("WonGame");
    }
}
