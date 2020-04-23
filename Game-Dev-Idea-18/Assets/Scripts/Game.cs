using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    const int FIGURS = 7;//number of figurs
  
    GameObject m_currentFigure = null;//starting from null figure.

    Figures m_currentFigureType = Figures.I;//

    PrefabProvider m_provider = null;

    //m_currentBackground = GameObject.Instantiate(m_provider.)

    enum Figures
    {
        I = 1,
        S = 2,
        S_ = 3,
        O = 4,
        T = 5,
        L = 6,
        L_ = 7
    }

    public void Update(float deltaTime)
    {

    }
    public Game(PrefabProvider provider)//constructer
    {
        m_provider = provider;
        CreatRandomFigure();
        BackGround();
    }

    //choose a random figure
    private void CreatRandomFigure()
    {
        CreateFigure(Random.Range(1, FIGURS + 1));
    }

    //Create the figure
    private void CreateFigure(int randomIndex)
    {
        m_currentFigureType = (Figures)randomIndex;
        switch (m_currentFigureType)
        {
            case Figures.I:
                CreateTileByArray(new int[,] {
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 }
                });
                break;
                case Figures.S:
                CreateTileByArray(new int[,] {
                    { 0, 0, 0, 0, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
                case Figures.S_:
                CreateTileByArray(new int[,] {
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 1, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
            case Figures.O:
                CreateTileByArray(new int[,] {
                    { 0, 0, 0, 0, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
            case Figures.T:
                CreateTileByArray(new int[,] {
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 1, 1, 1, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
            case Figures.L:
                CreateTileByArray(new int[,] {
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 1, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
            case Figures.L_:
                CreateTileByArray(new int[,] {
                    { 0, 0, 1, 0, 0 },
                    { 0, 0, 1, 0, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                });
                break;
        }

    }

    //plasing the tile in evvery location of the arrat number 1
    private void CreateTileByArray(int[,] array)
    {
        m_currentFigure = GameObject.Instantiate(m_provider.FigurBase);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            { 
                if(array[i, j] == 1)
                {
                    CreateTile(i, j, m_currentFigure.transform);
                }
            }
        }
    }

    //here we create the tile and size of the tile
    private void CreateTile(int i, int j, Transform parentTransform)
    {
        GameObject go = Resources.Load("Tile") as GameObject;
        SpriteRenderer renderer = go.GetComponent<SpriteRenderer>();

        float size = 0f;

        if (renderer != null)
        {
            size = renderer.size.x;
        }

        GameObject obj = GameObject.Instantiate(go);

        float x = j * size - 2f * size;
        float y = i * size - 2f * size;
        float z = 0;

        obj.transform.position = new Vector3(x, y, z);
        obj.transform.parent = parentTransform;
    }

    public void RotateFigut()
    {
        switch (m_currentFigureType)
        {
            case Figures.I:
                if (m_currentFigure.transform.eulerAngles.z == 0)
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                }
                else
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, -90f));
                }
                break;
            case Figures.S:
                if (m_currentFigure.transform.eulerAngles.z == 0)
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                }
                else
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, -90f));
                }
                break;
            case Figures.S_:
                if (m_currentFigure.transform.eulerAngles.z == 0)
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                }
                else
                {
                    m_currentFigure.transform.Rotate(new Vector3(0, 0, -90f));
                }
                break;
            case Figures.O:
                break;
            case Figures.T:
                m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                break;
            case Figures.L:
                m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                break;
            case Figures.L_:
                m_currentFigure.transform.Rotate(new Vector3(0, 0, 90f));
                break;
        }
    }

    public void BackGround()
    {

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
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
                


            }
        }
    }
}