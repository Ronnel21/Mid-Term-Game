using UnityEngine;
using System.Collections;

//using UI elements
using UnityEngine.UI;

//Using scene management to switch scenes
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //Private Instance
    private int _scoreValue = 0;
    private int _livesValue = 5;
    private AudioSource _gameOver;
    
	// PUBLIC INSTANCE VARIABLES
	public int tankCount = 5;
	public GameObject tank;
    public GameObject playerTank;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text FinalScoreLabel;
    public Button RestartButton;
    
    //Public Properties
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }
        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0) //end the game
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }
	
	// Use this for initialization
	void Start () {		
        this.GameOverLabel.gameObject.SetActive(false);
        this.FinalScoreLabel.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(false);
        this._GenerateTanks ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate tanks
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}

    private void _endGame()
    {
        this.tank.SetActive(false);
        this.playerTank.SetActive(false);
        this.LivesLabel.gameObject.SetActive(false);
        this.ScoreLabel.gameObject.SetActive(false);
        this._gameOver.Play();
        this.GameOverLabel.gameObject.SetActive(true);
        this.FinalScoreLabel.text = "Final Score: " + this.ScoreValue;
        this.FinalScoreLabel.gameObject.SetActive(true);
        this.RestartButton.gameObject.SetActive(true);
    }

    //Public Methods
    public void restartButton_Click()
    {
        SceneManager.LoadScene("Menu");
    }
}
