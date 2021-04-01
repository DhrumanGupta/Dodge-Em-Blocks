using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Boulder boulder;

    public void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground"){
            boulder.destroyBoulder = true;
        }
    }
}
