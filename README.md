# MLBApp
![Capture8](https://user-images.githubusercontent.com/60584724/75937434-360bcf80-5e5b-11ea-94a1-29a1d29ef852.PNG)

Api Information:
https://appac.github.io/mlb-data-api-docs/#player-data-player-search-get

Endpoint used:
/json/named.team_all_season.bam?sport_code='mlb'&all_star_sw={all_star_sw}&sort_order={sort_order}&season={season}

Retrieve a list of major league teams that were active during a given season.

If all_star_sw is set to 'Y', you will instead receive data on the all star teams for that season.

You can sort using the sort_order paramater. Ex: Sort in ascending order by the name field using sort_by='name_asc'

URI Parameters
- all_star_sw
string (optional) Example: 'N'
Set to ‘Y’ for all star data, and ‘N’ for regular season.

- season
string (required) Example: '2017'
