#!/usr/bin/python3

import tdl
from ModelColonizer import ModelColonizer  # the model
from ViewColonizer import ViewColonizer  # the view
import Globals  # holds the games global varibles


class ControllerColonizer():

    '''
    __init__
    this is the constructor for the controller. As soon as it is created it
    goes to work managing the model & view of the game. All of the game's
    functionality happens inside of this constructor. On a request to exit
    it will raise an SystemExit Exception which will be caught be the
    colonizerGameEngine that created that instance of the ControllerColonizer.
    '''
    def __init__(self, rootConsole):

        # creates an off screen console object
        offScreen = tdl.Console(Globals.SCREEN_WIDTH,
                                Globals.SCREEN_HEIGHT)

        # creates the model & view
        model = ModelColonizer()  # a ModelColonizer object
        view = ViewColonizer(rootConsole, offScreen)  # a ViewColonizer object

        # creates a main menu
        menuAction = view.createMenu()

        # these options connect the main menu view with the model
        if menuAction is 1:  # if the player selected new game
            model.initGame(rootConsole, offScreen, True)

        elif menuAction is 0:  # if the player selected load a game
            model.initGame(rootConsole, offScreen, False)

        elif menuAction is -999:  # if the player has selected quit
            raise SystemExit()  # this will be caught by the engine


'''
all other methods should be helper functions only. Everything else is done
in the constructor
'''
