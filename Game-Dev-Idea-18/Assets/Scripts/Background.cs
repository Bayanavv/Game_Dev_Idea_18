using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background 
{
    GameObject m_currentBG = null;//starting from null figure.
    PrefabProvider m_provider = null;

    public Background(PrefabProvider provider)
    {
        m_provider = provider;
        CreateBG();
    }

    private void CreateBG()
    {
        CreateBGTileByArray();
        //    (new int[,] {
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        //});
    }

    private void CreateBGTileByArray()
        //int[,] array)
    {
        m_currentBG = GameObject.Instantiate(m_provider.Background);
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                CreateBGTile(i, j, m_currentBG.transform);

                //if (array[i, j] == 0)
                //{
                //    CreateBGTile(i, j, m_currentBG.transform);
                //}
            }
        }
    }

    private void CreateBGTile(int i, int j, Transform parentTransform)
    {
        GameObject backGround_go = Resources.Load("BackGroundTile") as GameObject;
        SpriteRenderer renderer = backGround_go.GetComponent<SpriteRenderer>();
        float size = 0f;

        if (renderer != null)
        {
            size = renderer.size.x;
        }

        GameObject backGround_obj = GameObject.Instantiate(backGround_go);

        float x = j * size - 2f * size;
        float y = i * size - 2f * size;
        float z = 5;

        backGround_go.transform.position = new Vector3(x, y, z);
        backGround_go.transform.parent = parentTransform;


        
    }
}
