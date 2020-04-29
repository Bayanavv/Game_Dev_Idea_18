using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    
    private Game m_game = null;

    void Start()
    {
        PrefabProvider provider = gameObject.GetComponent<PrefabProvider>();
        m_game = new Game(provider);
    }
    
   
    void Update()
    {
        m_game.Update(Time.deltaTime);
        KeyBoardController();
    }

    private void KeyBoardController()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_game.RotateFigut();
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_game.moveFigure(-1,0);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_game.moveFigure(1, 0);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - m_game.fall >= m_game.fallSpeed)
        {
            m_game.moveFigure(0, -1);

            m_game.fall = Time.time;
        }
    }
}
