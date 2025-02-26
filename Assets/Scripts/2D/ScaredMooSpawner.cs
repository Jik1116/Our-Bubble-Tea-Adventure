using UnityEngine;

public class ScaredMooSpawner : MonoBehaviour
{
    public GameObject prefab;
    public void Spawn(int spawnAmount)
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Instantiate(prefab, this.transform);
        }
    }
}
