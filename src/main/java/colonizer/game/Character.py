#!/usr/bin/python3

'''
GameObject class

this class is a generic game object (npc, monster, player, etc) and
will primaryly be used for as an interface
'''


class GameObject:

    def __init__(self, x, y, char, color):
        self.x = x
        self.y = y
        self.char = char
        self.color = color

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
    pass
