using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HPplayer : MonoBehaviour
{
    public int currentHP;
    public int maxHP;
    public int redHp;
    public int addHP;
    public TMP_Text HPText;
    public Transform player;

    void Update()
    {
        HPText.text = currentHP.ToString() + "";

        if(currentHP <= redHp)
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
        if (currentHP <= 0)
        {
            Destroy(player);
            SceneManager.LoadScene(3);
        }
    }
}
