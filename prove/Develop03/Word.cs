
public class Word
{
    private string _text;
    private bool _isHidden;

    // This constructor initializes the word as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, words are shown at the beginning
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // For example, Scripture class uses this to check whether a word can be hidden again
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);  // This command creates a string by repeating a character a certain number of times.
        }                                          // so we hide the word but keep the same length on the screen
        else
        {
            return _text;
        }
    }
}

