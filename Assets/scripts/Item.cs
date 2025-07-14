using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject itemPrefab;
    public float respawnHeight = 5f;
    public float respawnRangeX = 4.5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        
            RespawnItem();

        
            Destroy(gameObject);
        }
    }

    void RespawnItem()
    {
        
        float randomX = Random.Range(-respawnRangeX, respawnRangeX);
        Vector3 newPosition = new Vector3(randomX, respawnHeight, 0f);

        
        Instantiate(itemPrefab, newPosition, Quaternion.identity);
    }
}