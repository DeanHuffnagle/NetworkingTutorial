using Mirror;
using UnityEngine;
using UnityEngine.Networking;






public class Player : NetworkBehaviour 
{

public float speed = 0.1f;

void HandleMovement() 
{
    if (isLocalPlayer)
    {
        float _moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float _moveVertical = Input.GetAxis("Vertical") * speed;
        Vector3 _movement = new Vector3(_moveHorizontal, _moveVertical, 0f);
        transform.position = transform.position + (_movement * Time.deltaTime);
    }
}

void Update()
    {
        HandleMovement();
    }
}
