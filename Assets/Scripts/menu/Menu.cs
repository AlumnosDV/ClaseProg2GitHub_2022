using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField]
    private AudioClip _clip;

    private void Start()
    {
        AudioManager.instance.PlayAudio(_clip);
    }

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ParticleScene()
    {
        SceneManager.LoadScene("particleTest");
    }
}
