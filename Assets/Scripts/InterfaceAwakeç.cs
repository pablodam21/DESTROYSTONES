using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAwakeç : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        GameManager.currentNumberDestroyedStones = 0;
		GameManager.currentNumberStonesThrown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void Click(){
		Application.LoadLevel ("stoneGame");
	}
}
