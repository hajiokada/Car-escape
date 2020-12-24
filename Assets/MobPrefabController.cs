using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobPrefabController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private float SpeedZ = -10f;

    // Start is called before the first frame update
    void Start()
    {
        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        float inputSpeed = Random.Range(-14, -18);

        this.myRigidbody.velocity = new Vector3(0, 0, inputSpeed);
    }
}