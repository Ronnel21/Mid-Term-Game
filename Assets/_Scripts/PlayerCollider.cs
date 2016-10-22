using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    //Private Instance 
    private Transform _transform;
    private AudioSource[] _sounds;
    private AudioSource _collisionSound;

    //Public Instance (For Testing)
    public GameController gameController;

	// Use this for initialization
	void Start () {
        this._transform = this.GetComponent<Transform>();
        this._collisionSound = this._sounds[1];
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter2d(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            this.gameController.LivesValue -= 1;
            this._collisionSound.Play();
        }      
       
    }
}
