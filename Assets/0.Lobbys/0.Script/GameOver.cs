using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameoverpanel;

    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        gameoverpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // !  = not 
        if (!player.gameObject.activeInHierarchy)
        {
            gameoverpanel.SetActive(true);
        }
    }

    public void OnRetrun()
    {

    }
    public void OnGameover()
    {
        SceneManager.LoadScene("Lobby Scene");
    }
}
