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
import ControllerColonizer
import sys


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

        # redirects standard out to the console we have created
        sys.stdout = console

        # NOTE use to allow for 'realtime' gameplay vs turnbased
        # tdl.setFPS(LIMIT_FPS)

        '''
        The following creates and manages the controller object which in turn
        creates and manages the model & the view

        '''
        try:  # this try is waiting for the exit request
            # do I need to assing the controller to a varible?
            controller = ControllerColonizer(console)
        except SystemExit:
            pass  # TODO write code to exit gracefully
