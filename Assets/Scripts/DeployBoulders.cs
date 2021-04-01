using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBoulders : MonoBehaviour
{

    public GameObject boulder;
    [SerializeField] float respawnTime = 1f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(BoulderSpawn());
    }

    private void spawnBoulder()
    {
        GameObject enemy = Instantiate(boulder) as GameObject;
        enemy.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x),screenBounds.y + 4f);
    }

    IEnumerator BoulderSpawn()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBoulder();
        }
    }

    IEnumerator IncreaseSpawnRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            respawnTime = respawnTime - .1f;
        }
    }
}
