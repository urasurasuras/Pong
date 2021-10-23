using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public string AxisName;
    public float SpeedMultiplier = 1;
    Rigidbody2D Rigidbody;
    public float Axis { get; private set; }
    public int Score { get; private set; }
     
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Axis = Input.GetAxis(AxisName);
        Rigidbody.velocity = new Vector3 ( 0, Input.GetAxisRaw(AxisName) * SpeedMultiplier, 0);
        //transform.Translate( 0, Input.GetAxisRaw(AxisName) * Time.deltaTime * SpeedMultiplier, 0 );
    }

    public void IncrementScore(int score){
        Score += score;
    }
}
