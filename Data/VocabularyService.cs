using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Language_Learning_Flashcards.Data
{
    public class VocabularyService
    {
        private readonly List<VocabularyWord> _words;

        public VocabularyService()
        {
            try
            {
                var json = File.ReadAllText("Data/vocabulary.json");
                _words = JsonSerializer.Deserialize<List<VocabularyWord>>(json) ?? new List<VocabularyWord>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading vocabulary data: {ex.Message}");
                _words = new List<VocabularyWord>();
            }
        }

        public IEnumerable<VocabularyWord> GetAllWords() => _words;

        public IEnumerable<VocabularyWord> GetWordsByLanguage(string? language) =>
            string.IsNullOrWhiteSpace(language)
                ? Enumerable.Empty<VocabularyWord>()
                : _words.Where(w => w.Language?.Equals(language, StringComparison.OrdinalIgnoreCase) == true);

        public void MarkAsLearned(int wordId)
        {
            var word = _words.FirstOrDefault(w => w.WordId == wordId);
            if (word != null)
            {
                word.IsLearned = true;
            }
        }

        public IEnumerable<VocabularyWord> GetLearnedWords() => _words.Where(w => w.IsLearned);
    }

    public class VocabularyWord
    {
        public int WordId { get; set; }
        public string? Word { get; set; }
        public string? Translation { get; set; }
        public string? Language { get; set; }
        public bool IsLearned { get; set; } = false;
    }
}
