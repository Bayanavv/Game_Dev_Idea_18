using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    private Game m_game = null;

    void Start()
    {
        m_game = new Game();
    }

    void Update()
    {
        m_game.Update(Time.deltaTime);
    }
}
