# Gravity Dream — Open Source Physics Playground (Prototype)

**Purpose:** A small open-source Unity 2D prototype demonstrating gravity flipping, basic physics, collisions, and simple gameplay mechanics.
This repo is prepared to apply for JetBrains Open Source support.

## Quick demo
Press **Left/Right** to move. Press **Space** to jump. Press **G** to flip gravity.

## Files
- `Assets/Scripts/PlayerBall.cs` — movement & jump
- `Assets/Scripts/GravityController.cs` — flip gravity
- `Assets/Scripts/WallDetector.cs` — detects collisions with walls/ground and reports grounded state
- `Assets/Sprites/player.png` — placeholder sprite for player
- `README.md`, `LICENSE`, `REQUEST_JETBRAINS.txt`, `.gitignore`

## How to open
1. Use Unity 2020.3 LTS or later.
2. Create new 2D Unity project.
3. Copy the `Assets/` folder into your project root.
4. Create an empty Scene named `SampleScene` and add:
   - Circle Sprite -> name `PlayerBall`, add `Rigidbody2D` and `CircleCollider2D`, attach `PlayerBall.cs` and assign the sprite.
   - Empty GameObject -> name `GameController`, attach `GravityController.cs`.
5. Tweak physics in Project Settings > Physics 2D : Gravity = (0, -9.81)

## Roadmap
- Add collectible items
- Add enemy obstacles
- Add level design and tiles
- Add simple UI (score, lives)
- Add GIF/screencast demo

## License
MIT

## Development Tools

### GitHub Copilot
Need help with GitHub Copilot authorization? See **[COPILOT_SETUP.md](COPILOT_SETUP.md)** for:
- How to get free Copilot access (students & open-source maintainers)
- Step-by-step setup instructions for VS Code, JetBrains IDEs, and Visual Studio
- Troubleshooting authorization issues
- Verification steps

### JetBrains IDEs
See `REQUEST_JETBRAINS.txt` for the prepared message to JetBrains OSS program.

## Activity
Last updated: 2025-12-21 — Added GitHub Copilot setup documentation.
