using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlane : MonoBehaviour {
    private const uint BLOCK_SIZE_RATIO = 3;
    public const uint INITIAL_BLOCK_NUM = 4;

    private GameObject m_gbThis;


	// Use this for initialization
	void Start () {
        m_gbThis = this.gameObject;
        ResetGrid();
    }

    void ResetGrid()
    {
        uint nPlayerLevel = GameManager.m_playerData.m_nLevel;
        uint nRowNum = nPlayerLevel + INITIAL_BLOCK_NUM;
        uint nColNum = nPlayerLevel + INITIAL_BLOCK_NUM;

        //set the size of the plane texture
        Vector3 vecScale = new Vector3(nRowNum * BLOCK_SIZE_RATIO, 1, nColNum * BLOCK_SIZE_RATIO);
        m_gbThis.transform.localScale = vecScale;

        //set the tiling or scale of the main texture
        this.GetComponent<Renderer>().material.mainTextureScale = new Vector2(nColNum, nRowNum); ;
    }
}
