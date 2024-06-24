using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    public int xIndex;
    public int yIndex;

    Board m_board;

    // Use this for initialization
    void Start () 
    {
	
    }

    public void Init(int x, int y, Board board)
    {
        xIndex = x;
        yIndex = y;
        m_board = board;

    }
}