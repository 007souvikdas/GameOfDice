# Game Of Dice #
c# based console Application

## Usage ##

* There are three ways to execute the App.

1. Execute the App Directly
    * For this You need to have c# .Net core 3.0 installed
    * after that from the root project path execute "dotnet run"

2. Using custom built Docker container
    * Build a container of the App by executing following command from root project path:
    `docker build .`
    and once the docker container image is created, execute it by running:
    `docker run -it game_of_dice`

3. Using publicly accessible Docker container
    * Simply fetch and run the public docker image:
    * for pulling the image:
    `docker pull souvikddss/game_of_dice`
    * for executing the image:
    `docker run -it souvikddss/game_of_dice`

## Appreciation ##

* Please drop a mail at souvikddss@gmail.com , if I am selected for the next process