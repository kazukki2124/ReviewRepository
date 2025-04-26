using UnityEngine;

//Unityの入力システムを使うという宣言
using UnityEngine.InputSystem;

/// <summary>
/// このPlayerController class(コンポーネント)は公開されており、どこからでもアクセスできます
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// このPlayerController classの中だけで使えるRigidBody型の変数spherRigidbosyを宣言する
    /// </summary>
    private Rigidbody sphereRigidbody;

    /// <summary>
    /// X軸方向の移動量
    /// </summary>
    private float movementX;

    /// <summary>
    /// Z軸方向の移動量
    /// </summary>
    private float movementZ;

    void Start()
    {
        //先ほど宣言したRigidbody型の変数に、PlayerController class(コンポーネント)が
        //追加されたGameObjectからRigidbodyコンポーネントを取得し、代入する
        sphereRigidbody = GetComponent<Rigidbody>();
    }


    /// <summary>
    /// 入力されたキーによって、値を取得する
    /// </summary>
    /// <param name="movementValue">上下左右キーやWASDの押下を1にする</param>
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVecter = movementValue.Get<Vector2>();
        movementX = movementVecter.x;
        movementZ = movementVecter.y;
    }

    void Update()
    {
        //Rigidbodyのコンポーネントに引数で指定した方向の力を加える
        //sphereRigidbody.AddForce(Vector3.forward * 0.1f);　コメントアウトする
    }
    //定期的に実行され続ける処理を描く場所
    private void FixedUpdate()
    {
        //Rigidbodyのコンポーネントに引数で指定した方向の力を加える
        sphereRigidbody.AddForce(new Vector3(movementX, 0, movementZ));
    }
}
