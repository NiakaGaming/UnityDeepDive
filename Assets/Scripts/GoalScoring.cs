using UnityEngine;

public class GoalScoring : MonoBehaviour
{
    public BallRespawn ball;

    void OnTriggerEnter (Collider other)
    {
        Debug.Log ("GOAAAAAAAAAL");
        ball.RespawnBall();
    }
}
