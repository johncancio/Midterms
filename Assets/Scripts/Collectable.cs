using UnityEngine;

public class Collectable : MonoBehaviour
{
    private bool isCollected = false;

    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            gameObject.SetActive(false);
        }
    }
}