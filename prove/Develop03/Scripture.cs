
public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureWords = new List<Word>();

    public Scripture()
    {
    }

    public Scripture(string bookName, string chapter, string vs1, string vs2, string text1, string text2)
    {
        _reference = new Reference(bookName, chapter, vs1, vs2);

        foreach (string w in text1.Split(" "))
        {
            Word word = new Word(w);
            _scriptureWords.Add(word);
        }

        foreach (string w in text2.Split(" "))
        {
            Word word = new Word(w);
            _scriptureWords.Add(word);
        }
    }

    public void HideRandomWord()
    {
        if (!IsCompletelyHidden())
        {
            bool wordHidden = false;

            do
            {
                var countWord = _scriptureWords.Count();
                Random r = new Random();
                int rIndex = r.Next(0, countWord);
                Word word = _scriptureWords[rIndex];
                if (word.IsShown())
                {
                    word.HideWord();
                    wordHidden = true;
                }
            } while (!wordHidden);
        }
    }

    public void GetRenderedText()
    {
        foreach (Word word in _scriptureWords)
        {
            Console.Write(word.GetWordText() + " ");
        }
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        
        foreach (Word word in _scriptureWords)
        {
            if (word.IsShown())
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}

