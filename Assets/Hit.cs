using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    public GameObject Boom;
    
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void OnTriggerEnter(Collider collider)
    {
        Instantiate(Boom,transform.position,transform.rotation);
        Destroy(gameObject);
        if (collider.tag == "Tank")
        {
            collider.SendMessage("TakeDamage");//传递消息，“”内为类名
        }
    }

}
