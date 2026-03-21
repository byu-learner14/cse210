// =============================================
// SCRIPTURE.CS
// =============================================

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text into words (handles multiple spaces safely)
        string[] wordsArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void Display()
    {
        Console.Write(_reference.GetDisplayText() + " — ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    // Stretch: only hides words that are still visible
    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        Random rand = new Random();
        int hideCount = Math.Min(count, visibleWords.Count);

        // Shuffle and take the first N words to hide
        var toHide = visibleWords.OrderBy(w => rand.Next()).Take(hideCount).ToList();

        foreach (var word in toHide)
        {
            word.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}