using UnityEngine;
using System.Collections;

//reference to UI elements
using UnityEngine.UI;

//reference to control scenes
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    //Public Instance
    public Button StartButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartButton_Click()
    {
        SceneManager.LoadScene("Main");
    }
}
