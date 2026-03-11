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

	// enemyAmount is 17
	// public int enemyAmount = 17;
    
    public float scoreCount = 0000f;
    public TextMeshProUGUI scoreText;

	public float highScoreCount = 0000f;
	public TextMeshProUGUI highScoreText;
    
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

		if (scoreCount < 100)
		{
			scoreCount += score;
        	scoreText.text = $"SCORE\n 00{scoreCount.ToString()}";

			if (scoreCount > 100)
			{
				scoreCount += score;
        		scoreText.text = $"SCORE\n 0{scoreCount.ToString()}";
			}
		}
		else if (scoreCount < 1000)
		{
			scoreCount += score;
        	scoreText.text = $"SCORE\n 0{scoreCount.ToString()}";
		}
		else
		{
			scoreCount += score;
        	scoreText.text = $"SCORE\n {scoreCount.ToString()}";
		}
		if (highScoreCount < scoreCount && highScoreCount < 100)
		{
			highScoreCount += score;
			highScoreText.text = $"HI-SCORE\n 00{highScoreCount.ToString()}";

			if (highScoreCount > 100)
			{
				highScoreCount += score;
        		highScoreText.text = $"SCORE\n 0{scoreCount.ToString()}";
			}
			/*highScoreCount = PlayerPrefs.GetFLoat("High_Score", highScoreCount);
			PlayerPrefs.SetFloat("High_Score", highScoreCount);
			PlayerPrefs.Save();*/
		}
		else if (highScoreCount < scoreCount && highScoreCount < 1000)
		{
			highScoreCount += score;
			highScoreText.text = $"HI-SCORE\n 0{highScoreCount.ToString()}";
			/*highScoreCount = PlayerPrefs.GetFLoat("High_Score", highScoreCount);
			PlayerPrefs.SetFloat("High_Score", highScoreCount);
			PlayerPrefs.Save();*/
		}
		else
		{
			highScoreCount += score;
        	highScoreText.text = $"SCORE\n {scoreCount.ToString()}";
			/*highScoreCount = PlayerPrefs.GetFLoat("High_Score", highScoreCount);
			PlayerPrefs.SetFloat("High_Score", highScoreCount);
			PlayerPrefs.Save();*/
		}
    }
    
}