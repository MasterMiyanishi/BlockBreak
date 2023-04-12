using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    // コライダーに何かが当たった時の処理
    void OnCollisionEnter(Collision collision)
    {
        // 何かが当たったらGameOverのシーンへ遷移する
        SceneManager.LoadScene("GameOver");
    }

}
