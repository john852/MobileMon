using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {
    public GameObject Block;
    private const uint BLOCK_SIZE_RATIO = 30;

    private Vector2 m_vecRowCol;

    // Use this for initialization
    void Start () {
        ResetColSize();
    }

    public void InitializeBlocks()
    {
        ResetColSize();
        this.transform.position = new Vector3(- (m_vecRowCol.x/ 2 - BLOCK_SIZE_RATIO/2), 0, (m_vecRowCol.y / 2 - BLOCK_SIZE_RATIO / 2));
    }

    public void ResetColSize()
    {
        uint nPlayerLevel = (!GameManager.m_playerData)? 1 : GameManager.m_playerData.m_nLevel;
        m_vecRowCol = new Vector2((nPlayerLevel + GridPlane.INITIAL_BLOCK_NUM) * BLOCK_SIZE_RATIO,
            (nPlayerLevel + GridPlane.INITIAL_BLOCK_NUM) * BLOCK_SIZE_RATIO);
    }
	
	public void CreateNewBlock()
    {

    }
}
