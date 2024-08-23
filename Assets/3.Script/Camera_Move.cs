using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{

    public Transform target;  // ������ ���, �� ĳ����
    public float smoothSpeed = 0.125f;  // ī�޶� �������� �ε巯�� ����
    public Vector3 offset;  // ī�޶�� ĳ���� ������ �Ÿ�

    void LateUpdate()
    {
        // Ÿ�� ��ġ�� �������� ���� ī�޶��� ��ǥ ��ġ�� ����
        Vector3 desiredPosition = target.position + offset;

        // ���� ��ġ���� ��ǥ ��ġ�� �ε巴�� �̵�
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // ī�޶��� ��ġ�� ���ο� ��ġ�� ����
        transform.position = smoothedPosition;
    }
}
