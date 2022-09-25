using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public AudioClip GhostStateNormal;
    [SerializeField]
    public AudioClip BackGroundIntroMusic;

    void Start()
    {
        StartCoroutine(gameInitialized());
    }

 

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator gameInitialized()
    {
        GetComponent<AudioSource>().clip = BackGroundIntroMusic;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(BackGroundIntroMusic.length);
        GetComponent<AudioSource>().clip = GhostStateNormal;
        GetComponent<AudioSource>().Play();
    }
}
