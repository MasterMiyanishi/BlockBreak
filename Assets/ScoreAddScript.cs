using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAddScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // スコア表示
        this.GetComponent<Text>().text = 
            GameObject.Find("GameController").GetComponent<GameController>().score.ToString();

	}
}
