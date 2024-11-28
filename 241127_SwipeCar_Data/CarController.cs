using UnityEngine;

public class CarContrikker : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos; //������ XY���� ��ǥ �ʱ�ȭ
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //FPS 60 ����
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���콺 ������
        {
            this.startPos = Input.mousePosition; //���� ��ġ ���������� ����
        }
        else if (Input.GetMouseButtonUp(0)) //���콺 �� ��
        {
            Vector2 endPos = Input.mousePosition; //���� ��Ÿ ��ǥ�� ���콺 ��ġ ����
            float swipeLength = endPos.x - this.startPos.x; //��-���� ���� ���� ����
            this.speed = swipeLength / 2000.0f; //������ ���̸� ���� ������ ���� �ӵ��� ����
        }

        transform.Translate(this.speed, 0, 0);//�ӵ���ŭ ��ǥ �̵�
        this.speed *= 0.98f; //����� ���� ���� ���ӵ� ���� ����
    }
}