using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{

    private float speed = -2f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public bool destroyBoulder;
    public bool destroyAllBoulders;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        destroyBoulder = false;
        rb.gravityScale = Random.Range(0.9f, 2f);
        destroyAllBoulders = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyBoulder){
            Destroy(this.gameObject);
            destroyBoulder = false;
        }
    }
}
