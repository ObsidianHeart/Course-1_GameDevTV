using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] private float Speed = 1f;
    [SerializeField] private Transform PlayerTransform;
    Vector3 PlayerPosition;
    void Start()
    {
        PlayerPosition = PlayerTransform.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPosition, Time.deltaTime*Speed);
    }
}
