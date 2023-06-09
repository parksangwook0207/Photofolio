using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]  private GameObject gameoverpanel;

    [SerializeField] private Player player;
    
    // Start is called before the first frame update

    private void Awake()
    {
        gameoverpanel.SetActive(false);        
    }


    // Update is called once per frame
    void Update()
    {       
        if (player.gameObject.activeInHierarchy == false)
        {
            gameoverpanel.SetActive(true);
        }
    }

    public void OnRetrun()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        
    }
    public void OnGameover()
    {
        SceneManager.LoadScene("Lobby Scene");
        Time.timeScale = 1f;
    }
}
