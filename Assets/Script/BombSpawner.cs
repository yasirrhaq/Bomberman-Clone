using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour {

    public Tilemap tilemap;
    public GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        bombSpawner();
    }

    private void bombSpawner() {
        if (Input.GetKeyDown(KeyCode.J)) {
            Vector3Int cell = tilemap.WorldToCell(transform.position);
            Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        }
    }
}
