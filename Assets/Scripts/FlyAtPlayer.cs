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
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPosition, Time.deltaTime * Speed);

    }
    void DestroyWhenReached()
    {
        if (Vector3.Distance(transform.position, PlayerPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
