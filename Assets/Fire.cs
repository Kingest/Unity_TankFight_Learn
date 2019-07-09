using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    private Transform FireTransform;
    public GameObject FireBuller;
    private Rigidbody Frd;
    public float bulletspd;
    public KeyCode FireKey = KeyCode.Space;
    public AudioClip FireAudioClip;
	// Use this for initialization
	void Start () {
        FireTransform = transform.Find("FirePos");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(FireKey))
        {
            AudioSource.PlayClipAtPoint(FireAudioClip,transform.position);
            GameObject firebullet = Instantiate(FireBuller, transform.position, transform.rotation);
            Frd = firebullet.GetComponent<Rigidbody>();
            Frd.velocity = transform.forward * bulletspd;
            
        }
        
	}
}
