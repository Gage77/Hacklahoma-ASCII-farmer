#!/usr/bin/python3

'''
This will handle back end of the shop and be used by the GUI to fetch
information and strings
'''


class Shop:

	credits = 0  # will hold the amount of spending cash the player has
	playerPlants = []  # will hold all of the players plants

	'''
	the constructor can take a number (called cr) for the $$ of the player &
	a list of plants that the player is carrying
	'''
	def __init__(self, cr, playerPlants=[]):  # NOTE we might need to make some of these optional later
			credits = cr;
			self.pcPlants = pcPlants;

	'''
	Pruchase
	This will be used to process an item selected in the GUI. It will be used
	to print a sale confirmation & and to return the correct object
	'''
	# NOTE currently this function just returns a string
	# later we will make it return objects. Also print must be redirected
	def purchase(self, selectedLine):
		# if the purchased a shovel
		if selectedLine.find('shovel') != -1:
			print("Sit tight, your shipment is on it's way colonizer!")
			return "shovel"  # will make picking up plants faster
		# if the purchased a hoe
		elif selectedLine.find('hoe') != -1:
			print("Sit tight, your shipment is on it's way colonizer!")
			return "hoe";  # makes tilling faster
		# if the purchased a MRE
		elif selectedLine.find('MRE') != -1:
			print("Sit tight, your shipment is on it's way colonizer!");
			return "MRE";  # foods that adds a lot to hunger 50+
		else:
			return -1;  # returns a -1 to indicate an invalid selection

	'''
	createShopView
	this method will create & format a string
	that will be used for the shop display
	'''
	def createShopView(self):
		shopView = '''(Your radio crackles) This is Colonial Requisition.
		How can we help?
		1. Shovel   4. sell
		2. hoe      5. Exit
		3. MRE

		Your colonie's budget is: {wealth} Cr\n'''.format(wealth=credits)
		return shopView

	'''
	createSellView
	this will bring up and handle the sell screen
	'''
	def createSellView():  # TODO finihs implentation
			i = 0  # this will be use as the index for the list
			# fetches the number of plants the player has
			count = playerPlants.len()
			# this will create the first prompt line
			sellView = "Profits are the priority of all colonizers!\n"

			k = 1  # k will count the number of items being displayed
			'''
			this loop should move through the array printing each
			entry with the format 1. plant info
			'''
			for i in playerPlants:  # NOTE is this logic correct?
				sellView = sellView + k + '. '+i+'\n'
				k = k+1  # increment k
				if k > 3:  # if the player has more than 3 plants in inventory
					# make multiple pages
					# NOTE how would I do that?

			# appends the exit option to the end of the menu
			sellView = sellView + (k-1) + ". Exit"
			return sellView

//end of class shop
