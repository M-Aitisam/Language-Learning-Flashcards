using System.Text.Json;

namespace Language_Learning_Flashcards.Data
{
    public class VocabularyService
    {
        private readonly List<VocabularyWord> _words;

        public VocabularyService()
        {
            // Safely load and deserialize the vocabulary JSON file
            try
            {
                var json = File.ReadAllText("Data/vocabulary.json");
                _words = JsonSerializer.Deserialize<List<VocabularyWord>>(json) ?? new List<VocabularyWord>();
            }
            catch (Exception ex)
            {
                // Handle exceptions and initialize with an empty list
                Console.WriteLine($"Error loading vocabulary data: {ex.Message}");
                _words = new List<VocabularyWord>();
            }
        }

        /// <summary>
        /// Retrieves all words in the vocabulary.
        /// </summary>
        /// <returns>A list of all vocabulary words.</returns>
        public IEnumerable<VocabularyWord> GetAllWords() => _words;

        /// <summary>
        /// Retrieves words filtered by the specified language.
        /// </summary>
        /// <param name="language">The language to filter by.</param>
        /// <returns>A list of words in the specified language.</returns>
        public IEnumerable<VocabularyWord> GetWordsByLanguage(string? language) =>
            string.IsNullOrWhiteSpace(language)
                ? Enumerable.Empty<VocabularyWord>()
                : _words.Where(w => w.Language?.Equals(language, StringComparison.OrdinalIgnoreCase) == true);

        /// <summary>
        /// Marks a word as learned by its unique ID.
        /// </summary>
        /// <param name="wordId">The ID of the word to mark as learned.</param>
        public void MarkAsLearned(int wordId)
        {
            var word = _words.FirstOrDefault(w => w.WordId == wordId);
            if (word != null)
            {
                word.IsLearned = true;
            }
        }
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
