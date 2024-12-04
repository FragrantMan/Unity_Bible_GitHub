using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 0; // �ӵ�

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
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //GetKeyDownDown�� ���� �� �� �ѹ� ����.
        { //GetKey�� ������ ������ ��� ����
            speed -= 0.3f; // �������� ���ݾ� ����
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed += 0.3f; // ���������� ���ݾ� ����
        }
        else
        {
            speed *= 0.90f; // �Է��� ������ ����
        }

        // �ӵ��� ����
        speed = Mathf.Clamp(speed, -1f, 1f); // �ִ� �ӵ� ����
                                                 //�̵��ӵ�, ����, �ִ� �ӵ��� ������ �ùķ��̼��� ������ ���� �ߴ�.
                                                 // �̵�
        transform.Translate(speed, 0, 0);
    }
}
