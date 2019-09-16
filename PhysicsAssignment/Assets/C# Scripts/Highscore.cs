using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text scoreText;
    long score = 0;
    float counter = 0.0f;
    public HealthBar healthBar;

    
    // Start is called before the first frame update
    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score: " + score);
        scoreText.text = ("Lifes: " + healthBar.lifes.ToString() +  "  Score: " + score.ToString());
        counter += Time.deltaTime;
        score += (long)(counter * 0.75);
        
    }
    
}
