using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject BusCar;
    public GameObject OldCar;
    public GameObject TruckCar;

    private int startPos = 900;
    private int endPos = 780;

    private float posRange = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = startPos; i > endPos; i -= 45)
        {
            //レーンごとにアイテムを生成
            for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置く座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-15, 15);
                    if (1 <= item && item <= 2)
                    {
                        GameObject bus = Instantiate(BusCar);
                    bus.transform.rotation = Quaternion.Euler(0f, 90f, 0f); // Z軸に10°回転
                    bus.transform.position = new Vector3(posRange * j + 500, 1 , i + offsetZ);
                    }
                    else if ( 3 <= item && item <= 7)
				{
                    GameObject old = Instantiate(OldCar);
                    old.transform.rotation = Quaternion.Euler(0f, 90f, 0f); // Z軸に10°回転
                    old.transform.position = new Vector3(posRange * j + 500, 1 , i + offsetZ);
                }
                    else if (8 <= item && item <= 9)
                    {
                    GameObject truck = Instantiate(TruckCar);
                    truck.transform.rotation = Quaternion.Euler(0f, 90f, 0f); // Z軸に10°回転
                    truck.transform.position = new Vector3(posRange * j + 500, 1 , i + offsetZ);
                    }
             }
         
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
