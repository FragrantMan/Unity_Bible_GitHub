using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.25f; // ���� �ֱ�. '��' ����
    float delta = 0; // ī��Ʈ�� ���� ����

    void Update()
    {
        this.delta += Time.deltaTime; //�����Ӱ� �ð� ���̸� delta�� ����
        if (this.delta > this.span) //������ �ֱ⿡ �ٴٸ���
        {
            this.delta = 0; //���� 0���� �ʱ�ȭ�ϰ�
            GameObject go = Instantiate(arrowPrefab); //go ��� ������Ʈ�� ȭ���� �����ϴ�
            int px = Random.Range(-9, 10); //�ڵ带 �־��ְ�. ������ ��ġ�� x ��ǥ�� �����ϰ�
            go.transform.position = new Vector3(px, 7, 0); //�־��ص�. go �� ��ǥ�� ����.
        }
    }
}