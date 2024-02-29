using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HPplayerLVL2 : MonoBehaviour
{
    public int HP = 500;
    public TMP_Text HPText;
    public Transform player;


    void Update()
    {
        HPText.text = HP + "";

        if (HP <= 130)
        {
            HPText.color = Color.red;
        }
        else
        {
            HPText.color = Color.white;
        }

        Die();
    }

    public void Die()
    {
        if(HP <= 0)
        {
            Destroy(player);
            SceneManager.LoadScene(3);
        }
    }
}

