using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _targetScale = 3.0f;
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        int infinity = -1;

        transform.DOScale(_targetScale, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(infinity, LoopType.Yoyo);
    }
}