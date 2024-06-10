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

    // �浵, ���� �Է¹޾� map ����
    public void createMap()
    {
        // ��ġ �޾ƿ���
        lo = float.Parse(inputLong.text);
        la = float.Parse(inputLat.text);

        Debug.Log(lo + "," + la);

        // zoom ũ�� 17�� �ش� ��ġ�� ���� ����
        map.SetPositionAndZoom(lo, la, 17);

        // Elevation ����
        elevationManager.scale = 2f;

        // ��ġ ���� (��Ŭ�� �̵� off)
        control.allowUserControl = false;

        // Top view ����
        camOrbit.lockTilt = true;
        camOrbit.lockPan = true;
    }
}
