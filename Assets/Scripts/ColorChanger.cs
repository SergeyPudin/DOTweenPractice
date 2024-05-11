using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration = 4.0f;

    private SpriteRenderer _renderer;

    private void Start()
    {
        int infinity = -1;

        _renderer = GetComponent<SpriteRenderer>();

        _renderer.DOColor(_color, _duration).SetLoops(infinity, LoopType.Yoyo);
    }
}