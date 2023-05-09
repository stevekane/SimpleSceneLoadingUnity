# Design overview

## Objective

I want to make a dead simple Kart-racing prototype. The goal is just to have some fun
and to make a very small project that helps to answer some architectural questions
that have been bothering me in our larger project.

## Goals

1. Route inputs through new InputSystem. Support menus and main gameplay.
2. Support choosing a track to load from a menu.
3. Support changing the color of your car in a menu.
4. Four-button steering system: Accel, Brake, Left, Right
5. Restart track bound to a button.
6. Open menu bound to a button.
7. Display timer for each track run.
8. Show results screen with your time, the current best time, and a medal rating.

## Tracks

- Tracks have three medal timings: Gold, Silver, Bronze.
- Tracks have a goal that you must reach to end the race.
- Tracks have a starting location.
- Tracks have physics materials that affect handling.

## Karts

- Karts can accelerate affected by grip and current speed.
- Karts can turn affected by grip and current speed.
- Karts can brake affected by grip and current speed.
- Karts will slide when their desired forward vector can not be reached.
- Kart wheels determine the desired forward vector.
- Karts wheels sliding generate less acceleration.
- Kart wheels sliding generate friction and cause deceleration.

## Collectibles

- Collectibles appear in sequences on the track.
- Collectibles form a tree structure with multiple roots.
- Each collectible exists at a level within the tree.
- Grabbing collectibles in-order grants bonus speed.
- Missing a collectible causes speed loss and resets combos.
- Combos grant a rating for a track based on number of collectibles grabbed during the run.

## Run

A run consists of several pieces of state that are captured during the run
and presented back to the player at the end.

- Time
- Collectibles
- Combo streak
- Top speed

## Menu

When menus are open, only menu actions are available.