using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{

    public Transform target;  // 추적할 대상, 즉 캐릭터
    public float smoothSpeed = 0.125f;  // 카메라 움직임의 부드러움 정도
    public Vector3 offset;  // 카메라와 캐릭터 사이의 거리

    void LateUpdate()
    {
        // 타겟 위치에 오프셋을 더해 카메라의 목표 위치를 설정
        Vector3 desiredPosition = target.position + offset;

        // 현재 위치에서 목표 위치로 부드럽게 이동
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라의 위치를 새로운 위치로 설정
        transform.position = smoothedPosition;
    }
}
