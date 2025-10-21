using System;
using System.Collections.Generic;

// This class can hide words, show the current state of the scripture,
// and check if all the words are hidden.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Constructor: that splits the text into individual words and stores them as Word objects in the list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(" "); // This takes the scripture text and splits it into individual words.

        for (int i = 0; i < splitText.Length; i++) // for loop that goes through each word in the array.
        {
            Word w = new Word(splitText[i]);
            _words.Add(w); // this adds the newly created word into that list.
        }
    }

// This method hides 2 random words at a time, from the list that isn't already hidden
    public void HideRandomWords(int count)
    {
        int hidden = 0;

  // Continue hiding words until we reach the count or all words are hidden
        while (hidden < count && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count); // Pick a random position in the list of words (_random.Next() makes the hiding unpredictable)

            if (!_words[index].IsHidden()) // checks if the randomly chosen word is not already hidden.
            {
                _words[index].Hide(); // We call the Hide() method from the Word class.
                hidden++; // Every time a new word gets hidden, hidden increases by 1.
            }
        }
    }

    public string GetRenderedText()
    {
        // Start by adding the reference
        string renderedText = _reference.GetRenderedText() + "\n";

        // Adds each word, using GetRenderedText() from the Word class
        for (int i = 0; i < _words.Count; i++)
        {
            renderedText = renderedText + _words[i].GetRenderedText() + " ";
        }

        // Trim the extra space at the end 
        return renderedText.Trim();
    }

    // IsCompletelyHidden(): Checks if every word in the scripture is hidden.
    // Returns true if all words are hidden, or false if any are still visible.
    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false; // returns false if a word is visible
            }
        }
        return true; // loop ends if every word is hidden
    }
}
