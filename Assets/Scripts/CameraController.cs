using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float padding;
    private Vector3 moveDir;


	private void OnEnable()
	{
        Cursor.lockState = CursorLockMode.Confined;
	}

	private void OnDisable()
	{
        Cursor.lockState = CursorLockMode.None;
	}

	private void Update()
	{
        Move();
	}

    private void Move()
    {
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
        // World 기준 앞뒤 양옆으로 움직여야함
        // Local 기준이면 위아래로 움직였을때 가까워지거나 멀어짐
    }

	private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        moveDir.x = input.x;
        moveDir.z = input.y;
    }

    private void OnPointer(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
       // Debug.Log(input);

        if(input.x < padding)
        {
            moveDir.x = -1;
        }
        else if(Screen.width - padding < input.x)
        {
            moveDir.x = 1;
        }
        else
        {
            moveDir.x = 0;
        }

        if(input.y < padding)
        {
            moveDir.z = -1;
        }
        else if(Screen.height - padding < input.y)
        {
            moveDir.z = 1;
        }
        else
        {
            moveDir.z = 0;
        }
    }

    
}
