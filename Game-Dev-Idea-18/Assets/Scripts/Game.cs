using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    const int AMOUNT = 5; // ?למה רק עם אותיות גדולות

    List<GameObject> m_objs_list = new List<GameObject>();
    public Game()  // constructor
    {
        GameObject go = Resources.Load("Tile") as GameObject;
        for(int i = 0; i < AMOUNT; i++)
        {
            GameObject m_obj = GameObject.Instantiate(go);
            m_objs_list.Add(m_obj);
            m_obj.transform.position = new Vector3(0, i * 2.0f, 0);//the position of every object will be 2.0f of ech other
        }
    }
    public void Update(float deltaTime)
    {

    }

}
