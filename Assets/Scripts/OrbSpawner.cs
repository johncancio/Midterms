using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    [SerializeField] private GameObject orbPrefab;
    [SerializeField] private int orbNum = 15;
    [SerializeField] private Vector2 randomXPos;
    [SerializeField] private Vector2 randomZPos;

    void Start()
    {
        SpawnOrbs();
    }

    private void SpawnOrbs()
    {
        int orbsPlaced = 0;

        while (orbsPlaced < orbNum)
        {
            float xPos = Random.Range(randomXPos.x, randomXPos.y);
            float zPos = Random.Range(randomZPos.x, randomZPos.y);
            Vector3 rayPos = new Vector3(xPos, 20, zPos);
            Ray ray = new Ray(rayPos, Vector3.down);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, 100))
            {
                if (hitInfo.collider.CompareTag("Floor"))
                {
                    Vector3 orbNewPos = new Vector3(hitInfo.point.x, 1, hitInfo.point.z);
                    Instantiate(orbPrefab, orbNewPos, Quaternion.identity);
                    orbsPlaced++;
                }
            }
        }
    }
}