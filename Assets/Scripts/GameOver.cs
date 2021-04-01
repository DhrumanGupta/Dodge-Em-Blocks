using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public bool destroySpawner;
    public GameObject deployBoulders;
    public ScoreManager scoreManager;
    public Boulder boulder;
    public Renderer renderer;

    void Start() {
        destroySpawner = false;
        renderer = GetComponent<Renderer>();
    }
    void Update() {
        if (destroySpawner){
            deployBoulders.SetActive(false);
            StartCoroutine (restartGame());
            destroySpawner = false;
            renderer.enabled = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Boulder"){
            Debug.Log("Game over");
            Destroy(GameObject.FindWithTag("Boulder"));
            destroySpawner = true;
        }
    }

    IEnumerator restartGame(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }
}
