using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrollRectSnap : MonoBehaviour
{
    
    public RectTransform panel; // ScrollPanel
    public Button[] bttn;
    public RectTransform center; // 각 button의 center를 distance로 비교하면서 설정
   

    public float[] distance;
    public float[] distReposition;
    public bool dragging = false;
    private int bttnDistance;
    private int minButtonNum; //center에서 가장 작은 distance를 가진 buttonNum
    private int bttnLength;
    private float minDistance;
    
   
    
    void Start()
    {
        
        Application.targetFrameRate = 100;
        bttnLength = bttn.Length;
        distance = new float[bttnLength];
        distReposition = new float[bttnLength];

        
        // button 사이의 distance를 계산
        bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);
        //print(bttnDistance); //1500

        //봄
        if (SceneBack.order == 1)
        {
            
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }

        //여름
        if (SceneBack.order == 2)
        {
            
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }
        
        //가을
        if (SceneBack.order == 3)
        {
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }

        //겨울
        if (SceneBack.order == 4)
        {
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }

        //물속
        if (SceneBack.order == 5)
        {
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }

        //우주
        if (SceneBack.order == 6)
        {
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }

        //공룡
        if (SceneBack.order == 7)
        {
            bttn[6].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -70);
            bttn[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(1500, -70);
            bttn[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(3000, -70);
            bttn[2].GetComponent<RectTransform>().anchoredPosition = new Vector2(4500, -70);
            bttn[3].GetComponent<RectTransform>().anchoredPosition = new Vector2(6000, -70);
            bttn[4].GetComponent<RectTransform>().anchoredPosition = new Vector2(7500, -70);
            bttn[5].GetComponent<RectTransform>().anchoredPosition = new Vector2(9000, -70);
        }
    }

    private void Update()
    {
        for (int i = 0; i < bttn.Length; i++)
        {
            //center position x값 - i번째 button position x값 
            distReposition[i] = center.GetComponent<RectTransform>().position.x - bttn[i].GetComponent<RectTransform>().position.x;
            
            //Debug.Log(minButtonNum);

            
            //button크기조절
            bttn[minButtonNum].GetComponent<RectTransform>().localScale = Vector2.Lerp(bttn[minButtonNum].GetComponent<RectTransform>().localScale, new Vector2(1f, 1f), Time.deltaTime * 1f);
            
            
            
            for (int a = 0; a < bttn.Length; a++)
            {
                if (a != minButtonNum)
                {
                    bttn[a].GetComponent<RectTransform>().localScale = Vector2.Lerp(bttn[a].GetComponent<RectTransform>().localScale, new Vector2(0.7f, 0.7f), Time.deltaTime * 1f);
                    
                    
                }
            }


            //i번째 button의 distance 계산 = center position - i번째 button position
            //distance[i] = Mathf.Abs(center.transform.position.x - bttn[i].transform.position.x);
            //debug화면에서 각 element가 center가 될 때 마다 position이 0 으로 바뀌는 것을 확인

            //GameController - ScrollRectSnap(Script) - Distance와 DistReposition이 동일한 절대값을 갖는다. distance(+), distreposition(-)
            //Mathf.Abs(절대값처리)
            distance[i] = Mathf.Abs(distReposition[i]);

            //Debug.Log("distReposition[i] : " + distReposition[i]);
            //distReposition[i]값들중 반 이상의 값 정도로 적절하게 설정
            //왼쪽 버튼들
            if (distReposition[i] > 2000)
            {
                float curX = bttn[i].GetComponent<RectTransform>().anchoredPosition.x;
                float curY = bttn[i].GetComponent<RectTransform>().anchoredPosition.y;

                //distReposition[i]값이 2500이상일때 x좌표값 + (버튼갯수 * distance = (버튼들의 전체 길이))
                Vector2 newAnchoredPos = new Vector2(curX + (bttnLength * bttnDistance), curY);
                //i번째 버튼에 newAnchoredPos 좌표값 설정
                bttn[i].GetComponent<RectTransform>().anchoredPosition = newAnchoredPos;
            }

            //오른쪽 버튼
            if (distReposition[i] < -2000)
            {
                float curX = bttn[i].GetComponent<RectTransform>().anchoredPosition.x;
                float curY = bttn[i].GetComponent<RectTransform>().anchoredPosition.y;

                Vector2 newAnchoredPos = new Vector2(curX - (bttnLength * bttnDistance), curY);
                bttn[i].GetComponent<RectTransform>().anchoredPosition = newAnchoredPos;
            }
        }


        minDistance = Mathf.Min(distance); //distance의 min값 = minDistance
      

        for (int a = 0; a < bttn.Length; a++)
        {
            //Debug.Log("minDistance : " + minDistance);
            if (minDistance == distance[a]) //만약 a번째 Button이 minDistance를 가진다면 (center에 가깝다면)
            {
                minButtonNum = a; //a번째 Button이 minButtonNum
               
            }
        }
        //LerpToBttn의 postition으로 -bttnDistance * minButtonNum(a번째 button)
        //LerpToBttn(minButtonNum * -bttnDistance);

        //LerpToBttn의 position으로 minButtonNum인 button x position값에 (-)설정
        LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.x);
        

    }

    void LerpToBttn(float position)
    {

        //Lerp함수(시작,종료,거리비율): 시작~종료 사이에서 거리비율을 적용시킨 값 도출
        //new X좌표 = panel의 anchoredPosition x값과 position 사이에 거리비율은 초당*10의 프레임처리(거리비율계산에 시간의 개념의 함께 적용된 경우)
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * 10f);

        //NewPosition의 x좌표 : newX, y좌표 : panel의 anchoredPosition y값
        Vector2 NewPosition = new Vector2(newX, panel.anchoredPosition.y);
        //Debug.Log("panel.anchoredPosition.x : " + panel.anchoredPosition.x);
        //Debug.Log("NewPosition : " + NewPosition);
        //panel 좌표값을 NewPosition으로 재지정해서 원점으로 돌아가지 않도록 update
        panel.anchoredPosition = NewPosition;

        //New X 좌표값은 dragging이 true라면 panel의 x좌표와 minButtonNum이 button의 x좌표(bttnDistance * center에 위치한Button의 x값)의 반대(-)좌표에 의해서 시간에 따른 거리비율 공식이 적용되어 서서히 position에 위치하게된다.

        
    }

    public void StartDrag()
    {
        dragging = true;
        EffectSound.instance.Move();
    }

    public void EndDrag()
    {
        dragging = false;
    
    }

   
}