using UnityEngine;

//Unity�̓��̓V�X�e�����g���Ƃ����錾
using UnityEngine.InputSystem;

/// <summary>
/// ����PlayerController class(�R���|�[�l���g)�͌��J����Ă���A�ǂ�����ł��A�N�Z�X�ł��܂�
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// ����PlayerController class�̒������Ŏg����RigidBody�^�̕ϐ�spherRigidbosy��錾����
    /// </summary>
    private Rigidbody sphereRigidbody;

    /// <summary>
    /// X�������̈ړ���
    /// </summary>
    private float movementX;

    /// <summary>
    /// Z�������̈ړ���
    /// </summary>
    private float movementZ;

    void Start()
    {
        //��قǐ錾����Rigidbody�^�̕ϐ��ɁAPlayerController class(�R���|�[�l���g)��
        //�ǉ����ꂽGameObject����Rigidbody�R���|�[�l���g���擾���A�������
        sphereRigidbody = GetComponent<Rigidbody>();
    }


    /// <summary>
    /// ���͂��ꂽ�L�[�ɂ���āA�l���擾����
    /// </summary>
    /// <param name="movementValue">�㉺���E�L�[��WASD�̉�����1�ɂ���</param>
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVecter = movementValue.Get<Vector2>();
        movementX = movementVecter.x;
        movementZ = movementVecter.y;
    }

    void Update()
    {
        //Rigidbody�̃R���|�[�l���g�Ɉ����Ŏw�肵�������̗͂�������
        //sphereRigidbody.AddForce(Vector3.forward * 0.1f);�@�R�����g�A�E�g����
    }
    //����I�Ɏ��s���ꑱ���鏈����`���ꏊ
    private void FixedUpdate()
    {
        //Rigidbody�̃R���|�[�l���g�Ɉ����Ŏw�肵�������̗͂�������
        sphereRigidbody.AddForce(new Vector3(movementX, 0, movementZ));
    }
}
