using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.25f; // 생성 주기. '초' 단위
    float delta = 0; // 카운트를 위한 변수

    void Update()
    {
        this.delta += Time.deltaTime; //프레임간 시간 차이를 delta에 넣음
        if (this.delta > this.span) //설정한 주기에 다다르면
        {
            this.delta = 0; //변수 0으로 초기화하고
            GameObject go = Instantiate(arrowPrefab); //go 라는 오브젝트에 화살을 복사하는
            int px = Random.Range(-9, 10); //코드를 넣어주고. 생성될 위치의 x 좌표를 랜덤하게
            go.transform.position = new Vector3(px, 7, 0); //넣어준뒤. go 의 좌표에 대입.
        }
    }
}