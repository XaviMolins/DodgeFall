using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float velocity = 5f; // Velocidad en unidades por segundo
    public float ticInterval = 0.1f; // Intervalo de tiempo en segundos entre cada tic

    private float ticTimer = 0f;

    private void Update()
    {
        ticTimer += Time.deltaTime;

        if (ticTimer >= ticInterval)
        {
            float moveDistance = velocity * ticTimer;
            transform.Translate(Vector3.up * moveDistance);
            ticTimer = 0f;
        }
    }
}