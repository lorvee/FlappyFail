using UnityEngine;
using System.Collections;

public class Flappy : MonoBehaviour {

	public float YSpeed = 5;
	public float XSpeed = 5;
	public float FlyingPower = 20;
	public Main MainGame;
	// Use this for initialization
	void Start () {
		//Debug.Log("Trigger: " + collider.isTrigger);
		MainGame.FlappyStartPosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float translateX = XSpeed * Time.deltaTime;
		float translateY = 0;
		if(Input.GetKey(KeyCode.Space)) {
			translateY = FlyingPower * Time.deltaTime;
		}
		translateY -= YSpeed * Time.deltaTime;
		gameObject.transform.Translate( new Vector3(translateX, translateY, 0));
	}
	//function OnCollisionEnter2D(Collision2D collision)
	void OnCollisionEnter2D(Collision2D collision)
	{
		//if(collision.gameObject.tag == "Tubo")
				MainGame.SetGameOver();
	}
}
