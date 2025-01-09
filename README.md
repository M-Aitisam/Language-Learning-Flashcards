# 🌍 Language Learning Flashcards

Welcome to the **Language Learning Flashcard Application**! This interactive web application helps users practice vocabulary in various languages through flashcards and quizzes.

---

### 🚀 Features

- **Interactive Flashcards**: Flip flashcards to see word translations.
- **Language Selection**: Choose your preferred language from a dropdown menu.
- **Mark Words as Learned**: Track progress by marking words as learned.
- **Quiz Mode**: Test your knowledge with a quiz on learned words.
- **Progress Tracking**: Keep tabs on how many words you've learned.

---

### 📂 Project Structure

```plaintext
📦 Language_Learning_Flashcards
├── Data
│   ├── vocabulary.json  # Vocabulary data
│   └── VocabularyService.cs  # Backend service for word management
├── Pages
│   ├── Flash.razor  # Flashcard page
│   └── Quiz.razor  # Quiz page
├── wwwroot
│   └── js
│       └── flipCard.js  # JavaScript for flashcard animations
└── Program.cs  # Blazor application setup
```

---

### 🛠️ Technologies Used

- **Frontend**: Blazor Server
- **Styling**: Bootstrap
- **Backend**: JSON for data storage (can be replaced with a database)
- **Interop**: JavaScript for card flip animations

---

### 📝 How to Run

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/Language-Learning-Flashcards.git
   ```

2. **Navigate to the Project Directory**:
   ```bash
   cd Language-Learning-Flashcards
   ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```

4. **Open in Browser**:
   Navigate to `http://localhost:5000` to start using the app.

---

### 🧩 Usage

1. **Flashcard Mode**:
   - Select a language from the dropdown.
   - Use the "Flip" button to reveal translations.
   - Mark words as learned or skip them.

2. **Quiz Mode**:
   - Test your knowledge on learned words.
   - Type your answer and submit.
   - Get instant feedback on correctness.

---

### 📈 Future Enhancements

- Add user authentication to save progress.
- Implement a leaderboard for competitive learning.
- Support for audio pronunciation of words.
- Import/export custom vocabulary lists.

---

### 📧 Support

For any issues or suggestions, feel free to create an issue in this repository or reach out to us via email: [support@example.com](mailto:support@example.com).

---

### ⭐ Contribute

1. Fork the repository.
2. Create a new branch.
3. Make your changes and submit a pull request.

---

### 🌟 Acknowledgments

Thank you for using the Language Learning Flashcard Application. Happy learning! 🎉
