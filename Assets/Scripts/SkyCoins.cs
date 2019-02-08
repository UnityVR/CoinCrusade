using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyCoins : MonoBehaviour
{
    public GameObject coin;
    public GameObject pile;
    public GameObject[] coins;
    public GameObject[] piles;
    private Vector3 position;

    void Start()
    {
        Fill();
    }

    void Update() {
        for (int i = 0; i < coins.Length; i++) {
            if (coins[i].transform.position.y < 0.8) {
                coins[i].GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        for (int i = 0; i < piles.Length; i++) {
            if (piles[i].transform.position.y < 0.01) {
                piles[i].GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }

    void Fill() {
        for (int i = 0; i < coins.Length; i++) {
            position = new Vector3(Random.Range(-90.0f, 30.0f), 14, Random.Range(-60.0f, 60.0f));
            coins[i] = Instantiate(coin, position, Quaternion.identity);
            coins[i].GetComponent<Rigidbody>().isKinematic = false;
        }
        for (int i = 0; i < piles.Length; i++) {
            position = new Vector3(Random.Range(-90.0f, 30.0f), 14, Random.Range(-60.0f, 60.0f));
            piles[i] = Instantiate(pile, position, Quaternion.identity);
            piles[i].GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
