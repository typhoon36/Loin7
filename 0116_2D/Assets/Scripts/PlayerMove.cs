using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 1f;    

    void Start()
    {
        
    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    transform.Translate(Vector3.up * Speed *  Time.deltaTime);
        //}

        //Vector3 move = Vector3.zero;
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    move = Vector3.up;
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    move = Vector3.down;
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    move = Vector3.left;
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    move = Vector3.right;
        //}

        //transform.Translate(Vector3.up * Speed * Time.deltaTime);

        //입력값 받기
        float h = Input.GetAxis("Horizontal"); // A ,D   <- ,->
        float v = Input.GetAxis("Vertical");

        //방향 벡터 생성
        Vector3 dir = new Vector3(h, v, 0);

        //이동
        transform.Translate(dir * Speed * Time.deltaTime);
    }
}
