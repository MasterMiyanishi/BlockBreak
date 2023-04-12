using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // コライダーに何かが当たった時の処理
    void OnCollisionEnter(Collision collision)
    {
        // スコアを加算する
        GameObject.Find("GameController").GetComponent<GameController>().score++;

        // 何かが当たったら自分を削除する
        Destroy(this.gameObject);
    }

}
