using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public string AxisName;
    public float SpeedMultiplier = 1;
    public float Axis { get; private set; }
    public int Score { get; private set; }
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Axis = Input.GetAxis(AxisName);
        transform.Translate( 0, Input.GetAxisRaw(AxisName) * Time.deltaTime * SpeedMultiplier, 0 );
    }

    public void IncrementScore(int score){
        Score += score;
    }
}
