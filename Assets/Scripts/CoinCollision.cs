using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    private Vector3 position;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag != "Coin" || collision.gameObject.tag != "Pile" || collision.gameObject.tag != "Player") {
            this.position.y += 1f;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
