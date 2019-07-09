using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Alieveble : MonoBehaviour {
    private Button Btn_StartGame;
    // Use this for initialization
    void Start () {
        Btn_StartGame = GetComponent<Button>();
        Btn_StartGame.onClick.AddListener(ScreenLoadStart);
	}
	
	// Update is called once per frame
	void Update () {
     
	}
    private void ScreenLoadStart()
    {
        SceneManager.LoadScene("Main");
    }
}
