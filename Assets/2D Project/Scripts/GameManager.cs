using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // FrontRowEnemy
    // Red enemies = 10 points

    // SecondRowEnemy
    // Green enemies = 25 points

    // ThirdRowEnemy
    // Black enemies = 50 points

    // BackRowEnemy
    // Purple enemies = 100 points
    
    public float scoreCount = 0000f;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        // todo - sign up for notification about enemy death 
        Enemy.OnEnemyDied += OnEnemyDied;
        
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        Enemy.OnEnemyDied -= OnEnemyDied;
    }
    
    void OnEnemyDied(float score)
    {
        Debug.Log($"Killed enemy worth {score}");
        scoreCount += score;
        scoreText.text = $"SCORE\n {scoreCount.ToString()}";
    }
    
}