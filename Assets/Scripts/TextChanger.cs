using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 2.0f;
    [SerializeField] private float _delay = 2.0f;

    private Text _text;
    private string _firstTrgetText;
    private string _secondTrgetText;
    private string _thirdTrgetText;

    private void Start()
    {
        _text = GetComponent<Text>();

        _firstTrgetText = "�������������� ��������� ��� ������� ����� ������� � ������������ ��������.";
        _secondTrgetText = "����� ��� ���� ������ ����������� �����, �� ����� �� ���.";
        _thirdTrgetText = "������� � ��� � �������� ������ � ���� � �������, � ���������, ������, ������� �� ���� ��.";

        _text.text = _firstTrgetText;
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_secondTrgetText, _duration).SetDelay(_delay));
        textSequence.Append(_text.DOText(_thirdTrgetText, _duration, true, ScrambleMode.All).SetDelay(_delay));
    }
}