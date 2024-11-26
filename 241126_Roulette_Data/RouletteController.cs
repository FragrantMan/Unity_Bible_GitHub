using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //회전 속도 초기화
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //화면 재생률 60
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//마우스 버튼이 눌리면
        {
            this.rotSpeed = 10; //회전 속도 10으로
        }

        transform.Rotate(0, 0, this.rotSpeed); // z축 기준으로 10만큼 돌린다.

        this.rotSpeed *= 0.98f;
    }
}
