using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float P_Speed;
    void Start()
    {
        P_Speed = player.GetComponent<PlayerMove>().Speed;
        
        Debug.Log(P_Speed);
    }


    void Update()
    {
        
    }
}
