using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;

public class SetMap : MonoBehaviour
{
    public OnlineMaps map;
    public OnlineMapsBingMapsElevationManager elevationManager;

    public TMP_InputField inputLong;
    public TMP_InputField inputLat;

    public float lo;
    public float la;
    public float zoom;

    void Update()
    {
        lo = float.Parse(inputLong.text);
        la = float.Parse(inputLat.text);
    }

    // 경도, 위도 입력받아 map 생성
    public void createMap()
    {
        Debug.Log(lo + "," + la);

        map.SetPosition(lo, la);
        
        //zoom이 필요한 경우
        //map.SetPositionAndZoom(longitude, latitude, zoom);
    }

    // 좌클릭 이동 off

    // zoom 고정

    // zoom에 맞는 elevation 설정

    // 편집 모드에서는 top view, 메인 모드에서는 고정 off
}
