using UnityEditor.AnimatedValues;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField]  GameObject ball;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ball.SetActive(true);
        }
    }
}
