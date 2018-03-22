#!/usr/bin/python3

import tdl
import ViewColonizer  # the view
import ModelColonizer  # the model
import Globals  # holds the games global varibles


class ControllerColonizer():

    '''
    __init__
    this is the constructor for the controller.
    '''
    def __init__(self, rootConsole):

        # creates an off screen console object
        offScreen = tdl.Console(Globals.SCREEN_WIDTH,
                                Globals.SCREEN_HEIGHT)

        # creates the model & view
        model = ModelColonizer()  # a ModelColonizer object
        view = ViewColonizer(rootConsole, offScreen)  # a ViewColonizer object

        # creates a main menu
        menuAction = view.createMenu

        if menuAction is 1:  # if the player selected new game
            model.initGame(rootConsole, offScreen, True)

        if menuAction is 0:  # if the player selected load a game
            model.initGame(rootConsole, offScreen, False)


'''
all othe methods should be helper functions only. Everything else is done
in the constructor
'''
