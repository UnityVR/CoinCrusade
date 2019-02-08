using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class CollectCoin : MonoBehaviour
{
    public GameObject coin;
    public GameObject pile;
    public AudioSource coinSound;
    public AudioSource pileSound;
    public AudioSource[] sound;
    public ParticleSystem particles;
    public string playerId;

    private Vector3 position;

    void Start () {
        sound = GetComponents <AudioSource> ();
        coinSound = sound[0];
        pileSound = sound[1];
        playerId = GetComponent<NetworkIdentity> ().netId.ToString ();

    }

    void OnTriggerEnter (Collider other) {
        // TBD: take in playerId, cmd called addPoint to update GameManager
        
        if (other.gameObject.CompareTag("Coin")) 
        {
            coinSound.Play();
            var ps = Instantiate(particles, other.transform.position, Quaternion.identity);
            ps.Play();
            other.gameObject.SetActive(false);
            Debug.Log("Got a coin!");

            if (playerId == "4") {
                ScoreKeeper.Instance.P1NumCoins++;
            } else if (playerId == "5") {
                ScoreKeeper.Instance.P2NumCoins++;
            } else if (playerId == "6") {
                ScoreKeeper.Instance.P3NumCoins++;
            } 
        }

        if (other.gameObject.CompareTag("Pile")) 
        {
            pileSound.Play();
            var position = new Vector3(other.transform.position.x, other.transform.position.y + 0.5f, other.transform.position.z);
            var ps = Instantiate(particles, position, Quaternion.identity);
            ps.Play();
            other.gameObject.SetActive(false);
            Debug.Log("Pile o' coins!");

            if (playerId == "4") {
                ScoreKeeper.Instance.P1NumCoins += 5;
            } else if (playerId == "5") {
                ScoreKeeper.Instance.P2NumCoins += 5;
            } else if (playerId == "6") {
                ScoreKeeper.Instance.P3NumCoins += 5;
            } 
        }
    }
}
