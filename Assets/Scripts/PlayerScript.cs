using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public float flapStrength = 10;
    public LogicScript logic;
    public bool birdAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdAlive == true) {
            rigidbody.linearVelocity = Vector2.up * flapStrength; 
        }

        if(rigidbody.position.y >= 22) {
            logic.gameOver();
            birdAlive = false;
        }
        else if(rigidbody.position.y <= -22) {
            logic.gameOver();
            birdAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdAlive = false;
    }
}
