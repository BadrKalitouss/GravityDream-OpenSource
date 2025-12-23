# Copilot Instructions for Gravity Dream

This file provides context to GitHub Copilot when working on the Gravity Dream project.

## Project Overview

Gravity Dream is an open-source Unity 2D physics playground prototype demonstrating:
- Gravity flipping mechanics
- Basic 2D physics and movement
- Collision detection
- Simple gameplay controls

## Code Style and Conventions

When suggesting code for this project, please follow these guidelines:

### Unity C# Conventions
- Use PascalCase for public methods and properties
- Use camelCase for private fields (with underscore prefix optional)
- Follow Unity's component-based architecture
- Use `[SerializeField]` for private fields that should be visible in Inspector
- Add XML documentation comments for public APIs

### Physics and Movement
- Use Unity's built-in physics system (Rigidbody2D)
- Keep movement logic in Update() or FixedUpdate() as appropriate
- Use collision detection via OnCollisionEnter2D/Exit2D
- Maintain separation between input handling and physics

### Project Structure
- Keep scripts in `Assets/Scripts/`
- Keep sprites in `Assets/Sprites/`
- Maintain simple, readable code suitable for educational purposes

## Key Components

### PlayerBall.cs
- Handles player movement (left/right)
- Manages jumping mechanics
- Respects grounded state from WallDetector

### GravityController.cs
- Toggles gravity direction (up/down)
- Affects Physics2D.gravity globally

### WallDetector.cs
- Detects ground and wall collisions
- Provides grounded state to player controller

## Development Notes

- This is an educational prototype - prioritize clarity over optimization
- Comment non-obvious physics calculations
- Keep dependencies minimal (Unity built-ins preferred)
- Target Unity 2020.3 LTS or later

## Future Features (Roadmap)
- Collectible items system
- Enemy obstacles
- Level design with tilemaps
- Simple UI (score, lives)
- Demo GIF/screencast

When suggesting code additions, consider these planned features for maintainability.
