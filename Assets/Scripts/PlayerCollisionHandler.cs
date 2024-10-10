using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private GameManagement gameManagement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Collectable collectable = collision.gameObject.GetComponent<Collectable>();
            if (collectable != null)
            {
                collectable.Collect();
                gameManagement.UpdateScore();
            }
        }
    }
}