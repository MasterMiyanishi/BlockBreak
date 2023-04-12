using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // スコア
    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Blockのタグが付いたオブジェクトを検索し
        // その個数が0以下の場合ゲームクリア画面に遷移する
        if (GameObject.FindGameObjectsWithTag("Block").Length <= 0)
        {
            // GameClearのシーンへ遷移する
            SceneManager.LoadScene("GameClear");
        }
	}
}
