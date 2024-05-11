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

        _firstTrgetText = "јэрофотосъЄмка ландшафта уже вы€вила земли богачей и процветающих кресть€н.";
        _secondTrgetText = "—ъешь ещЄ этих м€гких французских булок, да выпей же чаю.";
        _thirdTrgetText = "¬ступив в бой с шип€щими зме€ми Ч эфой и гадюкой, Ч маленький, цепкий, храбрый Єж съел их.";

        _text.text = _firstTrgetText;
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_secondTrgetText, _duration).SetDelay(_delay));
        textSequence.Append(_text.DOText(_thirdTrgetText, _duration, true, ScrambleMode.All).SetDelay(_delay));
    }
}