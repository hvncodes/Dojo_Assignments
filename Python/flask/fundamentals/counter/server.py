from flask import Flask, render_template, redirect, session

app = Flask(__name__)
app.secret_key = "SECRET KEY GOES HERE"

#Python\flask\fundamentals\counter
@app.route('/')
def index():
    if "counter" not in session:
        session["counter"] = 1
    else:
        session["counter"] += 1
    return render_template('index.html')

@app.route('/add')
def add_visit():
    session["counter"] += 1
    return redirect('/')

@app.route('/clear')
def session_clear():
    session.clear()
    return redirect('/')

if __name__=="__main__":
    app.run(debug=True)