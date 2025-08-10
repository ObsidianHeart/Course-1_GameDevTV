using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("Object Hit: " + collision.gameObject.name);
            gameObject.tag = "HitObject"; // Change the tag to "HitObject"
        }
        
    }
}
