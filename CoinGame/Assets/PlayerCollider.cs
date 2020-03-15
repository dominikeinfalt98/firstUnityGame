using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerCurrencyController currencyController;
    Rigidbody2D rigidbody2D;
	private bool isColliding;
    // //AudioSource audio;
    
    void Awake() {
        //audio = GetComponent<AudioSource>();
		rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
	void Update()
	{
		isColliding = false;
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if(isColliding) return;
		isColliding = true;

		if (other.gameObject.CompareTag("Coin"))
		{
			Destroy(other.gameObject);
			currencyController.increaseCoinCount();
		}
		else if (other.gameObject.CompareTag("Deathbox"))
		{
			//Destroy(gameObject);
			SceneManager.LoadScene( SceneManager.GetActiveScene().name);
		}

		// switch(true)
		// {
		// 	case other.gameObject.CompareTag("Coin"):
		// 		Destroy(other.gameObject);
		// 		currencyController.increaseCoinCount();
		// 		break;
		// 	case other.gameObject.CompareTag("Deathbox"):
		// 		Destroy(gameObject);
		// 		SceneManager.LoadScene( SceneManager.GetActiveScene().name);
		// 		break;
		// }

 	}

}
