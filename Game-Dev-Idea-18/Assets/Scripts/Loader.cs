using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    private float m_time = 0f;
    private Game m_game = null;

    void Start()
    {
        PrefabProvider provider = gameObject.GetComponent<PrefabProvider>();
        m_game = new Game(provider);
    }

    void Update()
    {
        m_game.Update(Time.deltaTime);
    }
}
