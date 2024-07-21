using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameSettings : ScriptableObject
{
    public int BoardSizeX = 5;

    public int BoardSizeY = 5;

    public int MatchesMin = 3;

    public int LevelMoves = 16;

    public float LevelTime = 30f;

    public float TimeForHint = 5f;

    public List<Sprite> sprFishes = new List<Sprite>();
    public void LoadData()
    {
        sprFishes.Clear();
        sprFishes = Resources.LoadAll<Sprite>("Textures/Fish").ToList();
    }
}
