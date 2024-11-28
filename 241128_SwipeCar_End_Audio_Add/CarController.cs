using UnityEngine;

public class CarContrikker : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos; //시작점 XY벡터 좌표 초기화
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //FPS 60 고정
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 누르면
        {
            this.startPos = Input.mousePosition; //누른 위치 시작점으로 저장
        }
        else if (Input.GetMouseButtonUp(0)) //마우스 땔 때
        {
            Vector2 endPos = Input.mousePosition; //끝점 벡타 좌표에 마우스 위치 삽입
            float swipeLength = endPos.x - this.startPos.x; //끝-시작 으로 길이 추출
            this.speed = swipeLength / 2000.0f; //추출한 길이를 일정 값으로 나눠 속도로 가공
            GetComponent<AudioSource>().Play(); //마우스 클릭이 떨어질때 효과음!
        }

        transform.Translate(this.speed, 0, 0);//속도만큼 좌표 이동
        this.speed *= 0.98f; //끊기는 느낌 없게 가속도 개념 대입
    }
}