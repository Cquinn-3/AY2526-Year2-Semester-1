using UnityEngine;

public class newScenes : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("win");
    }
}
