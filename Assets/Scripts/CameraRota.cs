using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRota : MonoBehaviour
{
    //transform.RotateAround(どこを中心とするか(Vector3), どの軸で回るか(Vector3), 回転させる角度(float))
    //プレイヤーを変数に格納
    public GameObject Stage;

    //回転させるスピード
    public float rotateSpeed = 3.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //回転させる角度
        float angle = Input.GetAxis("Horizontal") * rotateSpeed;

        //プレイヤー位置情報
        Vector3 stagePos = Stage.transform.position;

        //カメラを回転させる
        transform.RotateAround(stagePos, Vector3.up, angle);
    }
}