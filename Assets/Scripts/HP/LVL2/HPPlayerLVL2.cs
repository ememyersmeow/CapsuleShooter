using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPplayerLVL2 : MonoBehaviour
{
    public static int HP = 500;
    public TMP_Text HPText;

    void Update()
    {
        HPText.text = HP + "";

        if (HP <= 100)
        {
            HPText.color = Color.red;
        }
        else
        {
            HPText.color = Color.white;
        }
    }
}

