using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private PlayerInput playerInput; // Assign in the Inspector

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 movement = playerInput.GetMovementInput();
        transform.Translate(movement * Time.deltaTime * speed);
    }
}
