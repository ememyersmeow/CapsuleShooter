using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject trigger;
    public string sceneName;
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
