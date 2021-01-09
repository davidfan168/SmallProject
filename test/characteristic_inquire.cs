using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine;

public class characteristic_inquire : MonoBehaviour {

    bool isshow = false;
    public GameObject reseach_jpg;
    public GameObject a_1;
    public GameObject a_2;

    public GameObject a_4;
    public GameObject a_5;

    public GameObject a_7;
    void Start()
    {
        reseach_jpg.SetActive(isshow);
        //获取按钮游戏对象

        GameObject btnObj = GameObject.Find("Canvas/sat");  //帮助界面返回按钮
                                                            //获取按钮脚本组件
        Button btn = (Button)btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener(delegate ()
        {

            onClick1(btnObj);


        });

    }

    void onClick1(GameObject obj)
    {
        date.inquire_information = "特征搜索";
        isshow = true;
        reseach_jpg.SetActive(isshow);
        a_1.SetActive(!isshow);
        a_2.SetActive(!isshow);
        a_4.SetActive(!isshow);
        a_5.SetActive(!isshow);
        a_7.SetActive(!isshow);

    }
}
