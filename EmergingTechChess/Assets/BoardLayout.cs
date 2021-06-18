using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Board/Layout")]
public class BoardLayout : ScriptableObject
{
    [Serializable]
    public class BoardSetup
    {
        public Vector2Int position;
        public Piece pieceType;
        public TeamColor teamColor;
    }

    [SerializeField] private BoardSetup[] boardTiles;

    public int GetPiecesCount()
    {
        return boardTiles.Length;
    }

    public Vector2Int GetCoordAtIndex(int index)
    {
        if(boardTiles.Length <= index)
        {
            Debug.Log("index out of range");
            return new Vector2Int(-11, -1);
        }
        return new Vector2Int(boardTiles[index].position.x - 1, boardTiles[index].position.y - 1);
    }

    public string GetSquarePieceName(int index)
    {
        if (boardTiles.Length <= index)
        {
            Debug.Log("index out of range");
            return "";
        }
        return boardTiles[index].pieceType.ToString();
    }

    public TeamColor GetTeamColorAtIndex(int index)
    {
        if (boardTiles.Length <= index)
        {
            Debug.Log("index out of range");
            return TeamColor.WHITE;
        }
        return boardTiles[index].teamColor;
    }
}
