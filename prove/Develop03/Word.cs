
public class Word
{
    private string _wordText;
    private bool _isShown;

    public Word(string wordText)
    {
        _wordText = wordText;
        _isShown = true;
    }
    public void HideWord()
    {
        _isShown = false;
        string replaceText = "";

        for (int i = 0; i < _wordText.Length; i++)
        {
            replaceText += '_';
        }
        _wordText = replaceText;
    }

    public bool IsHidden()
    {
        return !_isShown;
    }

    public bool IsShown()
    {
        return _isShown;
    }
    
    public string GetWordText()
    {
        return _wordText;
    }
}
