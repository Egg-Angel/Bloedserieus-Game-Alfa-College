using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    //Detection Point
    public Transform detectionPoint;
    //Detection Radius
    private const float detectionRadius = 0.2f;
    //Detection Layer
    public LayerMask detectionLayer;
    void Update()
    {
        if (DetectObject())
        {
            if (InteractInput())
            {
                Debug.Log("INTERACT");
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    //Check to see if intersecting with an object
    bool DetectObject()
    {
       return Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, detectionLayer);
       
    }
}
