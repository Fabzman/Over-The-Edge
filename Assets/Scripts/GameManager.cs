using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { TITLE, INGAME, WIN, LOSE}
public class GameManager : Singleton <GameManager> {

    public int mudLevel = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void IncreaseMud (int newMud)
    {
        mudLevel += newMud;
        Debug.Log("Mud Level: " + mudLevel.ToString());
        if (mudLevel >= 100)
            GameOver();
    }
}
