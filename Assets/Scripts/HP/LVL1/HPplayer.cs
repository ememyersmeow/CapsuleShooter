using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPplayer : MonoBehaviour
{
    public int HP = 100;  
    public TMP_Text HPText;

    void Update()
    {
        HPText.text = HP.ToString() + "";

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
