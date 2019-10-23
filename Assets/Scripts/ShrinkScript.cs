using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkScript : MonoBehaviour
{
    private bool hasSpawn;

    private Collider2D colliderComponent;
    private SpriteRenderer rendererComponent;

    // Start is called before the first frame update
    void Start()
    {
        hasSpawn = false;

        // Disable everything
        colliderComponent.enabled = false;
        rendererComponent = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSpawn == false)
        {
            if (rendererComponent.IsVisibleFrom(Camera.main))
            {
                Spawn();
            }
        }
        else
        {
            if (rendererComponent.IsVisibleFrom(Camera.main) == false)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Spawn()
    {
        hasSpawn = true;

        // Enable everything
        colliderComponent.enabled = true;
}
}
