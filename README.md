# AspNetApiPractice - Leaderboard

ASP.Net Core(3.1) API

### What is this
  - This leaderboard is an API which is backed by a SQL database. User scores can be read and posted with HTTP requests, and the interface can easily be implemented in your games, regardless of the genre.
 - Uses PostgresSQL database (haven't been tested with other databases)
 - Basic asp.net core web api practise task.
  - Made as a practice task to learn asp.net core web api. 
  

### Requirements
- Clone and make sure requirements are installed.
- Remember to change database lcoation in startup folder before use. 

### EndPoints
### Score
| Method | URL | Description |
| ------ | ------ | ------ |
| GET | api/scores/ | Get all scores|
| GET | api/scores/{id:int} | Get score by id |
| POST | api/scores/| Add a new score |
| DELETE | api/scores/{id:int}| Delete score by id|


### Player
| Method | URL | Description |
| ------ | ------ | ------ |
| GET | api/players | Get all players |
| POST | api/players | Make a new player|


### Level
| Method | URL | Description |
| ------ | ------ | ------ |
| GET | api/levels | Get all levels |
| POST | api/levels | Make a new level|
