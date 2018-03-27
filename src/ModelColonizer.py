#!/usr/bin/python3


import tdl
import Character
import Globals  # holds the games global varibles


class ModelColonizer():

    '''
    __init__
    this is the constructor for the model.
    '''
    def __init__(self):
        pass

    '''
    initGame
    this will initialize the game and manage the game objects. Each interation
    of the top while loop represents 1 turn.
    Parameter self:
        This will be the object initGame is called on (spam.initGame()), and
        could be a saved game or new game.
    Parameter rootConsole:
        This is the rootConsole that the window is being played in.
    Return:
        initGame returns the None object or -1 on an error. Later this may
        create objects and return them to main
    '''
    def initGame(self, rootConsole, offScreen, isNewGame=True):

        if isNewGame:  # if new game was selected
            player = Character.player(Globals.playerx, Globals.playery,
                                      '@', (191, 95, 0))  # make the player
            '''
            this list will hold all of the objects
            in the map (plants, tools, the player...)
            '''
            allThings = [player]
            # TODO move this loop into the controllor and have initGame reuturn
            # runs until the window is closed
            while not tdl.event.is_window_closed():
                # draws the everything on the map NOTE move to view?
                for thing in allThings:
                    thing.draw()
                # pushes what is in offScreen to the rootConsole
                rootConsole.blit(offScreen, 0, 0, Globals.SCREEN_WIDTH,
                                 Globals.SCREEN_HEIGHT, 0, 0)
                # redraw changes
                tdl.flush()

                # TODO game functionality goes here
                '''
                should we have some class that handles the actaul turns in the
                game?
                '''

                # erase all objects at their old locations, before they move
                for thing in allThings:
                    thing.clear()
                # TODO make sure that the tile the player is on is restored to
                # whatever it was before

        else:  # if a game is to be loaded
            pass  # TODO write code for load game option
