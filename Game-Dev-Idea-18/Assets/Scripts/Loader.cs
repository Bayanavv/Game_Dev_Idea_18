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

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            m_game.moveFigure(-1,0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_game.moveFigure(1, 0);
        }
    }
}
