using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject MovingCar;
    //Unityちゃんとカメラの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //オブジェクトを取得
        this.MovingCar = GameObject.Find("MovingCar");
        //カメラの位置（z座標）の差を求める
        this.difference = MovingCar.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y , this.MovingCar.transform.position.z + 15);
    }
}