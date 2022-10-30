using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
        DontDestroyOnLoad(this);
    }

    public void LoadStartLevel()
    {
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(this);
    }
}
