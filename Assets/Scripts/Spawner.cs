using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabsArray;
    public Terrain terrain;
    private TerrainData terrainData;
    public EventTrigger eventTrigger;

    private void Start()
    {
        terrainData = terrain.terrainData;
        InvokeRepeating(nameof(Spawn), 1f, 0.1f);
    }

    private void Spawn()
    {
        int x = (int) Random.Range(0, terrainData.size.x);
        int z = (int) Random.Range(0, terrainData.size.z);
        Vector3 position = new Vector3(x, 0f, z);
        position.y = terrain.SampleHeight(position) + 10f;
        int randomPrefab = Random.Range(0, prefabsArray.Length);
        Instantiate(prefabsArray[randomPrefab], position, Quaternion.identity);
    }
}
