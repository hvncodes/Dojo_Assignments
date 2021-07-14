from flask import Flask, render_template, request, redirect, session
from random import randint

app = Flask(__name__)
app.secret_key = "SECRET KEY GOES HERE"
#Python\flask\fundamentals\great_number_game
@app.route('/')
def index():
    if "number" not in session:
        session["number"] = randint(1, 100)
    return render_template('index.html')

@app.route('/guess', methods=['POST'])
def guess():
    guess = int(request.form['guesser'])
    if guess > session["number"]:
        prompt = f'<div id="prompt" class="alert alert-danger text-center col-md-3 mx-auto" role="alert">Too High!</div>'
    elif guess < session["number"]:
        prompt = f'<div id="prompt" class="alert alert-danger text-center col-md-3 mx-auto" role="alert">Too Low!</div>'
    else:
        prompt = f'<div id="prompt" class="alert alert-success text-center col-md-3 mx-auto" role="alert">'
        prompt += f'{session["number"]} was the number!'
        prompt += f'<a href="/clear" class="btn btn-primary" role="button">Play Again!</a>'
        prompt += f'</div>'
    return render_template('index.html', prompt = prompt)

@app.route('/clear')
def sessionClear():
    session.clear()
    return redirect('/')

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"

if __name__=="__main__":
    app.run(debug=True)