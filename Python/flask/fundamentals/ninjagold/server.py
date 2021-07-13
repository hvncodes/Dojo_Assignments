from flask import Flask, render_template, request, redirect, session
from random import randint
from datetime import datetime

app = Flask(__name__)
app.secret_key = "SECRET KEY GOES HERE"

@app.route('/')
def index():
    if "gold" not in session:
        session["gold"] = 0
        session["activities"] = []
    return render_template('index.html')

# delete session
@app.route('/clear')
def sessionClear():
    session.clear()
    return redirect('/')

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

    now = datetime.now()
    current_time = now.strftime("%D %H: %M: %S")

    if gold == 0:
        session["activities"].append(f'<p>Lost {gold} gold from the {building} Whew! {current_time}</p>')
    elif gold > 0:
        session["activities"].append(f'<p class="won">Earned {gold} golds from the {building}! {current_time}</p>')
    else: # else gold negative
        session["activities"].append(f'<p class="lost">Entered a casino and and lost {abs(gold)} golds... Ouch.. {current_time}</p>')
    
    return redirect('/')

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"

if __name__=="__main__":
    app.run(debug=True)    # Run the app in debug mode.