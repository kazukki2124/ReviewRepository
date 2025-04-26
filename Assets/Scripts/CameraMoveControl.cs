using UnityEngine;

public class CameraMoveConrtol : MonoBehaviour
{
    /// <summary>
    ///  カメラの位置情報
    /// </summary>
    private Transform cameraTransform;

    void Start()
    {
        // カメラの位置情報にこのGameObjectの位置情報を代入する
        cameraTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // カメラの位置情報に、右方向のベクトルにフレームの時間を掛けた値を加算し続ける
        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}
