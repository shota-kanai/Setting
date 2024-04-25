using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    //配列の宣言
    int[] map;

    // Start is called before the first frame update
    void Start()
    {
        //配列の実態の作成と初期化
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 };
        //追加。文字列の宣言と初期化
        string debugText = "";
        //Debug.Log("Hello World");//削除
        for(int  i=0; i<map.Length; i++)
        {
            //要素数を一つずつ出力
            //Debug.Log(map[i]+",");

            //変更。文字列に結合していく
            debugText += map[i].ToString()+",";
        }
        //結合した文字列を出力
        Debug.Log(debugText);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("->");
        }
    }
}
