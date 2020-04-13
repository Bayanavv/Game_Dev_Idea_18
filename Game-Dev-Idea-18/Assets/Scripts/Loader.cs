using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    private Game m_game = null; //למה כותבים עם אמ
    private float m_time = 0f;
    private float m_time_destroy = 0f;

    void Start()
    {
        m_game = new Game();
    }

    void Update()
    {
        m_game.Update(Time.deltaTime);

        m_time_destroy += Time.deltaTime;
        m_time += Time.deltaTime;
    }
}
