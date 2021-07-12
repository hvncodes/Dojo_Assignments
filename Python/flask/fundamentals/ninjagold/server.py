from flask import Flask, render_template, request, redirect, session
from random import randint

app = Flask(__name__)
app.secret_key = "SECRET KEY GOES HERE"

@app.route('/')
def index():
    if "gold" not in session:
        session["gold"] = 0
        session["activities"] = []
    return render_template('index.html')
# <form action="/process_money" method="post">
#   <input type="hidden" name="building" value="farm" />
#   <input type="submit" value="Find Gold!"/>
# </form>
@app.route('/process_money', methods=['POST'])
def process():
    building = request.form['building']
    if building == 'farm':
        gold = randint(10,20)
    elif building == 'cave':
        gold = randint(5,10)
    elif building == 'house':
        gold = randint(2,5)
    else: # casino
        gold = randint(-50,50)
    session["gold"] += gold

    if request.form['building'] == 'casino':
        session["activities"].append(f"Entered a casino and and lost {gold} golds... Ouch.. TIME")
    else:   #or farm, cave, house
        session["activities"].append(f"Earned {gold} golds from the {building}! TIME")
    return redirect('/')


@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"

if __name__=="__main__":
    app.run(debug=True)    # Run the app in debug mode.