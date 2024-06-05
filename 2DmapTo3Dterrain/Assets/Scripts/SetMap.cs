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

    // �浵, ���� �Է¹޾� map ����
    public void createMap()
    {
        Debug.Log(lo + "," + la);

        map.SetPosition(lo, la);
        
        //zoom�� �ʿ��� ���
        //map.SetPositionAndZoom(longitude, latitude, zoom);
    }

    // ��Ŭ�� �̵� off

    // zoom ����

    // zoom�� �´� elevation ����

    // ���� ��忡���� top view, ���� ��忡���� ���� off
}
