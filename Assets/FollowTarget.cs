using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowTarget : MonoBehaviour {
    public Transform player1;
    public Transform player2;
    private Vector3 targetPoint;
    public Camera camera;
	// Use this for initialization
	void Start () {
        targetPoint = transform.position-(player1.position + player2.position) / 2;//得到中心点
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player1 == null || player2 == null)//如果玩家挂了的话，回到初始场景
        {
            SceneManager.LoadScene("StartScene");
        }
        transform.position = targetPoint + (player1.position + player2.position) / 2 + targetPoint;//再逆向操作
        float distance = Vector3.Distance(player1.position, player2.position);//得到两点间的距离
        float size = 0.58f * distance;//在insp页面上得到0.58的比例，在乘以距离，得到和摄像头的大小比
        camera.orthographicSize = size;//正交比赋值
    }
}
