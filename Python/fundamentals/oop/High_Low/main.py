# user class
from deck import Deck

class User:
  def __init__(self, name):
    self.name = name
    self.life_points = 5
    self.deck = Deck()

    # draw card function
  def draw_and_compare_display(self, other_Self):
    player_1_card = int(self.deck.draw_random().point_val)
    player_2_card = int(other_Self.deck.draw_random().point_val)
    print(player_1_card, player_2_card)
    if player_1_card == player_2_card: # we'll need to get the function call from the card class
      print("draw")
      print(f"{self.name} loses round and now has: {self.life_points}")
    elif self.life_points == 0:
      loser = print(f"{self.name} has 0 life points. \n{other_Self.name} is the winner!")
      return loser
    #when player two loses 
    elif other_Self.life_points == 0:
      loser = print(f"{other_Self.name} has 0 life points. \n{self.name} is the winner!")
      return loser
    #when player one loses 
    elif player_1_card < player_2_card:
      self.life_points -= 1
      loser = print(f"{self.name} loses round and now has: {self.life_points} life points!")
      return loser
    else:
      other_Self.life_points -= 1
      loser = print(f"{other_Self.name} loses round and now has: {other_Self.life_points} life points!")
      return loser


    # call from other card class to save a card to the user instance.
    # this would draw a card for player, and display the card
 
    # compare player cards value, greater value wins, lesser value loses
    # conditional for if you lose the round, you lose 1 point.
    

Bob = User("Bob")
Robin = User("Robin")


Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)
Bob.draw_and_compare_display(Robin)

# print(Bob.deck.show_cards())

# def draw_cards(self):
#   for card in self.cards:
#     card.card_info()
