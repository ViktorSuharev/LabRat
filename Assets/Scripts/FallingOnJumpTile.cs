using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingOnJumpTile : MonoBehaviour {
    Rigidbody2D rb;
    float fallingDelaySec = 0.5f;
    float destroyDelaySec = 2f;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name.Equals("Player")) {
            Invoke("DropPlatform", fallingDelaySec);
            Destroy(gameObject, destroyDelaySec);
        }
    }

    void DropPlatform() {
        rb.isKinematic = false;
    }
}
