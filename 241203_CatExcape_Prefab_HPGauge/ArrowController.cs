using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player; //player 라는 게임 오브젝트 초기화
    void Start()
    {
        this.player = GameObject.Find("player_0"); //palyer_0 찾아서 오브젝트에 넣어줌
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.12f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //p1에 화살의 xy 좌표를 초기화
        Vector2 p2 = this.player.transform.position; //p2에 player의 좌표를 초기화
        Vector2 dir = p1 - p2; //두 좌표의 xy값 차이를 dir이라는 벡터좌표에 넣어줌
        float d = dir.magnitude; //magnitude 메서드를 써서 dir의 길이를 d에 넣어줌
        float r1 = 0.5f; //임의로 화살표의 반지름을 0.5로 초기화
        float r2 = 1.0f; //임의로 플레이어의 반지름을 1로 초기화

        if(d< r1 + r2) //두 오브젝트 중심 간의 거리가 설정한 반지름의 합보다 작으면 충돌!
        {
            GameObject director = GameObject.Find("GameDirector"); //디렉터 선언하고 Scene 에서 호출
            director.GetComponent<GameDirector>().DecreaseHP(); //GameDirector 클래스에 DecreaseHP 호출.

            Destroy(gameObject); // 위의 가정에 따라 소멸.
        }

    }
}
