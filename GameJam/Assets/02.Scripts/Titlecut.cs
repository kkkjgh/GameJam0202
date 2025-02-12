using UnityEngine;

public class Titlecut : MonoBehaviour
{
    public GameObject titleObject;  // 비활성화할 Title 오브젝트

    // title 오브젝트 비활성화하는 함수
    public void DeactivateTitle()
    {
        titleObject.SetActive(false);
    }
}
