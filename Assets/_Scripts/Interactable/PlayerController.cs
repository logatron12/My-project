using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _player;
    private new Transform camera;

    [SerializeField] private float _moveSpeed, _gravity, _fallvelocity, _jumpForce;
    private float _hor, _ver;
    private Vector3 _axis, _movePlayer;
    [SerializeField] private Vector2 _sensibity;
    
    private void Awake()
    {
        _player = GetComponent<CharacterController>();
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {

        _hor = Input.GetAxis("Mouse X");
        _ver = Input.GetAxis("Mouse Y");

        if(_hor != 0)
        {
            transform.Rotate(Vector3.up * _hor * _sensibity.x);
        }

        if (_hor != 0)
        {
            //camera.Rotate(Vector3.left * _ver);
            float angle = (camera.localEulerAngles.x - _ver * _sensibity.y + 360) % 360;
            if(angle > 180)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -80, 80);
            camera.localEulerAngles = Vector3.right * angle;
        }



        _axis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (_axis.magnitude > 1) _axis = transform.TransformDirection(_axis).normalized;
        else _axis = transform.TransformDirection(_axis);

        _movePlayer.x = _axis.x;
        _movePlayer.z = _axis.z;
        setGravity();
        // Permite que el personaje salte incluso si está quieto
        if (Input.GetKey(KeyCode.Space) && _player.isGrounded)
        {
            _fallvelocity = _jumpForce;
        }
        _player.Move(_axis * _moveSpeed * Time.deltaTime);

    }

    // Permite que el personaje salte 
    private void setGravity()
    {
        if (_player.isGrounded)
        {
            _fallvelocity = -_gravity * Time.deltaTime;
            if (Input.GetKey(KeyCode.Space))
            {
                _fallvelocity = _jumpForce;
            }

        }
        else
        {
            _fallvelocity -= _gravity * Time.deltaTime;
        }
        _movePlayer.x = _axis.x;
        _movePlayer.z = _axis.z;
        _movePlayer.y = _fallvelocity;
        _player.Move(_movePlayer * Time.deltaTime);
    }

}
