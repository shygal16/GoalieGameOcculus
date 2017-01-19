using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
    public bool Alive = true;
	// Use this for initialization
	void Awake () {
     }
	void ShooterScore()
    {
        Alive = false;
        this.gameObject.SetActive(Alive);
    }
    void GoalieScore()
    {
        Alive = false;
        this.gameObject.SetActive(Alive);
    }
	// Update is called once per frame
	void Update () {
	}
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            ShooterScore();
        }
        if(collision.gameObject.CompareTag("Goalie"))
        {
            GoalieScore();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.CompareTag("PlayArea"))
        {
            GoalieScore();
        }
    }
}
