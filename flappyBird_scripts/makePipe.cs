using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public float MaxTime;//timer達到這個時間就生成pipe
    private float minTime = 2;//難度的極限
    public float height;//pipe的中心位置要多高
    public GameObject pipe;//接口，放pipe物件
    private float timer = 0;//計時器
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>MaxTime)
        {
            GameObject newpipe = Instantiate(pipe);//生成pipe
            newpipe.transform.position = this.transform.position + new Vector3(0, Random.Range(-height, height), 0);//位置
            Destroy(newpipe, 20);//20time後刪除
            timer = 0;//timer歸零
            if (MaxTime > minTime)//增加難度
                MaxTime = MaxTime - 0.1f;
        }
        timer += Time.deltaTime;

    }
}
