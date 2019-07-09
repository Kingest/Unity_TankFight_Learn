using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHP : MonoBehaviour {
    public int Hp = 100;
    public GameObject TankBoom;
    public AudioClip TankExpAudio;
    public Slider Hpslider;
    private int HPtotal;
	// Use this for initialization
	void Start () {
        HPtotal = Hp;//当前血量除以当前血量得到血量比例，并且把其应用到ui的slider上
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void TakeDamage()//第一种方法减少坦克的HP，需要collider.sendMessage
    {
        if (Hp == 0)
            return;
        Hp = Hp - Random.Range(10, 20);
        Hpslider.value = (float)Hp / HPtotal;
        if (Hp <= 0)
        {
            
            AudioSource.PlayClipAtPoint(TankExpAudio, transform.position);
            Destroy(gameObject);
            Instantiate(TankBoom, transform.position, transform.rotation);
            
        }

    }

    //private void OnTriggerEnter(Collider other)//第二种方法减少Tank的HP
    //{
    //    if (other.tag=="Shell")
    //    {
    //        Hp = Hp - Random.Range(10, 20);
    //    }
    //}
}
