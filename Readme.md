# Basketball Club System Design

## Class Diagram

using System.Collections.Generic;
using System.Numerics;
using System.Security.Policy;
using System.Text.RegularExpressions;

The following class diagram represents the structure of the basketball club system, including classes for teams, players, managers, and matches.

```mermaid
classDiagram
    class Team
{
        +string teamName
        +int teamID
        +list players
        +addPlayer(player: Player)
        +removePlayer(player: Player)
    }

class Player
{
        +string playerName
        +int playerID
        +string position
        +int score
        +playGame(match: Match)
        +scorePoints(points: int)
    }

class Manager
{
        +string managerName
        +int managerID
        +scheduleMatch(match: Match)
        +organizeTeam(team: Team)
    }

class Match
{
        +string matchDate
        +Team team1
        +Team team2
        +string result
        +startMatch()
        +endMatch()
    }

Team "1" o-- "*" Player : has
Manager "1" o-- "*" Team : manages
Manager "1" o-- "*" Match : organizes
Match "1" o-- "2" Team : includes