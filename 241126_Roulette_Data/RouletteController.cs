using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //ȸ�� �ӵ� �ʱ�ȭ
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //ȭ�� ����� 60
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//���콺 ��ư�� ������
        {
            this.rotSpeed = 10; //ȸ�� �ӵ� 10����
        }

        transform.Rotate(0, 0, this.rotSpeed); // z�� �������� 10��ŭ ������.

        this.rotSpeed *= 0.98f;
    }
}
