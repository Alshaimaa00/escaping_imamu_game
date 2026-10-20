<div align="center" style="margin-bottom: 30px;">

# Flappy Girl at Imam University 🎓🌴

**Fly through the gates of campus, collect coins, and earn your cup.**

</div>

---

## 📍 About the Game 📍
Flappy Girl at Imam University is a 2D arcade game built in Unity. It takes the classic Flappy Bird idea and gives it a campus twist: instead of a bird, you play as a university student running late with her tablet and bag, and instead of pipes, you dodge the arched gates inspired by Imam University's architecture. Pass the gates, collect coins, unlock a shield, and win a silver or gold cup before the timer runs out.

---

## 🌟 Key Features

- **Campus Theme** 🏛️: Pixel-art palm trees, a road, and sand-coloured gates styled after the university
- **Shop & Character Selection** 🛍️: Pick your student from a lineup of characters before you play
- **Two Difficulty Levels** 🎚️: Easy (slow speed, wide gaps) and Hard (fast speed, narrow gaps)
- **Collectible Coins** 🪙: Coins appear at random positions between the gates
- **Score System** 🔢: Tracks both passed gates (PipeScore) and collected coins (CoinScore)
- **Cup Rewards** 🏆: A silver cup after 10 gates, which turns gold at 20 gates
- **Shield Reward** 🛡️: Collect 10 coins to survive crashes for a limited time
- **Countdown Timer** ⏱️: The game ends after a fixed time, and your final scores are shown
- **Sound Effects** 🔊: Background music, collision, game over, and victory sounds

---

## 💻 Tech Stack

- 🎮 **Unity (2D)**: Game engine
- 💻 **C#**: Game scripts
- 🎨 **Pixel Art**: Characters, gates, coins, and cups
- 🔊 **MP3 Audio**: Music and sound effects
- 🐙 **GitHub**: Version control

---

## 🎮 How to Play

- **Control your character** to fly through the gaps between the gates without touching them
- **Collect coins** to raise your CoinScore
- **Pass gates** to raise your PipeScore
- **Watch the timer** in the bottom-right corner, because the round ends when it reaches zero

### 🏅 Rewards

| Reward | How to get it |
| --- | --- |
| 🥈 Silver Cup | Pass **10** gates, and it appears at the top of the screen |
| 🥇 Gold Cup | Pass **20** gates, and the silver cup turns gold |
| 🛡️ Shield | Collect **10** coins to survive crashes for a limited time |

---

## 📱 Screens Overview

1. **Start Menu (🏠)**: Game title, a **shop** button, **Select Level**, and **play**.
2. **Select Character (👩‍🎓)**: Choose your student from the shop lineup, with a **back** button.
3. **Gameplay (🎯)**: PipeScore and CoinScore at the top, a countdown timer, coins, and moving gates.
4. **Silver Cup (🥈)**: Appears in the top-right corner after passing 10 gates.
5. **Gold Cup (🥇)**: The cup changes to gold after passing 20 gates.

<div align="center" style="margin: 20px 0;">

![Start menu](assets/screens/start-menu.png)

![Select character](assets/screens/select-character.png)

![Gameplay](assets/screens/gameplay-start.png)

![Silver cup](assets/screens/silver-cup.png)

![Gold cup](assets/screens/gold-cup.png)

</div>

---

## 🚀 Getting Started

1. Install [Unity Hub](https://unity.com/download) and a Unity editor version.
2. Clone the repository:

```bash
git clone https://github.com/Alshaimaa00/escaping_imamu_game.git
```

3. In Unity Hub, click **Add**, then choose the cloned folder.
4. Open the project. Unity will rebuild the `Library` folder automatically, so the first launch can take a few minutes.
5. Open the scene `Assets/Scenes/startMenu.unity` and press **Play**.

---

## 📂 File Structure

```
escaping_imamu_game
├── Assets
│   ├── Scenes
│   │   ├── startMenu.unity     # Start menu, shop, and level select
│   │   └── GameScene.unity     # The main game
│   ├── CharacterSkin.cs        # Character selection script
│   ├── DropdownToggle.cs       # Menu dropdown script
│   ├── coin.prefab             # Collectible coin
│   ├── imamu.prefab            # Gate obstacle
│   ├── girl1.png ... girl5.png # Playable characters
│   ├── seliver.png / gold.png  # Silver and gold cups
│   ├── backgroundpic.PNG       # Campus background
│   └── *.mp3                   # Background, collision, game over, and victory sounds
├── Packages
├── ProjectSettings
└── README.md
```

---

## 🎓 Course Project

This game was built for **CS 458: Game Application Development** at the College of Computer and Information Sciences, Imam Mohammad Ibn Saud Islamic University. It was developed in three phases:

1. **Phase 1**: Core Flappy Bird game, start menu, two difficulty levels, and sound effects
2. **Phase 2**: Shop system, collectible coins, score system, and cup and shield rewards
3. **Phase 3**: Game design documentation

---

## ℹ️ More Information

[🔗 Repository](https://github.com/Alshaimaa00/escaping_imamu_game)

---
