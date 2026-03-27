using Unity.VisualScripting;
using UnityEngine;

public class ShameNumberTest : MonoBehaviour
{
    public GameObject Info1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShameChanger shame = GameObject.Find("Schaamte-meter").GetComponent<ShameChanger>();
        shame.ShameIncrease();
        Info1.SetActive(true);
        Destroy(gameObject);
    }


    
}
