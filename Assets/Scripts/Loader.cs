using UnityEngine;

namespace Completed
{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;			//GameManager prefab to instantiate.
		public GameObject soundManager;			//SoundManager prefab to instantiate.
		public GameObject playerManager;		//PlayerManager prefab to instantiate.
		
		void Awake ()
		{
			//Check if a PlayerManager has already been assigned to static variable GameManager.instance or if it's still null
			if (PlayerManager.instance == null)
				
				//Instantiate SoundManager prefab
				Instantiate(playerManager);
			
			//Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
			if (GameManager.instance == null)
				
				//Instantiate gameManager prefab
				Instantiate(gameManager);
			
			//Check if a SoundManager has already been assigned to static variable GameManager.instance or if it's still null
			if (SoundManager.instance == null)
				
				//Instantiate SoundManager prefab
				Instantiate(soundManager);
		}
	}
}