from flask import Flask, render_template
app = Flask(__name__)
@app.route('/')
def hello_world():
    return render_template('index.html', x=8, y=8)

@app.route('/<x>')
def playNum(x): #int(x)
    return render_template('index.html', x=int(x), y=8)

@app.route('/<x>/<y>')
def playNumColor(x, y):
    return render_template('index.html', x=int(x), y=int(y))

@app.errorhandler(404)
def page_not_found(e):
    return "404<br>Something is off here..."

if __name__=="__main__":
    app.run(debug=True)    # Run the app in debug mode.

