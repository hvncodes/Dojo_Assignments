from card import Card
import random
class Deck:

    def __init__( self ):
        suits = [ "spades" , "hearts" , "clubs" , "diamonds" ]
        self.cards = []
        # self.card_value = Card.point_val

        for s in suits:
            for i in range(1,14):
                str_val = ""
                if i == 1:
                    str_val = "Ace"
                elif i == 11:
                    str_val = "Jack"
                elif i == 12:
                    str_val = "Queen"
                elif i == 13:
                    str_val = "King"
                else:
                    str_val = str(i)
                self.cards.append(Card( s , i , str_val ) )
        print(len(self.cards))
    
    def show_cards(self):
        for card in self.cards:
            card.card_info()

    def draw_random(self):
        #randrange(1,52+1)
        return self.cards[random.randint(0,51)] # We got an out of range error from 1,52 so we changed to 53... will that change the range error?  
                                                # SOLUTION(Index has to start at 0 because it was cutting off the first card, and then 52 was one card out of range... hast to be 51. So, 0-51 = 52 cards