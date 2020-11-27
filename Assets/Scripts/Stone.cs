using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
	public GameObject explosion;
	
    private const float yDie = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
			
        }
    }
    void OnMouseDown(){
		Instantiate(explosion,transform.position,Quaternion.identity);
		Destroy(gameObject);
		if (gameObject.tag == "Capsule")
		{
			GameManager.currentNumberDestroyedStones--;
		}
		else
		{
			GameManager.currentNumberDestroyedStones++;
		}
		print(gameObject.ToString());
    }
}
