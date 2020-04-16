using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    const int AMOUNT = 5;
    const int FIGURS = 7;
    const int TILE_SIZE = 32;

    GameObject m_currentFigure = null;
    PrefabProvider m_provider = null;

    public void Update(float deltaTime)
    {

    }
    public Game(PrefabProvider provider)//constructer
    {
        m_provider = provider;
        CreatRandomFigure();
    }

    private void CreatRandomFigure()
    {
        CreateFigure(Random.Range(1, FIGURS + 1));
    }

    private void CreateFigure(int randomIndex)
    {
        switch(randomIndex)
        {
            case 1:
                CreateTileByArray(new int[,] { { 0, 0, 1, 0 },{ 0, 0, 1, 0 },{ 0, 0, 1, 0 },{ 0, 0, 1, 0 } });
                break;
            case 2:
                CreateTileByArray(new int[,] { { 0, 0, 1, 0 },{ 0, 1, 1, 1 },{ 0, 0, 0, 0 },{ 0, 0, 0, 0 } });
                break;
            case 3:
                CreateTileByArray(new int[,] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 },{ 0, 0, 1, 1 },{ 0, 0, 0, 0 } });
                break;
            case 4:
                CreateTileByArray(new int[,] { { 0, 0, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 1, 0 },{ 0, 0, 0, 0 } });
                break;
            case 5:
                CreateTileByArray(new int[,] { { 0, 0, 1, 0 }, { 0, 0, 1, 0 },{ 0, 1, 1, 0 },{ 0, 0, 0, 0 } });
                break;
            case 6:
                CreateTileByArray(new int[,] { { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 1 }, { 0, 0, 0, 0 } });
                break;
            case 7:
                CreateTileByArray(new int[,] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } });
                break;
        }

    }

    private void CreateTileByArray(int[,] array)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            { 
                if(array[i, j] == 1)
                {
                    CreateTile(i,j);
                }
            }
        }
    }

    private void CreateTile(int i, int j)
    {
        GameObject parent = new GameObject();
        //parent.AddComponent<Transform>();
        m_currentFigure = GameObject.Instantiate(parent, m_provider.FigureStartPoint.transform);//put the figur in spicific point

        GameObject go = Resources.Load("Tile") as GameObject;
        GameObject m_obj = GameObject.Instantiate(go, m_currentFigure.transform);
        go.transform.position = new Vector3(i * TILE_SIZE - 1.5f * TILE_SIZE, j * TILE_SIZE - 1.5f * TILE_SIZE, 0);
    }
}