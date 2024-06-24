using UnityEngine;
using System.Collections;

public class GamePiece : MonoBehaviour {

    public int xIndex;
    public int yIndex;

    // Use this for initialization
    void Start () 
    {
	
    }
	
    // Update is called once per frame
    void Update () {
	
    }

    public void SetCoord(int x, int y)
    {
        xIndex = x;
        yIndex = y;
    }


}