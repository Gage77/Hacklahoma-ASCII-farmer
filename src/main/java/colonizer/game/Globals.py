#!/usr/bin/python3


class Globals():
    # several constants that will be used in the window creation
    SCREEN_WIDTH = 80
    SCREEN_HEIGHT = 50
    '''
    the starting posistion of the player, and the player's current posistion.
    CURRENTLY the view updates playerx & playery directly. This will likely
    change after the addition of a controller
    '''
    playerx = SCREEN_WIDTH // 2
    playery = SCREEN_HEIGHT // 2
