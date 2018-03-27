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

    def move(self, dx, dy):  # move the object
        self.x += dx
        self.y += dy

    def draw(self, offScreen):  # draws the char that represents the object
        offScreen.draw_char(self.x, self.y, self.char, self.color)

    def clear(self, offScreen):  # clears the character
        offScreen.draw_char(self.x, self.y, ' ', self.color, bg=None)


'''
player class

this class will be used to represent the player character. Currently it has
functionality outside of what it has inheritted from the GameObject class
'''


class player(GameObject):

    hasHoe = False  # does the player have a hoe
    hasShovel = False  # does the player have a shovel
    hasTorch = False  # does the player have a flashlight
    hunger = 100  # how close is the player to starving in % form

    def eat(self, amount=10):  # become less hungery
        self.hunger = self.hunger + amount
        if self.hunger > 100:  # if hunger would be higher than 100%
            self.hunger = 100  # cap at 100%
        return self.hunger

    def calcScore(self):
        pass  # will caclulate the player's current score

    def inventory(self):
        pass  # will manage the player's inventory

    def attack(self):
        pass  # will handle the player's attack and rtn damage for combat
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

    def howHealthy(self):    # will return the foodVal of the plant after
        return self.foodVal  # after any needed conversions

    '''
    getName - Get name will retrun the name of a plant

    Parameters - newName: Setting newName will renaming the plant to the
    text held in newName

    Return - getName will return the name of current the object after
    any requested renames.
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


'''
terrain

this class will be used to represent every terrain feature
'''


class terrain(GameObject):

        # the constructor for a terrain object
        def __init__(self, x, y, char):
            self.x = x  # the starting x coordinate
            self.y = y  # the starting y coordinate
            self.char = char  # the character that will represent it
            # sets the color of the char by getting it's type & type color
            self.color = colorType(char)

        '''
        interact method - When called on a terrain object this method will
        return a list of all the possible player interactions with it.

        return - this method will return a list so that multiple interactions
        can be allowed on the same piece of terrain.
        '''
        def interact(self):  # given a location what ca be done to it?
            type = char2Type(self.char)
            if type is 'tilled':
                return ['plant']
            if type is 'dirt':
                return ['till']
            # TODO write the rest of the logic

        '''
        char2Type method - This method is called statically, and it will
        attempt tell the caller what terrain type the char/string represents
        on our map (i.e. dirt or mountains).

        return - this method will return name of the terrain type as a string
        '''
        @staticmethod
        def char2Type(char):  # given a character, what type of land is it?
            pass  # TODO write code connect chars with their land type

        @staticmethod
        def colorType(char):  # color the char correctly
            type = char2Type(char)  # get the chars type
            # TODO write coloring logic
            color = 'someRGB value'  # placeholder
            return color
