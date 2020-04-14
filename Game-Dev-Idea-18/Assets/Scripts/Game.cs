using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    const int AMOUNT_Of_Tiles_IN_FIGURA = 4;
    const int AMOUNT_Of_FIGURS = 7;

    List<GameObject> m_objs_list = new List<GameObject>();

    

    public Game()//constructer
    {
        Figurs();

        
    }
    
    public void Update(float deltaTime)
    {

    }

    public void Figurs()
    {
        GameObject Figurs = Resources.Load("Tile") as GameObject;
        List<List<GameObject>> List_of_figurs_list = new List<List<GameObject>>();
        List<GameObject> figurs_list = new List<GameObject>();
        for (int i = 0; i < AMOUNT_Of_FIGURS; i++)
        {
            for (int j = 0; j < AMOUNT_Of_Tiles_IN_FIGURA; j++)
            {
                GameObject m_figurs = GameObject.Instantiate(Figurs);
                figurs_list.Add(m_figurs);
                m_figurs.transform.position = new Vector3(i * 2, j * 1, 0);
            }
        }
    }
}











//GameObject go = Resources.Load("Tile") as GameObject;

//for (int i = 0; i < AMOUNT; i++)
//{
//    GameObject m_obj = GameObject.Instantiate(go);
//    m_objs_list.Add(m_obj);
//    m_obj.transform.position = new Vector3(i * 1.0f, 0, 0);
//}