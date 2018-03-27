#!/usr/bin/python3
'''
**************************
GameHUD class

This class will create and manage the player's HUD after
entering a game. It will be responsible for managing
the keyboard inputs connected to the HUD and will communicate
with the map & character classes in order to display the correct
input & inform other classes that they need to run
(i.e. shop & save screen). This class will form a large part of
the View in the MVC design
****************************
'''

import tdl
import Globals


class GameHUD():

    '''
    keyboardIn
    this will respond to the player's keyboard input. Currently
    this just handles player movement and esc
    '''
    @staticmethod  # currently the engine uses this as a static method
    def keyboardIn():  # IDEA move this to the controller in the MVC desgin?
        # creates a listener for a turnbased game, change for realtime game
        playerIn = tdl.event.key_wait()

        '''
        sets the behavior of the movement keys & updates the players posistion
        in relation to the starting location
        '''
        if playerIn.keychar == 'w':
            Globals.playery -= 1  # move up
        elif playerIn.keychar == 's':
            Globals.playery += 1  # move down
        elif playerIn.keychar == 'a':
            Globals.playerx -= 1  # move left
        elif playerIn.keychar == 'd':
            Globals.playerx += 1  # move right

        # opens a quit dialog box if player hits esc
        elif playerIn.key == 'ESCAPE':
            pass  # TODO write a save & quit confirm message class
