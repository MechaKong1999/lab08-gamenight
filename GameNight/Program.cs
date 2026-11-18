/*
* Name: Terry McCulley
* Course: CSCI 1250, Section 001
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

using System.Drawing;

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

// Look for the data files next to Program.cs, however the program is started.
string projectFolder = Path.GetFullPath(
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] points  = File.ReadAllLines(POINTS_FILE); 
string[] night = File.ReadAllLines(HISTORY_FILE);
string[] winner = File.ReadAllLines(HISTORY_FILE);

static int LeaderIndex(string[] points)
{
    int a = Convert.ToInt32(points[1]);
    int b = Convert.ToInt32(points[2]);
    int c = Convert.ToInt32(points[3]);
    int d = Convert.ToInt32(points[4]);

}

static int TotalPoints(string[] points)
{
    int a = Convert.ToInt32(points[1]);
    int b = Convert.ToInt32(points[2]);
    int c = Convert.ToInt32(points[3]);
    int d = Convert.ToInt32(points[4]);
}

static string HistoryEntry(int night, string winner, int points)
{
    int a = Convert.ToInt32(points[1]);
    int b = Convert.ToInt32(points[2]);
    int c = Convert.ToInt32(points[3]);
    int d = Convert.ToInt32(points[4]);
}