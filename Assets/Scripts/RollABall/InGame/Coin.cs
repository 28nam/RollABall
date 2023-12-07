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
    private bool bonusScoreReceived = false;

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

        // Thực hiện kiểm tra trước khi thay đổi màu để đảm bảo đồng xu chưa bị hủy.
        if (gameObject != null)
        {
            StartCoroutine(WaitAndDestroy(disappearTime - bonusTime));
        }
    }

    IEnumerator WaitAndDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        // Kiểm tra xem đồng xu đã bị hủy chưa trước khi thực hiện hành động
        if (gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (coinState == CoinState.Bonus && !bonusScoreReceived)
            {
                ScoreManager.ScoreCount += bonusScoreValue;
                bonusScoreReceived = true;
            }
            else if (coinState == CoinState.Regular)
            {
                ScoreManager.ScoreCount += scoreValue;
            }

            // Kiểm tra xem đồng xu đã bị hủy chưa trước khi thực hiện hành động
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
