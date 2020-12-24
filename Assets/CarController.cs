using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private float velocityZ = -20f;

    //横方向の速度（追加）
    private float velocityX = 5f;

    // Start is called before the first frame update
    void Start()
    {
        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        //左矢印キーを押した時左へいく
        float inputVelocityX = 0;

        //Unityちゃんを矢印キーまたはボタンに応じて左右に移動させる（追加）
        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x < 503.5f)
        {
            //左方向への速度を代入（追加）
            inputVelocityX = this.velocityX;
            myTransform.Rotate(0f, -0.2f, 0f, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x > 496.5)
        {
            //右方向への速度を代入（追加）
            inputVelocityX = -this.velocityX;
            myTransform.Rotate(0f, 0.2f, 0f, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocityZ = -15f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            velocityZ = -25f;
        }
        else
		{
            velocityZ = -20f;
        }

        //Unityちゃんに速度を与える（変更）
        this.myRigidbody.velocity = new Vector3(inputVelocityX, 0, velocityZ);

        if (inputVelocityX == 0) 
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f); // Z軸に10°回転
        }
    }
}
