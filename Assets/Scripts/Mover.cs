using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _offsetX = 3.0f;
    [SerializeField] private float _offsetY = 3.0f;
    [SerializeField] private float _duration = 3.0f;

    private void Start()
    {
        int infinity = -1;

        transform.DOMove(new Vector3(_offsetX, _offsetY, 0), _duration)
            .SetEase(Ease.InSine)
            .SetLoops(infinity, LoopType.Yoyo);
    }
}