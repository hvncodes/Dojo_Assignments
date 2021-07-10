from flask import Flask, render_template
app = Flask(__name__)
@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route('/play')
def play():
    return render_template('index.html', bgcolor="lightskyblue", numOfDiv=3)

@app.route('/play/<num>')
def playNum(num): #int(num)
    return render_template('index.html', bgcolor="lightskyblue", numOfDiv=int(num))

@app.route('/play/<num>/<color>')
def playNumColor(num, color):
    return render_template('index.html', bgcolor=color, numOfDiv=int(num))

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found<br>Sorry! No response. Try again."

if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.

