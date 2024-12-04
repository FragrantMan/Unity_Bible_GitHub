using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 0; // 속도

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //GetKeyDownDown은 누를 떄 딱 한번 적용.
        { //GetKey는 누르고 있으면 계속 적용
            speed -= 0.3f; // 왼쪽으로 조금씩 가속
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed += 0.3f; // 오른쪽으로 조금씩 가속
        }
        else
        {
            speed *= 0.90f; // 입력이 없으면 감속
        }

        // 속도를 제한
        speed = Mathf.Clamp(speed, -1f, 1f); // 최대 속도 설정
                                                 //이동속도, 감속, 최대 속도는 여러번 시뮬레이션을 돌려서 추출 했다.
                                                 // 이동
        transform.Translate(speed, 0, 0);
    }
}
