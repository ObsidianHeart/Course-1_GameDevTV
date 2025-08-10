using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float X = 0;
    [SerializeField] private float Y = 0;
    [SerializeField] private float Z = 0;
    //[SerializeField] private float Rotation_Speed = 0;

    void Start()
    {
        
    }

    void Update()
    { 
        Rotations();
    }

    void Rotations()
    {
        //X = X * Rotation_Speed * Time.deltaTime;
        //Y = Y * Rotation_Speed * Time.deltaTime;
        //Z = Z * Rotation_Speed * Time.deltaTime;
        transform.Rotate(X, Y, Z);
    }
}
