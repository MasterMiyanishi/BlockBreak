using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour {

    // ボールの発射速度
    public float speed = 5f;

    // ボール発射済みかどうか
    bool ballShot = false;

    // ボールの最小速度
    float ballSpeedMin = 5f;
    // ボールの最大速度
    float ballSpeedMax = 20f;

    // Use this for initialization
    void Start () {

        // 右斜め上方向に発射する
		this.GetComponent<Rigidbody>().velocity = new Vector3(speed, speed, 0);

        // ボールを発射済みにする
        ballShot = true;

    }
	
	// Update is called once per frame
	void Update () {

        // ボールが発射されているときのみ実行する
        if (ballShot)
        {
            // ボールの現在の加速度を取得する
            float velocityX = this.GetComponent<Rigidbody>().velocity.x;
            float velocityY = this.GetComponent<Rigidbody>().velocity.y;

            // 速度の上限下限を設定する
            // Mathf.Clampは入力された値を指定された範囲に制限して出力する
            // Mathf.Absは入力された値の絶対値を取得する
            // Mathf.Signは入力された値の不等号を取得する マイナスなら-1　プラスなら1
            this.GetComponent<Rigidbody>().velocity = new Vector3(
                // 横方向の速度を設定する
                Mathf.Clamp(Mathf.Abs(velocityX), ballSpeedMin, ballSpeedMax) * Mathf.Sign(velocityX),
                // 縦方向の速度を設定する
                Mathf.Clamp(Mathf.Abs(velocityY), ballSpeedMin, ballSpeedMax) * Mathf.Sign(velocityY),
                // 奥方向は0を設定する
                0);

            // 速度が0の時はもう一度発射する
            if (velocityX == 0 || velocityY == 0)
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(speed, speed, 0);
            }
        }

    }
}
