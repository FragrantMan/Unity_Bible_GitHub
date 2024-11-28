using UnityEngine;
using TMPro; //�ؽ�Ʈ UI, Text Mesh Pro �� ����Ϸ��� �ݵ�� ����Ʈ �������!
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.car = GameObject.Find("car_0"); //Gameobject�� �߿��� " " ���� �̸��� ������Ʈ�� ã�Ƽ�
        this.flag = GameObject.Find("flag_0"); // = ������ ���� ���ڿ� �־��ش�
        this.distance = GameObject.Find("distance_0");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x; //������Ʈ���� x ��ǥ ���ϱ�
        
        if (length > 0 ) 
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
            //this..distance ������ TMPro �޼��� �� text�� ���� "Distance : " �ڵ����� ��߻����� �Ÿ� �Ҽ��� ���ڸ�����. + m
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }

    }   
}
