using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem explosion;

    public void GameOver()
    {
        gameObject.SetActive(false);
        Invoke("Reload", 2);
        explosion.transform.position = transform.position;
        explosion.Play();
    }

    void Reload ()
    {
        SceneManager.LoadScene(0);
    }

    void Start()
    {
        explosion.Stop();
    }
}


