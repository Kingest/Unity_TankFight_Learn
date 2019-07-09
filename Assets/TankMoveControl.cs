using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMoveControl : MonoBehaviour {
    public float spd;
    public float rotspd;
    public int playernum;
    
    
    private Rigidbody rd;

    // Use this for initialization
    void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        rd = GetComponent<Rigidbody>();
        
        float v = Input.GetAxis("VerticalPlayer"+playernum);
        float h = Input.GetAxis("HorizontalPlayer"+playernum);
        rd.velocity = transform.forward * v * spd;//前后控制
        rd.angularVelocity = transform.up * h * spd;
       
        
    }
}
