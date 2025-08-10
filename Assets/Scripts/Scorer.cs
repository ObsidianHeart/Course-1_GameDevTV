using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "HitObject")
        {
            hits++;
            Debug.Log("Object Hit: " + hits);
        }
        
    }
}
