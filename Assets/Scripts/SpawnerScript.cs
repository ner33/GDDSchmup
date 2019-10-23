using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    /// <summary>
    /// What to spawn
    /// </summary>
    public Transform spawnPrefab;

    public float spawnMultiplier = 1f;

    /// <summary>
    /// What to attach the new spawns to
    /// </summary>
    public GameObject spawnParent;

    /// <summary>
    /// Cooldown between spawns
    /// </summary>
    private float spawnCooldown;


    // Start is called before the first frame update
    void Start()
    {
        spawnCooldown = Random.value * spawnMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCooldown > 0)
        {
            spawnCooldown = spawnCooldown - Time.deltaTime;
        }
        else
        {
            spawnCooldown = Random.value * spawnMultiplier;
            SpawnObject();
        }
    }

    /// <summary>
    /// Spawn the Prefab outside the player's vision
    /// </summary>
    void SpawnObject()
    {
        var dist = (transform.position - Camera.main.transform.position).z;

        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x + 3;

        var y = Random.Range(-7f, 7f);

        // Spawn the prefab at a location right of the viewport
        var spawnTransform = Instantiate(spawnPrefab, new Vector3(rightBorder, y, dist), Quaternion.identity) as Transform;

        spawnTransform.transform.parent = spawnParent.transform;
    }
}
