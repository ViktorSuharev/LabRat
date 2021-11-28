using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingOnJumpTile : MonoBehaviour {
    Rigidbody2D rb;
    public float fallingDelaySec = 0.5f;
    public float destroyDelaySec = 2f;
    public float verticalVelocityThreshold = -5f;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col) {
        Debug.Log(col.relativeVelocity.y);
        if (col.gameObject.name.Equals("Player") && col.relativeVelocity.y < verticalVelocityThreshold) {
            Invoke("DropPlatform", fallingDelaySec);
            Destroy(gameObject, destroyDelaySec);
        }
    }

    void DropPlatform() {
        rb.isKinematic = false;
    }
}
