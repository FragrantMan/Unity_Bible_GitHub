using UnityEngine;
using TMPro; //텍스트 UI, Text Mesh Pro 를 사용하려면 반드시 임포트 해줘야함!
public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.car = GameObject.Find("car_0"); //Gameobject들 중에서 " " 안의 이름의 오브젝트를 찾아서
        this.flag = GameObject.Find("flag_0"); // = 왼쪽의 변수 상자에 넣어준다
        this.distance = GameObject.Find("distance_0");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x; //오브젝트들의 x 좌표 구하기
        
        if (length > 0 ) 
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
            //this..distance 변수에 TMPro 메서드 중 text에 문구 "Distance : " 자동차와 깃발사이의 거리 소수점 두자리까지. + m
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }

    }   
}
