using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
	// FrontRowEnemy
    // Red enemies = 10 points

	// SecondRowEnemy
    // Green enemies = 25 points

	// ThirdRowEnemy
    // Black enemies = 50 points

	// BackRowEnemy
    // Purple enemies = 100 points


    public int scoreCount = 0000;
    public TextMeshProUGUI scoreText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Hi!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("FrontRowEnemy"))
		{
			Debug.Log("First Row Enemy!");
			scoreCount += 10; 
			scoreText.text = $"SCORE\n {scoreCount.ToString()}";
		}
		if (gameObject.CompareTag("SecondRowEnemy"))
		{
			scoreCount += 25; 
			scoreText.text = $"SCORE\n {scoreCount.ToString()}";
		}
		if (gameObject.CompareTag("ThirdRowEnemy"))
		{
			scoreCount += 50; 
			scoreText.text = $"SCORE\n {scoreCount.ToString()}";
		}
		if (gameObject.CompareTag("BackRowEnemy"))
		{
			scoreCount += 100; 
			scoreText.text = $"SCORE\n {scoreCount.ToString()}";
		}
    }
}

