using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player; //player ��� ���� ������Ʈ �ʱ�ȭ
    void Start()
    {
        this.player = GameObject.Find("player_0"); //palyer_0 ã�Ƽ� ������Ʈ�� �־���
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.12f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //p1�� ȭ���� xy ��ǥ�� �ʱ�ȭ
        Vector2 p2 = this.player.transform.position; //p2�� player�� ��ǥ�� �ʱ�ȭ
        Vector2 dir = p1 - p2; //�� ��ǥ�� xy�� ���̸� dir�̶�� ������ǥ�� �־���
        float d = dir.magnitude; //magnitude �޼��带 �Ἥ dir�� ���̸� d�� �־���
        float r1 = 0.5f; //���Ƿ� ȭ��ǥ�� �������� 0.5�� �ʱ�ȭ
        float r2 = 1.0f; //���Ƿ� �÷��̾��� �������� 1�� �ʱ�ȭ

        if(d< r1 + r2) //�� ������Ʈ �߽� ���� �Ÿ��� ������ �������� �պ��� ������ �浹!
        {
            GameObject director = GameObject.Find("GameDirector"); //���� �����ϰ� Scene ���� ȣ��
            director.GetComponent<GameDirector>().DecreaseHP(); //GameDirector Ŭ������ DecreaseHP ȣ��.

            Destroy(gameObject); // ���� ������ ���� �Ҹ�.
        }

    }
}
