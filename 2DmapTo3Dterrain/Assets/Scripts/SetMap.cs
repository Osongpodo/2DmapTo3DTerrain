using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;

public class SetMap : MonoBehaviour
{
    public OnlineMaps map;
    public OnlineMapsCameraOrbit camOrbit;
    public OnlineMapsBingMapsElevationManager elevationManager;
    public OnlineMapsControlBase control;

    public TMP_InputField inputLong;
    public TMP_InputField inputLat;

    public float la;
    public float lo;

    void Start()
    {
        camOrbit = map.GetComponent<OnlineMapsCameraOrbit>();
        elevationManager = map.GetComponent<OnlineMapsBingMapsElevationManager>();
        control = map.GetComponent<OnlineMapsControlBase>();
    }

    void Update()
    {

    }

    // 경도, 위도 입력받아 map 생성
    public void createMap()
    {
        // 위치 받아오기
        lo = float.Parse(inputLong.text);
        la = float.Parse(inputLat.text);

        Debug.Log(lo + "," + la);

        // zoom 크기 17로 해당 위치의 지도 생성
        map.SetPositionAndZoom(lo, la, 17);

        // Elevation 설정
        elevationManager.scale = 2f;

        // 위치 고정 (좌클릭 이동 off)
        control.allowUserControl = false;

        // Top view 고정
        camOrbit.lockTilt = true;
        camOrbit.lockPan = true;
    }
}
