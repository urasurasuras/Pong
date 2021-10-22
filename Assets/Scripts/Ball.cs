using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float SpeedLimit = 20;
    Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.Play && Input.GetAxis("Submit") > 0){
            StartGame();
        }
        print(Rigidbody.velocity.magnitude);
    }

    void FixedUpdate(){

        Vector2 velocity = Rigidbody.velocity;
        
        if (velocity.magnitude > SpeedLimit){
            Rigidbody.AddForce(-velocity);
        }
    }

    void OnCollisionEnter2D(Collision2D coll){

        if (coll.gameObject.TryGetComponent(out Paddle paddle)){
            Rigidbody.AddForce( new Vector2( 0, paddle.Axis) , ForceMode2D.Impulse);        
        }
    }

    public void StartGame(){

        Rigidbody.AddForce( new Vector2( 10, 0) , ForceMode2D.Impulse)    ;
        GameManager.Instance.Play = true;
    }
}
