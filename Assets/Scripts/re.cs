using UnityEngine;
using System.Collections;

public class re : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		{
			
		

			Destroy (col.gameObject);
		
			StartCoroutine("ReloadGame");
		}
		else
		{
			
			Destroy (col.gameObject);	
		}
	}

	IEnumerator ReloadGame()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(2);
		// ... and then reload the level.
		Application.LoadLevel("Gameplay");
	}
}
