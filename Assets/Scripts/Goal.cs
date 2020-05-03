using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [HideInInspector]
    public GameManager.Player player;

    // When the goal receives the ball | When the ball hits the goal...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            GameManager.gm.PlaySFX(Constants.SoundTracks.GoalGet); // ...play goal sound effect
            GameManager.gm.AddPointTo(player);                     // ...give point to the player
            GameManager.gm.ball.ResetBall();                       // ...move the ball back to the center
        }
    }
}
