using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background
{
    GameObject m_BgBase = null;

    float BGLength = 11f;
    float BGHight = 20f;
    PrefabProvider m_provider = null;
    public Background(PrefabProvider provider)
    {
        m_provider = provider;
        CreateBG();
    }

    private void CreateBG()
    {
        m_BgBase = GameObject.Instantiate(m_provider.BGBase);
        CreateBGTileByArray(m_BgBase.transform);
    }

    private void CreateBGTileByArray(Transform BGparentTransform)
    {
        SpriteRenderer renderer = m_provider.BackGroundCell.GetComponent<SpriteRenderer>();
        
        float sizeX = 0f;
        float sizeY = 0f;

        if (renderer != null)
        {
            sizeX = renderer.size.x * renderer.transform.localScale.x;
            sizeY = renderer.size.y * renderer.transform.localScale.y;
        }

        float shiftX = 5 * sizeX;
        float shiftY = 9 * sizeY;

        for (int i = 0; i < BGHight; i++)
        {
            for (int j = 0; j < BGLength; j++)
            {
                GameObject cell = GameObject.Instantiate(m_provider.BackGroundCell);
                Vector3 position = cell.transform.position;
                position.x = sizeX * j - shiftX;
                position.y = sizeY * i - shiftY;
                cell.transform.position = position;
                cell.transform.parent = BGparentTransform;
            }
        }
    }
}
   