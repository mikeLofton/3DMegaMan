using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    [SerializeField]
    private float _moveSpeed = 0;
    private float _movementXPosition;
    private float _movementZPosition;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        direction = new Vector3(_movementXPosition, 0, _movementZPosition);
        _velocity = direction * _moveSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
