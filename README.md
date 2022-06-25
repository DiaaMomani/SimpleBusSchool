# SimpleBusGame
 This game was a university subject project and that's why it's done using visual studio not unity.
 We make it as a team of 5 memebers and here is some explanation of our work.
 In this trial of the game the data is stored in the 
 In the sign Up form we give the user 3 themes of the road that he's going to play in , then in the load function inside every level we change the background and the pictures in pictureBoxs according to the player's selection.
 The intersection between the Bus and the sidewalk is handled by checking the intersection between the sidewalk pictureBox and the Bus pictureBox if it's true then the Bus will be placed exactly before the sidewalk using mathmatical equations (colliders).
 The rotation of the bus while moving is handled by changing the (rotate) function using the suitable edge according to it's previous and new direction.
 The History form represents the player profile information ,score and duration of each game played and it's done while playing the game inside each level there is a temporary score variable that keep changing while the levels isn't finished and when the player click the end button the information is stored with the player name in a special history list to be represented in the History form.
 In the previous form ( History ) the steps is also represented and it's stored by saving the move that is done in that moment in a list of steps to be represented in the form.
 The statstics is checked after the end of each game and change if necessary.
 The Bounes is the record that replay the last played game and it's handeled by creating a list of locations to save the location of the Bus each timeTick and display it to move exactly like the last played game.
