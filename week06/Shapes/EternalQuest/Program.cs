// Eternal Quest Program - CSE 210 W06 Project
// This program meets all base requirements using inheritance and polymorphism.
// 
// CREATIVITY / EXCEEDING REQUIREMENTS:
// I added a dynamic leveling system (every 1000 points = new level).
// It shows level title (e.g. "Ninja Unicorn"), progress bar, and a fun "LEVEL UP!" message
// when you earn enough points. This directly implements the gamification "level up" idea
// from the problem description to keep users motivated on their Eternal Quest.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}