using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Start_Game()
    {
    SceneManager.LoadScene("Testing");
    }
    public void Settings_Scene()
    {
        SceneManager.LoadScene("Settings_Scene");
    }
    public void Quit_Scene()
    {
        SceneManager.LoadScene("Quit_Scene");
    }
}
