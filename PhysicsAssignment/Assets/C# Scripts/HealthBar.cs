using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 1.0f;
    public float currentHealth = 0f;
    public int lifes = 3;
    float counter = 3.0f;
    public Image playerHealth;
    public GameObject healthBar;
    public GameObject playerCharacter;
    
    

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("Bar");
        playerHealth = healthBar.GetComponent<Image>();
        currentHealth = maxHealth;
        playerCharacter = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementCheck = playerCharacter.GetComponent<PlayerMovement>().movement.sqrMagnitude;

        if (currentHealth <= 0)
        {
            if (counter == 3)
            {
                if (lifes > 1)
                {
                    lifes--;
                }

                else
                {
                    GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().EndGame();
                }
            }
            counter -= Time.deltaTime;
            Debug.Log("Counter: " + counter);

            if (counter <= 0)
            {
                currentHealth = maxHealth;
                counter = 3.0f;
            }
        }

        if (movementCheck > 0)
        {

            if (currentHealth < 1)
            {
                currentHealth += 0.01f;
                playerHealth.fillAmount = currentHealth;
                counter = 3.0f;
            }

        }
        else if (currentHealth >= 0)
        {


            currentHealth -= 0.01f;
            playerHealth.fillAmount = currentHealth;

        }
        // Debug.Log(currentHealth);
        Debug.Log("Lifes: " + lifes);
    }
}
