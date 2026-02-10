using UnityEngine;

public class GrassAnim : MonoBehaviour
{
    public Vector3 amount;
    public float time;

    void Start()
    {
        float randomTime = Random.Range(time - 0.5f, time + 0.5f);

        iTween.PunchScale(gameObject, iTween.Hash(
            "amount", amount,
            "time", randomTime,
            "looptype", iTween.LoopType.loop
        ));
    }
}
