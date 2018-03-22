#!/usr/bin/python3
'''
**************************
* Mission: Colonizer     *
**************************
*
***************************************
* Modificatoin History:
*   creation & python3 switch
*
**************************************
* @author Conner Flansburg, Hunter Black
* @version 0.851
*
****************************
* Last Edited: March 22
****************************
'''
import tdl
import Globals  # holds the games global varibles
import GameHUD  # forms most of the view, and may be in a wrapper class later


class colonizerGameEngine():

    '''
    main
    This is the main method for the colonizer game. It will create and
    manage the objects that will create and managae the game
    '''
    def main():
        '''
        The following creates and sets the default behavior of the terminal it:
        1. creates the default window
        2. places the player at the center of the mapMay set the fps rate
        3. may set the fps rate
        '''
        # several constants that will be used in the window creation
        SCREEN_WIDTH = Globals.SCREEN_WIDTH
        SCREEN_HEIGHT = Globals.SCREEN_HEIGHT
        # LIMIT_FPS = 20  # used for realtime instead of turnbased
        # sets a custom font TODO decide on a font, this is filler for now
        tdl.set_font('arial10x10.png', greyscale=True, altLayout=True)
        # creates the console window
        console = tdl.init(
            SCREEN_WIDTH,
            SCREEN_HEIGHT,
            title="Missions: Colonizer",
            fullscreen=False)

        # NOTE use to allow for 'realtime' gameplay vs turnbased
        # tdl.setFPS(LIMIT_FPS)

        '''
        The following creates and manages the main menu. This should later be
        moved in to a view file in order to meet MVC desgin standards

        The following creates and manages the game. This should later be
        moved in to model & controller files in order to meet MVC desgin
        standards
        '''
        # TODO write menu as a wrapper class for GameHUD to handle all of view

        # when a player starts a new game
        game = None
        game.initGame(console)

        # when a player loads a game
        # game = loaded
        # game.initGame(console)

    '''
    initGame
    this will initialize the game and manage the game objects. Each interation
    of the top while loop represents 1 turn.
    Parameter self:
        This will be the object initGame is called on (spam.initGame()), and
        could be a saved game or new game.
    Parameter console:
        This is the console that the window is being played in.
    Return:
        initGame returns the None object or -1 on an error. Later this may
        create objects and return them to main
    '''
    def initGame(self, console):
        # TODO write code for load game option

        if self is None:  # if no game was loaded
            # runs until the window is closed
            while not tdl.event.is_window_closed():
                # draws the player as an '@' and sets the color
                console.draw_char(Globals.playerx, Globals.playery, '@',
                                  bg=None, fg=(191, 95, 0))
                # redraw changes
                tdl.flush()
                # draws a space behind the player to prevent trailing @s
                console.draw_char(Globals.playerx, Globals.playery
                                  , ' ', bg=None)  # TODO change
