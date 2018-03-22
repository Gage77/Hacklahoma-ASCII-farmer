#!/usr/bin/python3


import tdl
import Globals  # holds the games global varibles


class viewColonizer():

    '''
    __init__
    this is the constructor for the view.
    '''
    def __init__(self, rootConsole, offScreen):
        pass

    '''
    createMenu
    creates the main menu

    return:
        returns a 1 when a new game is seleceted and
        0 when load a game is seleceted
    '''
    def createMenu(self, rootConsole):
        # creates the text for the main menu
        title = ''  # will hold the title text
        menu = ''  # will hold the menu text
        for line in open('asciiTitle.txt'):
            if "Press" not in line:  # while we are still on the title
                title = title + line  # keep building the title
            else:
                menu = menu + line  # otherwise build the menu
            # TODO go back a pull out things in () so they can be colored
        # prints the main menu
        rootConsole.set_colors(fg=(191, 95, 0))  # set color to red/orange
        rootConsole.move(0, 0)  # sets cursor to top left corner
        rootConsole.print_str(title)  # prints the title
        rootConsole.set_colors(fg=(255, 255, 255))  # set color to white
        rootConsole.print_str(menu)  # prints the menu
        # TODO add menu functionality
        # stay in here until either a new game or load game is selected

    '''
    showHelp
    displays the help window

    return:
        None
    '''
    def showHelp(self):
        pass
