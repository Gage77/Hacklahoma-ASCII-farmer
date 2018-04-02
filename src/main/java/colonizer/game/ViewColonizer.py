#!/usr/bin/python3

import tdl
import GameHUD  # will handle the in game view


class ViewColonizer():

    # class varibles
    rootConsole = None
    offScreen = None

    '''
    __init__
    this is the constructor for the view.

    Parameters:
        console
        This is the primary "root" console for the game. It will be managed
        by the viewColonizer so it needs to be passed it once it is created
    '''
    def __init__(self, root, off):
        # creates an off screen console object
        self.rootConsole = root
        self.offScreen = off

    '''
    createMenu
    creates the main menu

    return:
        returns a 1 when a new game is seleceted and
        0 when load a game is seleceted
    '''
    def createMenu(self):
        '''
        The code below takes the txt menu we have and make cuts it into two
        parts. One part will conatin only the title while the other half will
        contain the menu options. This is so the title can be color using
        ANSI escape codes & may be removed in later releases. We may also
        choose to color options in ()'s later.
        '''
        # creates the text for the main menu
        title = ''  # will hold the title text
        menu = ''  # will hold the menu text
        for line in open('asciiTitle.txt'):
            if "Press" not in line:  # while we are still on the title
                title = title + line  # keep building the title
            else:
                menu = menu + line  # otherwise build the menu
        # TODO makes sure that the menu print correctly
        # I'm not sure I undstand tdl's cursor or how it moves
        menu = "\033[1;31;40m "+menu  # ANSI escape coloring
        self.rootConsole.move(0, 0)  # sets cursor to top left corner
        self.rootConsole.print_str(title)  # prints the title
        self.rootConsole.print_str(menu)  # prints the menu

        '''
        The code below handles the actual menu operations and will call other
        methods based on the choice(s) may be the user. Only the new game,
        load game, and exit options should exit the menu. All others should
        return to it after displaying either the help menu or the
        donation page.
        '''
        while True:  # should not need to break as all exits options return
            choice = input()  # user input
            if choice is 1 or "new game" in choice.lower:
                return 1  # tells the caller to run a new game
            elif choice is 2 or "load" in choice.lower:
                return 0  # tells the caller to load a game
            elif choice is 3 or "exit" in choice.lower:
                return runExit  # tells the caller to end the program
            elif choice is 4 or "donate" in choice.lower:
                runDonate  # runs donate but returns to the main menu
            elif choice is 5 or "help" in choice.lower:
                runHelp()  # runs donate but returns to the main menu
            else:  # invalid input. This string is largely a placeholder
                print('What you have entered is not a valid input. '
                      + 'Please enter either the number of you selection '
                      + 'or the text within the parentheses (for example '
                      + 'New Game)')

    '''
    updateView
    Updates the views controlled by viewColonizer

    return:
        None
    '''
    def updateView(self, root=None, off=None):
        if root is not None:
            self.rootConsole = root
        if off is not None:
            self.offScreen = off

    '''
    createHUD
    creates the in game hud when called. this should be used by the
    controller to create an in game view.

    return:
        None
    '''
    # TODO write helper methods for the viewColonizer
    def createHUD(self):
        pass
        # this will create the in game view

    '''
    showHelp
    displays the help window

    return:
        None
    '''
    def runHelp(self):
        pass
        # this will change the display to the help menu and
        # then return to the main menu

    '''
    runDonate
    opens a donation webpage

    return:
        None
    '''
    def runDonate(self):
        pass
        # this will open a wepage, but not leave main
        # OR it could go to an in program donate page

    '''
    runExit
    exits the program and serves as the quit option. This gives so saftey
    message (i.e. "Are you sure?") as it is assumed you are in the main menu
    and so no data would be lost

    return:
        returns -999 to tell the controller to end the program
    '''
    def runExit(self):
        return -999
