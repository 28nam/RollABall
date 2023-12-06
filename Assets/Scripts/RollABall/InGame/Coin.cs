using System.Collections;
using UnityEngine;

public enum CoinState
{
    Regular,
    Bonus
}

public class Coin : MonoBehaviour
{
    private float bonusTime = 1f; // Thời gian cho phép nhận điểm bonus (1 giây).
    private float disappearTime = 5f;

    private int scoreValue = 10;
    private int bonusScoreValue = 100;

    private CoinState coinState = CoinState.Regular;

    private Material coinMaterial; // Vật liệu của đồng xu.

    void Start()
    {
        coinMaterial = GetComponent<Renderer>().material; // Lấy vật liệu của đồng xu.
        StartCoroutine(BonusTimeCoroutine());
    }

    IEnumerator BonusTimeCoroutine()
    {
        yield return new WaitForSeconds(bonusTime);

        coinState = CoinState.Bonus; // Đặt trạng thái của đồng xu thành Bonus.

        // Thay đổi màu của đồng xu dựa trên thời gian bonus.
        if (coinState == CoinState.Bonus)
        {
            // Ví dụ: Đổi màu thành đỏ.
            coinMaterial.color = Color.red;
        }

        yield return new WaitForSeconds(disappearTime - bonusTime);

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (coinState == CoinState.Bonus)
            {
                ScoreManager.ScoreCount += bonusScoreValue;
            }
            else
            {
                ScoreManager.ScoreCount += scoreValue;
            }

            Destroy(gameObject);
        }
    }
}
