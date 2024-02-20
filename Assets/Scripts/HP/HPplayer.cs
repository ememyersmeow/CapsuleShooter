using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPplayer : MonoBehaviour
{
    public static int HP = 100;  
    public TMP_Text HPText;

    void Update()
    {
        HPText.text = HP + "";

        if(HP <= 25)
        {
            HPText.color = Color.red;
        }
        else
        {
            HPText.color = Color.white;
        }
    }
}
