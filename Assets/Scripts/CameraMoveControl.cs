using UnityEngine;

public class CameraMoveConrtol : MonoBehaviour
{
    /// <summary>
    ///  �J�����̈ʒu���
    /// </summary>
    private Transform cameraTransform;

    void Start()
    {
        // �J�����̈ʒu���ɂ���GameObject�̈ʒu����������
        cameraTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // �J�����̈ʒu���ɁA�E�����̃x�N�g���Ƀt���[���̎��Ԃ��|�����l�����Z��������
        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}
