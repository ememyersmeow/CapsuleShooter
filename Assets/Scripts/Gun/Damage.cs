using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<HPplayer>().currentHP -= damage;
        }
    }
}
