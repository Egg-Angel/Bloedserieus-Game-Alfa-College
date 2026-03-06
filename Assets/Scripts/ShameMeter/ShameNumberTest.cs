using Unity.VisualScripting;
using UnityEngine;

public class ShameNumberTest : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("it worked");
        ShameChanger shame = GameObject.Find("Schaamte-meter").GetComponent<ShameChanger>();
        shame.ShameIncrease();
        Destroy(gameObject);
    }


    
}
