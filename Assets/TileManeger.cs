using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManeger : MonoBehaviour
{

    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLengh = 160.0f;
    private float safeZone = 160.0f;
    private int amnTilesOnScreen = 7;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;

	// Use this for initialization
	void Start ()
    {

        activeTiles = new List<GameObject>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }

    }

    // Update is called once per frame
    void Update ()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLengh))
        {
            SpawnTile();
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;

        go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLengh;

        activeTiles.Add(go);

    }
    
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 5)
        {
            return 0;
        }

        int randamIndex = lastPrefabIndex;

        while(randamIndex == lastPrefabIndex)
        {
            randamIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randamIndex;
        return randamIndex;

    }
}
