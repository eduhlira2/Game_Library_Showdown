using UnityEngine;
using System.Collections;

public class PlayerSelected : MonoBehaviour {
	public GameObject[] players;
	public int[] ids;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	public void SetPlayer(GameObject player, int id){
		for (int i = 0; i <= 3; i++) {
			if (id == i+1) {
				players [i] = player;
				ids [i] = id;
			}
		}
	}

	public void CleanPlayer(int id){
		for (int i = 0; i <= 3; i++) {
			if (ids [i] == id) {
				players [i] = null;
				ids [i] = 0;
			}
		}
	}
}
