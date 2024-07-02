using System;
using UnityEngine;
using System.Collections;

public enum TileType
{
    Normal,
    Obstacle,
    Breakable
}

[RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour {

    public int xIndex;
    public int yIndex;
    public TileType tileType = TileType.Normal;
    Board m_board;

    private SpriteRenderer _spriteRenderer;

    public int breakableValue = 0;
    public Sprite[] _breakableSprites;

    public Color normalColor;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start () 
    {
	
    }

    public void Init(int x, int y, Board board)
    {
        xIndex = x;
        yIndex = y;
        m_board = board;

        if (tileType == TileType.Breakable)
        {
            if (_breakableSprites[breakableValue] != null)
            {
                _spriteRenderer.sprite = _breakableSprites[breakableValue];
            }
        }

    }

    void OnMouseDown()
    {
        if (m_board !=null)
        {
            m_board.ClickTile(this);
        }

    }

    void OnMouseEnter()
    {
        if (m_board !=null)
        {
            m_board.DragToTile(this);
        }

    }

    void OnMouseUp()
    {
        if (m_board !=null)
        {
            m_board.ReleaseTile();
            //Animator.
        }

    }

    public void BreakTile()
    {
        if (tileType != TileType.Breakable)
        {
            return;
        }

        StartCoroutine(BreakTileRoutine());
    }

    IEnumerator BreakTileRoutine()
    {
        breakableValue = Mathf.Clamp(--breakableValue, 0, breakableValue);
        
        
        yield return new WaitForSeconds(0.25f);

        if (_breakableSprites[breakableValue] != null)
        {
            _spriteRenderer.sprite = _breakableSprites[breakableValue];
        }

        if (breakableValue == 0)
        {
            tileType = TileType.Normal;
            _spriteRenderer.color = normalColor;
        }
        
    }
}