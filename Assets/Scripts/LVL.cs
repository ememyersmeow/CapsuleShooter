using TMPro;
using UnityEngine;

public class LVL : MonoBehaviour
{
    [SerializeField]private int keyValue;
    private int currentKeyValue;
    public TMP_Text keyText;
    public GameObject wall;
    public GameObject wall2;

    void Awake()
    {
        currentKeyValue = keyValue + 1;
    }
    void Update()
    {
        if (keyValue == currentKeyValue)
        {
            Destroy(wall.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keyValue++;
            keyText.text = "Keys: " + keyValue;
            Update();
            Destroy(gameObject);
        }

        if (currentKeyValue == 5)
        {
            Destroy(wall2.gameObject);
        }
    }
}