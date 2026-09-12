# 🎮 Tic-Tac-Toe Game (C# Windows Forms)

A classic **Tic-Tac-Toe (X-O)** desktop game built with **C# and Windows Forms (.NET)**, featuring **two selectable themes**:

- 🖤 **Classic Dark Theme** — a clean, modern dark-mode board.
- 𓋹 **Pharaonic Egyptian Theme** — a unique ancient-Egypt-inspired board with hieroglyphic symbols, papyrus textures, and gold highlights.

Players pick their favorite theme from the main menu and play a two-player local match with automatic win/draw detection.

---

## 📸 Screenshots

| Main Menu | Classic Dark Theme | Pharaonic Theme |
|---|---|---|
| Choose your theme | Standard X/O board | Egyptian hieroglyphic board |

*(Add your actual screenshot images here, e.g. `![Main Menu](screenshots/menu.png)`)*

---

## ✨ Features

- 🕹️ **Two Game Themes** to choose from at startup (Main Menu).
- 👥 **Two-player local mode** (Player 1 vs Player 2 — no AI opponent).
- ✅ **Automatic win detection** — checks all rows, columns, and diagonals.
- 🟡 **Winning combination highlight** — the winning line lights up (green in Classic mode, gold in Pharaonic mode).
- 🤝 **Draw detection** when the board is full with no winner.
- 🔄 **Restart button** to reset the board and play again instantly.
- 🎨 **Custom board grid** drawn manually with `Graphics.DrawLine` for a polished look (no default WinForms borders).
- 🖼️ **Custom-themed icons** for X, O, and empty cells (standard icons in Classic mode, pharaonic-style icons in Egyptian mode).

---

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **IDE:** Visual Studio

---

## 📁 Project Structure

```
Progect_Tic_Tac_Toe_Game/
│
├── Form1.cs / Form1.Designer.cs      # Main Menu (theme selection)
├── Form2.cs / Form2.Designer.cs      # Classic Dark Theme game board
├── Form3.cs / Form3.Designer.cs      # Pharaonic Egyptian Theme game board
├── Properties/
│   └── Resources.resx                # Game images (X, O, question mark icons, backgrounds)
├── Program.cs                        # Application entry point
└── README.md
```

> ⚠️ Adjust the file names above to match your actual project structure if they differ.

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later recommended)
- .NET Framework / .NET Desktop Development workload installed

### Installation & Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/tic-tac-toe-game.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the project (`F5`).
5. Choose a theme from the main menu and start playing!

---

## 🎯 How to Play

1. Launch the app — you'll see the **Main Menu**.
2. Pick either **Classic Dark Theme** or **Pharaonic Egyptian Theme**.
3. Players take turns clicking empty cells:
   - Player 1 places **X**
   - Player 2 places **O**
4. The first player to align 3 symbols (row, column, or diagonal) wins — the winning cells get highlighted.
5. If all 9 cells are filled with no winner, the game ends in a **draw**.
6. Click **Restart** to play again.

---

## 🧩 Core Logic Overview

- A `3x3` array (`enPlayer[,] Board`) tracks the logical state of the game (separate from the visual buttons).
- `CheckThree()` checks if three given cells belong to the same player and aren't empty.
- `CheckWinner()` runs `CheckThree()` against all 8 possible winning combinations (3 rows, 3 columns, 2 diagonals).
- `HighlightWinner()` colors the winning cells for visual feedback.
- `ResetGame()` clears the board and resets all game state for a new round.

---

## 🔮 Possible Future Improvements

- 🤖 Add a **single-player mode** vs an AI opponent (Minimax algorithm).
- 🏆 Add a **scoreboard** to track wins across multiple rounds.
- 🎵 Add sound effects for moves, wins, and draws.
- 🌐 Add more themes (e.g., Space, Ocean, Retro).
- 📱 Port to a cross-platform framework (e.g., MAUI or WPF) for wider compatibility.

---

## 📄 License

This project is open-source and available for personal or educational use. Feel free to fork and modify it.

---

## 👤 Author

Made with ❤️ using C# and Windows Forms.
