using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public Paddle Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        if (col.gameObject.CompareTag("Ball")){
            Player.IncrementScore(1);
            col.gameObject.transform.position = Vector3.zero;
            col.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GameManager.Instance.Play = false;
            // trigger coroutine

        }
    }
}
