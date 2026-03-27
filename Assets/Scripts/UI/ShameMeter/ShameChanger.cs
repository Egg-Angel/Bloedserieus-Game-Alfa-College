using UnityEngine;

public class ShameChanger : MonoBehaviour
{

    public GameObject LowShame;
    public GameObject BitShame;
    public GameObject HalfShame;
    public GameObject HighShame;
    public GameObject MaxShame;
    public int ShameScore = 1;


    void Update()
    {
        Debug.Log(ShameScore);
        if (ShameScore == 1)
        {
            LowShame.SetActive(true);
            BitShame.SetActive(false);
            HalfShame.SetActive(false);
            HighShame.SetActive(false);
            MaxShame.SetActive(false); 
        }
        else if (ShameScore == 2)
        {
            LowShame.SetActive(false);
            BitShame.SetActive(true);
            HalfShame.SetActive(false);
            HighShame.SetActive(false);
            MaxShame.SetActive(false);
        }
        else if (ShameScore == 3)
        {
            LowShame.SetActive(false);
            BitShame.SetActive(false);
            HalfShame.SetActive(true);
            HighShame.SetActive(false);
            MaxShame.SetActive(false);
        }
        else if (ShameScore == 4)
        {
            LowShame.SetActive(false);
            BitShame.SetActive(false);
            HalfShame.SetActive(false);
            HighShame.SetActive(true);
            MaxShame.SetActive(false);
        }
        else if (ShameScore == 5)
        {
            LowShame.SetActive(false);
            BitShame.SetActive(false);
            HalfShame.SetActive(false);
            HighShame.SetActive(false);
            MaxShame.SetActive(true);
        }
    }

    public void ShameIncrease()
    {
        ShameScore++;
    }
}
