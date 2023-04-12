using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

    // パドルの移動速度
    public float speed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // キー入力を受け付ける
        float inputX = Input.GetAxis("Horizontal");

        // パドルを移動する
        this.GetComponent<Rigidbody>().velocity = new Vector3(inputX * speed, 0, 0);
        //transform.Translate(inputX * speed * Time.deltaTime, 0, 0);

	}
}
