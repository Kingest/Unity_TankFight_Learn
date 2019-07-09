using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameins : MonoBehaviour {
    public GameObject GameStartButton;
    private Button btn1;
	// Use this for initialization
	void Start () {
        btn1 = GetComponent<Button>();
        
	}
	
	// Update is called once per frame
	void Update () {
		btn1.onClick.AddListener(Ins);
	}
    private void Ins()
    {
        GameStartButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
