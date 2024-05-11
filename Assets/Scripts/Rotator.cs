using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _angle = 270.0f;
    [SerializeField] private float _duration = 3.0f;

    private void Start()
    {
        int infinity = -1;
        var quaternion = new Vector3(_angle, _angle, _angle);

        transform.DORotate(quaternion, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(infinity, LoopType.Restart);
    }
}