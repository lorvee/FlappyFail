using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	private Vector3 _flappyStartPosition;
	public Vector3 FlappyStartPosition{ set{ _flappyStartPosition = value; } }
	
	public Flappy FlappyCharacter;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void SetGameOver()
	{
		FlappyCharacter.gameObject.transform.position = _flappyStartPosition;
		//FlappyCharacter.gameObject.rigidbody2D.velocity = new Vector2(0, 0);
	}
}
