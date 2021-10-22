using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager _instance;

    public static GameManager Instance {
        get {
            return _instance;
        }
    }
    private void Awake() {
        if (_instance == null) {
            _instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
    #endregion
    public bool Play = false;
    public TextMeshProUGUI text;
    public Paddle LeftPaddle;
    public Paddle RightPaddle;
    void Update(){
        text.SetText($"{LeftPaddle.Score} - {RightPaddle.Score}");
    }
}
