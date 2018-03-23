#!/usr/bin/python3

'''
GameObject class

this class is a generic game object (npc, monster, player, etc) and
will primaryly be used for as an interface
'''


class GameObject:

    def __init__(self, x, y, char, color):
        self.x = x  # the starting x coordinate
        self.y = y  # the starting y coordinate
        self.char = char  # the character that will represent it
        self.color = color  # the color of that character

    #  move the object
    def move(self, dx, dy):
        self.x += dx
        self.y += dy

    # draws the char that represents the object
    def draw(self, offScreen):
        offScreen.draw_char(self.x, self.y, self.char, self.color)

    # clears the character
    def clear(self, offScreen):
        offScreen.draw_char(self.x, self.y, ' ', self.color, bg=None)


'''
player class

this class will be used to represent the player character. Currently it has
functionality outside of what it has inheritted from the GameObject class
'''


class player(GameObject):
    pass  # TODO create character object


'''
plant class

this class will be used to represent plants. Each plant has a set of
coordinates, a character, a character color, and a name (though it may be None)
'''


class plant(GameObject):

    def __init__(self, x, y, char, color, foodVal=5, name=None):
        self.x = x  # the starting x coordinate
        self.y = y  # the starting y coordinate
        self.char = char  # the character that will represent it
        self.color = color  # the color of that character
        self.name = name  # the name of the plant
        self.foodVal = foodVal  # the hunger the plant will restore

    def grow(self, amount=10):  # used for growing plant
        pass

    def plant(self, location):  # used for planting plants at a location
        pass

    '''
    getName
    Get name will retrun the current name of a plant, possibly after
    renaming it.

    Parameters:
        newName
        Setting newName will renaming the plant to the text held in newName

    Return:
        getName will return the name of current the object after any requested
        renames.
    '''
    def getName(self, newName=None):  # returns or sets the plant name

        # if the plant has no name and we are not renaming it
        if self.name is None and newName is None:
            self.name = "A Mysterious Plant"  # use defualt name
            return self.name

        elif self.name is None:  # if we are renaming the plant
            self.name = newName
            return self.name

        elif self.name is not None:  # if name already has a value
            return self.name  # use it


    pass  # TODO create plant object
